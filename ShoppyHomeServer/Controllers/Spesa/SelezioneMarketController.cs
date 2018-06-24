using NHibernate;
using ShoppyHomeServer.Models.Model.Spesa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppyHomeServer.Controllers.Spesa
{
    public class SelezioneMarketController : ISelezioneMarketController
    {
        private List<Supermarket> _supermarkets;
        private ISession _session;

        public SelezioneMarketController(ISession session)
        {
            _session = session;
            //query ad DB per popolare _supermarkets
            using(ITransaction t = _session.BeginTransaction())
            {
                _supermarkets = _session.Query<Supermarket>().ToList();
                t.Commit();
            }
        }

        public List<Supermarket> GetElencoSupermarket()
        {
            return _supermarkets;
        }
    }
}
