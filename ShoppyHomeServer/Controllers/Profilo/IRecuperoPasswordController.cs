using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppyHomeServer.Controllers.Profilo
{
    public interface IRecuperoPasswordController
    {
        Boolean VerificaDomandaSicurezza(String risposta, String username);
    }
}
