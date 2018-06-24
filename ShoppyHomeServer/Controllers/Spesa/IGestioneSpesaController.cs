using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoppyHomeServer.Models.Model.Spesa;

namespace ShoppyHomeServer.Controllers.Spesa
{
    public interface IGestioneSpesaController
    {
        float GetSaldo(Carrello c);
    }
}
