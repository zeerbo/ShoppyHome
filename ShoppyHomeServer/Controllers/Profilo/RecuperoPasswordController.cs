using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using ShoppyHomeServer.Models.Model.Profilo;

namespace ShoppyHomeServer.Controllers.Profilo
{
    public class RecuperoPasswordController : IRecuperoPasswordController
    {
        private ISession _session;

        public RecuperoPasswordController(ISession session)
        {
            _session = session;
        }

        public Boolean VerificaDomandaSicurezza(String risposta, String username)
        {
            Boolean result = false;
            //Non so se va bene così o serva connettersi ad un DB
            //In questa soluzione si suppone di sapere qual'è l'utente loggato e quindi che possa
            //essere passato come paramentro al momento della crezione del controller
            // if (_utente.RispostaRecuperoPassword.Equals(risposta)) result = true;
            return result;
        }

        private void InviaMail(String password)
        {
            //invio mail
        }
    }
}
