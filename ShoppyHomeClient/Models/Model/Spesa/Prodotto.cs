using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppyHomeClient.Models.Model.Spesa
{
    public class Prodotto
    {
        public virtual int IdProdotto { get; set; }
        public virtual String Nome { get; set; }
        public virtual String Descrizione { get; set; }
        public virtual Image Immagine { get; set; }
    }
}
