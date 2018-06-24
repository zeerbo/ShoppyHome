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
            //if le credenziali sono giute (DB) ritrona l'utente specificato
            return new Utente
            {
                Nome = "ciao",
                Cognome = "ciao",
                Citta = "ciao",
                DataNascita = DateTime.Now,
                DomandaRecuperoPassword = 1,
                Email = "ciao",
                NumeroCivico = 2,
                Password = "ciao",
                Provincia = "ciao",
                RispostaRecuperoPassword = "ciao",
                Telefono = "0258",
                Username = "ciao",
                Via = "ciao"
            };
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
