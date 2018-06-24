using NHibernate;
using ShoppyHomeServer.Models.Model.Profilo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppyHomeServer.Controllers.Profilo
{
    public class LoginController : ILoginController
    {
        private ISession _session;

        public LoginController(ISession session)
        {
            _session = session;
        }

        public Utente VerificaCredenziali(String username, String password)
        {
            Utente u = null;
            using (ITransaction t = _session.BeginTransaction())
            {
                u = _session.Query<Utente>().Where(utente => utente.Username == username && utente.Password == password).FirstOrDefault();
                t.Commit();
            }

            return u;
        }

       /* public Connection GetConnection()
        {
            //Server il db (non trovo il tipo Connection...)
        }*/

        public void PrintMessaggio()
        {
            //Server il file log
        }

        public void PrintOperazione()
        {
            //Server il file di log
        }
    }
}
