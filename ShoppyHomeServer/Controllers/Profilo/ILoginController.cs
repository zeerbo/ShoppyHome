using ShoppyHomeServer.Models.Model.Profilo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppyHomeServer.Controllers.Profilo
{
    public interface ILoginController
    {
        Utente VerificaCredenziali(String username, String password);
    }
}
