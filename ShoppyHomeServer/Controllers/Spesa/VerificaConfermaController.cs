using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoppyHomeServer.Models.Model.Spesa;
using ShoppyHomeServer.Models.Model.Profilo;
using NHibernate;

namespace ShoppyHomeServer.Controllers.Spesa
{
    public class VerificaConfermaController : IVerificaConfermaController
    {
        private Ordine _ordine;
        private Utente _utente;
        private ISession _session;

        public VerificaConfermaController(Carrello c, Utente u, ISession session)
        {
            _ordine = new Ordine(u, c);
            _utente = u;
            _session = session;
        }

        public Dictionary<ElementoCatalogo,int> GetElencoProdotti()
        {
            return _ordine.RiepilogoOrdine();
        }

        public Boolean TerminaSpesa(Indirizzo indirizzo)
        {
            if (indirizzo != null){
                ModificaIndirizzo(indirizzo);
            }
            InviaSpesa();
            return true;
        }

        private void InviaSpesa()
        {
            //metodo che invia l'Ordine al Supermercato di riferimento
        }

        private void ModificaIndirizzo(Indirizzo indirizzo)
        {
            _utente.Provincia = indirizzo.Provincia;
            _utente.Citta = indirizzo.Citta;
            _utente.Via = indirizzo.Via;
            _utente.NumeroCivico = indirizzo.NumeroCivico;

            using (ITransaction t = _session.BeginTransaction())
            {
                _session.SaveOrUpdate(_utente);
                t.Commit();
            }
        }
    }
}
