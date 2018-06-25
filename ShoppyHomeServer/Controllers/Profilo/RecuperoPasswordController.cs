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
            using (ITransaction t = _session.BeginTransaction())
            {
                Utente utente = _session.Query<Utente>()
                    .Where(u => u.Username == username && u.RispostaRecuperoPassword == risposta).FirstOrDefault();
                if (utente != null) result = true;
            }
            return result;
        }

        private void InviaMail(String password)
        {
            //invio mail
        }
    }
}
