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
           /* if (!_ordine.Utente.Indirizzo.Equals(_utente.Indirizzo questo è lo stesso utente, credo che qui bisogni 
                controllare il dato inserito nella casella di testo della view ))
                ModificaIndirizzo(_utente.Indirizzo);*/

            InviaSpesa();
            return true;
        }

        private void InviaSpesa()
        {
            //metodo che invia l'Ordine al Supermercato di riferimento
        }

        private void ModificaIndirizzo(Indirizzo indirizzo)
        {
            //controllo se l'opzione nella view è spuntata
            //_ordine.Utente.Indirizzo = indirizzo;
        }
    }
}
