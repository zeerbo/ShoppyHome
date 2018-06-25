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
            _session = session;
            using (ITransaction t = _session.BeginTransaction()) {
                List<Models.Model.Profilo.Spesa> spese = _session.Query<Models.Model.Profilo.Spesa>()
                    .Where(s => s.Username == u.Username).ToList();
                _storico = new Storico(spese);
                t.Commit();
            }
        }

        public List<Models.Model.Profilo.Spesa> ElencoOrdini()
        {
            return _storico.StoricoOrdini();
        }
    }
}
