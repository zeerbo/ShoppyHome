using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppyHomeServer.Models.Model.Spesa
{
    public class Supermarket
    {
        public virtual int IdNegozio { get; set; }
        public virtual String Provincia { get; set; }
        public virtual String Citta { get; set; }
        public virtual String Via { get; set; }
        public virtual int NumeroCivico { get; set; }
        public virtual int IdMarket { get; set; }
    }
}
