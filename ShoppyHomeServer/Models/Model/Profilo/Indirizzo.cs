using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppyHomeServer.Models.Model.Profilo
{
    public class Indirizzo
    {
        private String _provincia { get; set; }
        private String _citta { get; set; }
        private String _via { get; set; }
        private int _numeroCivico { get; set; }

        public Indirizzo(String provincia, String citta, String via, int numeroCivico)
        {
            _provincia = provincia;
            _citta = citta;
            _via = via;
            _numeroCivico = numeroCivico;
        }

        public String Provincia
        {
            get { return _provincia; }
            set { _provincia = value; }
        }

        public String Citta
        {
            get { return _citta; }
            set { _citta = value; }
        }

        public String Via
        {
            get { return _via; }
            set { _via = value; }
        }

        public int NumeroCivico
        {
            get { return _numeroCivico; }
            set { _numeroCivico = value; }
        }

        public override bool Equals(object obj)
        {
            bool result = true;
            if (obj == null || GetType() != obj.GetType()) result = false;
            Indirizzo i = (Indirizzo)obj;
            if (!_provincia.Equals(i.Provincia) || !_citta.Equals(i.Citta) ||
                !_via.Equals(i.Via) || _numeroCivico != i.NumeroCivico) result = false;
            return result;
        }

        public override int GetHashCode()
        {
            var hashCode = -544926566;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(_provincia);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(_citta);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(_via);
            hashCode = hashCode * -1521134295 + _numeroCivico.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Provincia);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Citta);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Via);
            hashCode = hashCode * -1521134295 + NumeroCivico.GetHashCode();
            return hashCode;
        }
    }
}
