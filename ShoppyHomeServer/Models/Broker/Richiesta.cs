using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppyHomeServer.Models.Broker
{
    [Serializable]
    public class Richiesta
    {
        private String _destinatario;
        private String _mittente;
        private String _servizio;
        private Object[] _parametri;

        public Richiesta(String destinatario, String mittente, String servizio, Object[] parametri)
        {
            _destinatario = destinatario;
            _mittente = mittente;
            _servizio = servizio;
            _parametri = parametri;
        }

        public String Destinatario
        {
            get
            {
                return _destinatario;
            }
        }
        public String Mittente
        {
            get
            {
                return _mittente;
            }
        }

        public String Servizio
        {
            get
            {
                return _servizio;
            }
        }

        public Object[] Parametri
        {
            get
            {
                return _parametri;
            }
        }

    }
}
