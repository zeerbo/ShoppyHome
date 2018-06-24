using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppyHomeServer.Models.Model.Spesa
{
    public class ElementoCatalogo
    {
        public virtual int IdNegozio { get; set; }
        public virtual int IdProdotto { get; set; }
        public virtual float Prezzo { get; set; }
        public virtual int Disponibilita { get; set; }

        public override bool Equals(object obj)
        {
            bool result = true;
            if (obj == null || GetType() != obj.GetType()) result = false;
            ElementoCatalogo e = (ElementoCatalogo)obj;
            if (IdNegozio != e.IdNegozio || IdProdotto != e.IdProdotto) result = false;
            return result;
        }

        public override int GetHashCode()
        {
            //Josh Bloch's Effective Java
            int hash = 17;
            hash = hash * 23 + IdNegozio.GetHashCode();
            hash = hash * 23 + IdProdotto.GetHashCode();
            return hash;
        }
    }
}
