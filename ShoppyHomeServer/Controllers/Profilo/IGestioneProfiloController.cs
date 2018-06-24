using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoppyHomeServer.Models.Model.Profilo;

namespace ShoppyHomeServer.Controllers.Profilo
{
    public interface IGestioneProfiloController
    {
        Boolean ModificaDati(String nome, String cognome, DateTime dataNascita, Indirizzo indirizzo,
            String email, String telefono, String username, String password);

        Utente GetUtente();
    }
}
