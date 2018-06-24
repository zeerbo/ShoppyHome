using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using ShoppyHomeServer.Models.Model.Profilo;

namespace ShoppyHomeServer.Controllers.Profilo
{
    public class StoricoController : IStoricoController
    {
        private Storico _storico;
        private ISession _session;

        public StoricoController(Utente u, ISession session)
        {
            //Query al DB per creare lo storico dello specifico utente
            _session = session;
            _storico = new Storico(new List<ShoppyHomeServer.Models.Model.Profilo.Spesa>())
        }

        public List<ShoppyHomeServer.Models.Model.Profilo.Spesa> ElencoOrdini()
        {
            return _storico.StoricoOrdini();
        }
    }
}
