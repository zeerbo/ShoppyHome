using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using ShoppyHomeServer.Models.Model.Spesa;

namespace ShoppyHomeServer.Controllers.Spesa
{

    public class GestioneSpesaController : IGestioneSpesaController
    {
        private ISession _session;

        public GestioneSpesaController(ISession session)
        {
            _session = session;
        }

        public float GetSaldo(Carrello c)
        {
            return c.MostraTotale(); 
        }

       /*public Connection GetConnection()
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
