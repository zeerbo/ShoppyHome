using Newtonsoft.Json;
using ShoppyHomeServer.Models.Model.Spesa;
using ShoppyHomeServer.Models.Broker;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShoppyHomeServer.Models.Model.Profilo;
using NHibernate;
using NHibernate.Cfg;

namespace ShoppyHomeServer.Controllers.Spesa
{
    public class HomeSpesaController : Controller
    {
        private ICarrelloController _carrelloController;
        private ICatalogoController _catalogoController;
        private IGestioneSpesaController _gestioneSpesaController;
        private ISelezioneMarketController _selezioneMarketController;
        private IVerificaConfermaController _verificaConfermaController;
        private Carrello _carrello;
        private Utente _utente;
        private ISession _session;

        public HomeSpesaController()
        {
            Configuration config = new Configuration();
            config.Configure();
            ISessionFactory sessionFactory = config.BuildSessionFactory();
            _session = sessionFactory.OpenSession();

            _gestioneSpesaController = new GestioneSpesaController(_session);
            _selezioneMarketController = new SelezioneMarketController(_session);
        }

        //ICarrelloController
        public ActionResult ModificaQunatitaProdotto()
        {
            Richiesta r = Deserialize<Richiesta>();
            if (!GestoreSessione.GetGestoreSessione().VerificaSessione(r.Mittente))
            {
                GestoreSessione.GetGestoreSessione().EliminaSessione(r.Mittente);
                return Content(Serialize<bool>(false));
            }
            bool res =_carrelloController.ModificaQuantitaProdotto((ElementoCatalogo)r.Parametri[0], (int)r.Parametri[1]);
            return Content(Serialize<bool>(res));
        }

        public ActionResult RimuoviPRodotto()
        {
            Richiesta r = Deserialize<Richiesta>();
            if (!GestoreSessione.GetGestoreSessione().VerificaSessione(r.Mittente))
            {
                GestoreSessione.GetGestoreSessione().EliminaSessione(r.Mittente);
                return Content(Serialize<bool>(false));
            }
            bool res = _carrelloController.RimuoviProdotto((ElementoCatalogo)r.Parametri[0]);
            return Content(Serialize<bool>(res));
        }

        public ActionResult GetCarrello()
        {
            Richiesta r = Deserialize<Richiesta>();
            Dictionary<ElementoCatalogo, int> res = null;
            if (!GestoreSessione.GetGestoreSessione().VerificaSessione(r.Mittente))
            {
                GestoreSessione.GetGestoreSessione().EliminaSessione(r.Mittente);
                return Content(Serialize<Dictionary<ElementoCatalogo, int>>(res));
            }
            res = _carrelloController.GetElencoProdotti();
            return Content(Serialize<Dictionary<ElementoCatalogo, int>>(res));
        }

        //ICatalogoController
        public ActionResult AggiungiProdotto()
        {
            Richiesta r = Deserialize<Richiesta>();
            _catalogoController.AggiungiProdotto((ElementoCatalogo)r.Parametri[0]);
            return Content(Serialize<Object>(null));
        }

        public ActionResult GetCatalogo()
        {
            Richiesta r = Deserialize<Richiesta>();
            _carrello = new Carrello();
            _carrelloController = new CarrelloController(_carrello, _session);
            _catalogoController = new CatalogoController(_carrello, _session);
            Catalogo res = null;
            if (!GestoreSessione.GetGestoreSessione().VerificaSessione(r.Mittente))
            {
                GestoreSessione.GetGestoreSessione().EliminaSessione(r.Mittente);
                return Content(Serialize<Catalogo>(res));
            }
            res = _catalogoController.GetCatalogo((Supermarket)r.Parametri[0]);
            return Content(Serialize<Catalogo>(res));
        }

        //IGestioneSpesaController
        public ActionResult GetSaldo()
        {
            Richiesta r = Deserialize<Richiesta>();
            float res = -1;
            if (!GestoreSessione.GetGestoreSessione().VerificaSessione(r.Mittente))
            {
                GestoreSessione.GetGestoreSessione().EliminaSessione(r.Mittente);
                return Content(Serialize<float>(res));
            }
            res = _gestioneSpesaController.GetSaldo((Carrello)r.Parametri[0]);
            return Content(Serialize<float>(res));
        }

        //ISelezioneMarket
        public ActionResult GetElencoSupermarker()
        {
            Richiesta r = Deserialize<Richiesta>();
            List<Supermarket> res = null;
            if (!GestoreSessione.GetGestoreSessione().VerificaSessione(r.Mittente))
            {
                GestoreSessione.GetGestoreSessione().EliminaSessione(r.Mittente);
                return Content(Serialize<List<Supermarket>>(res));
            }
            res = _selezioneMarketController.GetElencoSupermarket();
            _utente = (Utente) r.Parametri[0];
            return Content(Serialize<List<Supermarket>>(res));
        }

        //IVerificaConferma
        public ActionResult TerminaSpesa()
        {
            Richiesta r = Deserialize<Richiesta>();
            _verificaConfermaController = new VerificaConfermaController(_carrello, _utente, _session);
            if (!GestoreSessione.GetGestoreSessione().VerificaSessione(r.Mittente))
            {
                GestoreSessione.GetGestoreSessione().EliminaSessione(r.Mittente);
                return Content(Serialize<bool>(false));
            }
            bool res = _verificaConfermaController.TerminaSpesa();
            GestoreSessione.GetGestoreSessione().EliminaSessione(r.Mittente);
            return Content(Serialize<bool>(res));
        }

        public ActionResult GetOrdine()
        {
            Richiesta r = Deserialize<Richiesta>();
            Dictionary<ElementoCatalogo, int> res = null;
            if (!GestoreSessione.GetGestoreSessione().VerificaSessione(r.Mittente))
            {
                GestoreSessione.GetGestoreSessione().EliminaSessione(r.Mittente);
                return Content(Serialize<Dictionary<ElementoCatalogo, int>>(res));
            }
            res = _verificaConfermaController.GetElencoProdotti();
            return Content(Serialize<Dictionary<ElementoCatalogo, int>>(res));
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