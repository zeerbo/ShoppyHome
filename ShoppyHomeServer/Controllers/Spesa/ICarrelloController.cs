using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoppyHomeServer.Models.Model.Spesa;

namespace ShoppyHomeServer.Controllers.Spesa
{
    public interface ICarrelloController
    {
        Boolean ModificaQuantitaProdotto(ElementoCatalogo p, int q);
        Boolean RimuoviProdotto(ElementoCatalogo p);
        Dictionary<ElementoCatalogo, int> GetElencoProdotti();
    }
}
