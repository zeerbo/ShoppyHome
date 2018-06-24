using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoppyHomeServer.Models.Broker
{
    public class GestoreSessione 
    {
        private static GestoreSessione _gestoreSessione = null;
        private List<SessioniAttive> _sessioniAttive;

        protected GestoreSessione()
        {
            _gestoreSessione = new GestoreSessione();
            _sessioniAttive = new List<SessioniAttive>();
        }

        public static GestoreSessione GetGestoreSessione()
        {
            if (_gestoreSessione == null)
               _gestoreSessione = new GestoreSessione();
            return _gestoreSessione;
        }

        public void CreaSessione(Sessione sessione)
        {
            _sessioniAttive.Add(new SessioniAttive(sessione.IpClient, sessione));
        }

        public bool VerificaSessione(String chiave)
        {
            Sessione temp = null;
            foreach(SessioniAttive s in _sessioniAttive)
            {
                if (s.Chiave.Equals(chiave))
                    temp = s.Sessione;
            }
            if (!temp.Equals(null))
            {
                if (DateTime.Compare(temp.DataScadenza, DateTime.Now) < 0)
                {
                    EliminaSessione(chiave);
                    return false;
                }
                else
                    return true;
            }
            else
                return false;
        }

        public void EliminaSessione(String chiave)
        {
            foreach(SessioniAttive s in _sessioniAttive)
            {
                if (s.Chiave.Equals(chiave))
                    _sessioniAttive.Remove(s);
            }
        }
    }
}