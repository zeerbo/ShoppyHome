using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoppyHomeServer.Models.Broker
{
    public class Sessione
    {
        private String _ruolo;
        private DateTime _dataCreazione;
        private DateTime _dataScadenza;
        private String _ipClient;

        public Sessione(string ruolo, DateTime dataCreazione, DateTime dataScadenza, string ipClient)
        {
            _ruolo = ruolo;
            _dataCreazione = dataCreazione;
            _dataScadenza = dataScadenza;
            _ipClient = ipClient;
        }

        public String Ruolo
        {
            get
            {
                return _ruolo;
            }
        }

        public DateTime DataCreazione
        {
            get
            {
                return _dataCreazione;
            }
        }

        public DateTime DataScadenza
        {
            get
            {
                return _dataScadenza;
            }
        }

        public String IpClient
        {
            get
            {
                return _ipClient;
            }
        }
    }
}