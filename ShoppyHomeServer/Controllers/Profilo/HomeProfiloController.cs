using Newtonsoft.Json;
using NHibernate;
using NHibernate.Cfg;
using ShoppyHomeServer.Models.Broker;
using ShoppyHomeServer.Models.Model.Profilo;
using ShoppyHomeServer.Models.Model.Spesa;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShoppyHomeServer.Controllers.Profilo
{
    public class HomeProfiloController : Controller
    {
        private IGestioneProfiloController _gestioneProfiloController;
        private ILoginController _loginController;
        private IRecuperoPasswordController _recuperoPasswordController;
        private IRegistrazioneController _registrazioneController;
        private IStoricoController _storicoController;
        private Utente _utente;
        private ISession _session;

        public HomeProfiloController()
        {
            Configuration config = new Configuration();
            config.Configure();
            ISessionFactory sessionFactory = config.BuildSessionFactory();
            _session = sessionFactory.OpenSession();

            _loginController = new LoginController(_session);
            _registrazioneController = new RegistrazioneController(_session);
            _recuperoPasswordController = new RecuperoPasswordController(_session);
        }

        
        //IGestionePofiloController
        public ActionResult ModificaDati() 
        {
            Richiesta r = Deserialize<Richiesta>();
            if (!GestoreSessione.GetGestoreSessione().VerificaSessione(r.Mittente))
            {
                GestoreSessione.GetGestoreSessione().EliminaSessione(r.Mittente);
                return Content(Serialize<bool>(false));
            }
            bool res = _gestioneProfiloController.ModificaDati((String)r.Parametri[0], (String)r.Parametri[1],
                (DateTime)r.Parametri[2], (Indirizzo)r.Parametri[3], (String)r.Parametri[4],
                (String)r.Parametri[5], (String)r.Parametri[6], (String)r.Parametri[7]);
            return Content(Serialize<bool>(res));
        }

        public ActionResult GetUtente()
        {
            Richiesta r = Deserialize<Richiesta>();
            if (!GestoreSessione.GetGestoreSessione().VerificaSessione(r.Mittente))
            {
                GestoreSessione.GetGestoreSessione().EliminaSessione(r.Mittente);
                Utente u = null;
                return Content(Serialize<Utente>(u));
            }
            Utente res = _gestioneProfiloController.GetUtente();
            return Content(Serialize<Utente>(res));
        }

        //ILogin
        public ActionResult VerificaCredenziali()
        {
            Richiesta r = Deserialize<Richiesta>();
            Utente res = _loginController.VerificaCredenziali((String)r.Parametri[0], (String)r.Parametri[1]);
            if (!GestoreSessione.GetGestoreSessione().VerificaSessione(r.Mittente))
            {
                DateTime scadenza = DateTime.Now;
                scadenza.AddHours(5);
                Sessione s = new Sessione("Cliente", DateTime.Now, scadenza, r.Mittente);
                GestoreSessione.GetGestoreSessione().CreaSessione(s);
            }
            else
            { 
                DateTime scadenza = DateTime.Now;
                scadenza.AddHours(5);
                Sessione s = new Sessione("Cliente", DateTime.Now, scadenza, r.Mittente);
                GestoreSessione.GetGestoreSessione().EliminaSessione(r.Mittente);
                GestoreSessione.GetGestoreSessione().CreaSessione(s);
            }
            _utente = res;
            _gestioneProfiloController = new GestioneProfiloController(_utente, _session);
            return Content(Serialize<Utente>(res));
        }

        //IRecuperPasswordController
        public ActionResult VerificaDomandaSicurezza()
        {
            Richiesta r = Deserialize<Richiesta>();
            if (!GestoreSessione.GetGestoreSessione().VerificaSessione(r.Mittente))
            {
                GestoreSessione.GetGestoreSessione().EliminaSessione(r.Mittente);
                return Content(Serialize<bool>(false));
            }
            bool res = _recuperoPasswordController.VerificaDomandaSicurezza((String)r.Parametri[0]);
            return Content(Serialize<bool>(res));
        }
        
        //IRegistrazioneController
        public ActionResult RegistraUtente()
        {
            Richiesta r = Deserialize<Richiesta>();
            if (!GestoreSessione.GetGestoreSessione().VerificaSessione(r.Mittente))
            {
                GestoreSessione.GetGestoreSessione().EliminaSessione(r.Mittente);
                return Content(Serialize<bool>(false));
            }
            bool res = _registrazioneController.RegistraUtente((String)r.Parametri[0], (String)r.Parametri[1],
                (DateTime)r.Parametri[2], (Indirizzo)r.Parametri[3], (String)r.Parametri[4],
                (String)r.Parametri[5], (String)r.Parametri[6], (String)r.Parametri[7], 
                (String)r.Parametri[8], (String)r.Parametri[9]);
            return Content(Serialize<bool>(res));
        }

        //IStroicoController
        public ActionResult ElencoOrdini()
        {
            Richiesta r = Deserialize<Richiesta>();
            _storicoController = new StoricoController(_utente, _session);
            List<ShoppyHomeServer.Models.Model.Profilo.Spesa> res = null;
            if (!GestoreSessione.GetGestoreSessione().VerificaSessione(r.Mittente))
            {
                GestoreSessione.GetGestoreSessione().EliminaSessione(r.Mittente);
                return Content(Serialize<List<ShoppyHomeServer.Models.Model.Profilo.Spesa>>(res));
            }
            res = _storicoController.ElencoOrdini();
            return Content(Serialize<List<ShoppyHomeServer.Models.Model.Profilo.Spesa>>(res));
        }

        private T Deserialize<T>()
        {
            Stream stream = HttpContext.Request.InputStream;
            using (var streamReader = new StreamReader(stream, HttpContext.Request.ContentEncoding))
            {
                var content = streamReader.ReadToEnd();
                return JsonConvert.DeserializeObject<T>(content);
            }
        }

        private string Serialize<T>(T obj)
        {
            return JsonConvert.SerializeObject(obj);
        }
    }
}