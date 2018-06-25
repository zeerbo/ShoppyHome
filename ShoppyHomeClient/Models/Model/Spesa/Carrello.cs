using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppyHomeClient.Models.Model.Spesa
{
    public class Carrello
    {
        Dictionary<ElementoCatalogo, int> _carrello;

        public Carrello()
        {
            _carrello = new Dictionary<ElementoCatalogo, int>();
        }

        public Dictionary<ElementoCatalogo, int> ElencoProdottiScelti()
        {
            return _carrello;
        }

        public float MostraTotale()
        {
            float totale = 0;
            int quantita = 0;

            foreach (ElementoCatalogo p in _carrello.Keys)
            {
                _carrello.TryGetValue(p, out quantita);
                totale += p.Prezzo * quantita;
            }

            return totale;
        }

        public bool EliminaProdotto(ElementoCatalogo p)
        {
            return _carrello.Remove(p);
        }

        public bool AddProdotto(ElementoCatalogo p)
        {
            if (_carrello.ContainsKey(p))
                SetQuantita(p, 1);
            else
                _carrello.Add(p, 1);
            return _carrello.ContainsKey(p);
        }

        public bool SetQuantita(ElementoCatalogo p, int q)
        {
            _carrello.TryGetValue(p, out int quantita);
            quantita += q;
            _carrello[p] = quantita;
            return _carrello[p] == quantita;
        }

    }
}
