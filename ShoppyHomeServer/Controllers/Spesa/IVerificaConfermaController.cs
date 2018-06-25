using ShoppyHomeServer.Models.Model.Profilo;
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
        Boolean TerminaSpesa(Indirizzo indirizzo);

        Dictionary<ElementoCatalogo, int> GetElencoProdotti();
    }
}
