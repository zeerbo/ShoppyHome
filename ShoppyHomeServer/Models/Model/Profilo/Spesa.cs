using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppyHomeServer.Models.Model.Profilo
{
    public class Spesa
    {
        public virtual String Username { get; set; }
        public virtual int IdProdotto { get; set; }
        public virtual int Quantita { get; set; }
        public virtual DateTime Data { get; set; }
        public virtual DateTime Ora { get; set; }

        public override bool Equals(object obj)
        {
            bool result = true;
            if (obj == null || GetType() != obj.GetType()) result = false;
            Spesa s = (Spesa)obj;
            if (!Username.Equals(s.Username) || IdProdotto != s.IdProdotto) result = false;
            return result;
        }

        public override int GetHashCode()
        {
            //Josh Bloch's Effective Java
            int hash = 17;
            hash = hash * 23 + Username.GetHashCode();
            hash = hash * 23 + IdProdotto.GetHashCode();
            return hash;
        }
    }
}
