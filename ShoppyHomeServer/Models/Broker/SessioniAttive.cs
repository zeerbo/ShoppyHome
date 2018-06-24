using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoppyHomeServer.Models.Broker
{
    public class SessioniAttive
    {
        private String _chiave;
        private Sessione _sessione;

        public SessioniAttive(string chiave, Sessione sessione)
        {
            _chiave = chiave;
            _sessione = sessione;
        }

        public String Chiave
        {
            get
            {
                return _chiave;
            }
        }

        public Sessione Sessione
        {
            get
            {
                return _sessione;
            }
        }
    }
}