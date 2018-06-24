using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppyHomeServer.Models.Model.Profilo
{
    public class DomandaSicurezza
    {
        public virtual int IdDomanda { get; set; }
        public virtual String Domanda { get; set; }
    }
}
