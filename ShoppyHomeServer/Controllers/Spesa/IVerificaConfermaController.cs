using ShoppyHomeServer.Models.Model.Spesa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppyHomeServer.Controllers.Spesa
{
    public interface IVerificaConfermaController 
    {
        Boolean TerminaSpesa();

        Dictionary<ElementoCatalogo, int> GetElencoProdotti();
    }
}
