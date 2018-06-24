using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppyHomeServer.Models.Model.Profilo
{
    public class Storico
    {
        private List<Spesa> _storico;

        public Storico(List<Spesa> storico)
        {
            _storico = storico;
        }

        public List<Spesa> StoricoOrdini()
        {
            return _storico;
        }
    }
}
