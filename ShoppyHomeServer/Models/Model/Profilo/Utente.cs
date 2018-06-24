using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppyHomeServer.Models.Model.Profilo
{
    public class Utente
    {
        public virtual String Username { get; set; }
        public virtual String Password { get; set; }
        public virtual String Nome { get; set; }
        public virtual String Cognome { get; set; }
        public virtual DateTime DataNascita { get; set; }
        public virtual String Provincia { get; set; }
        public virtual String Citta { get; set; }
        public virtual String Via { get; set; }
        public virtual int NumeroCivico { get; set; }
        public virtual String Email { get; set; }
        public virtual String Telefono { get; set; }

        public virtual int DomandaRecuperoPassword { get; set; }
        public virtual String RispostaRecuperoPassword { get; set; }
    }
}