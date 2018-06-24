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
            _supermarkets = new List<Supermarket>();
            //query ad DB per popolare _supermarkets
        }

        public List<Supermarket> GetElencoSupermarket()
        {
            return _supermarkets;
        }
    }
}
