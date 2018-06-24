using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using ShoppyHomeServer.Models.Model.Spesa;

namespace ShoppyHomeServer.Controllers.Spesa
{
    public class CarrelloController : ICarrelloController
    {
        private Carrello _carrello;
        private ISession _session;

        public CarrelloController(Carrello carrello, ISession session)
        {
            _carrello = carrello;
            _session = session;
        }
        
        private void AggiornaSaldo()
        {
            float saldo = _carrello.MostraTotale();
            //aggiorna il saldo nella view
        }

        public Boolean RimuoviProdotto(ElementoCatalogo p)
        {
            Boolean res = _carrello.EliminaProdotto(p);
            //aggiorna db
            AggiornaSaldo();
            return res;
        }

        public Boolean ModificaQuantitaProdotto(ElementoCatalogo p, int q)
        {
            Boolean res =_carrello.SetQuantita(p, q);
            //aggiorna db
            AggiornaSaldo();
            return res;
        }

        public Dictionary<ElementoCatalogo,int> GetElencoProdotti()
        {
            return _carrello.ElencoProdottiScelti();
        }
    }
}
