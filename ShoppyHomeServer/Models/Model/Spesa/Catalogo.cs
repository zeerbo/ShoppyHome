using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppyHomeServer.Models.Model.Spesa
{
    public class Catalogo
    {
        private List<ElementoCatalogo> _listaProdotti;

        public Catalogo(List<ElementoCatalogo> listaProdotti)
        {
            _listaProdotti = new List<ElementoCatalogo>();
            _listaProdotti = listaProdotti;
        }

        public List<ElementoCatalogo> ListaProdotti
        {
            get
            {
                return _listaProdotti;
            }
        }
    }
}
