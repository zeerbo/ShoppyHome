using ShoppyHomeServer.Models.Model.Spesa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppyHomeServer.Models.Model.Profilo
{
    public class Ordine
    {
        private Utente _utente;
        private Carrello _carrello;
        private DateTime _dataOra;

        public Ordine(Utente utente, Carrello carrello)
        {
            _utente = utente;
            _carrello = carrello;
        }

        public Utente Utente
        {
            get { return _utente; }
            set { _utente = value; }
        }

        public DateTime DataOra
        {
            get { return _dataOra; }
            set { _dataOra = value; }
        }

        public Dictionary<ElementoCatalogo, int> RiepilogoOrdine()
        {
            return _carrello.ElencoProdottiScelti();
        }
    }
}
