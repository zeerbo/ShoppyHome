using ShoppyHomeClient.Models.Model.Spesa;
using ShoppyHomeClient.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppyHomeClient.Models.Model.Profilo
{
    public class Ordine
    {
        private Utente _utente;
        private Model.Spesa.Carrello _carrello;
        private DateTime _dataOra;

        public Ordine(Utente utente, Model.Spesa.Carrello carrello)
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
