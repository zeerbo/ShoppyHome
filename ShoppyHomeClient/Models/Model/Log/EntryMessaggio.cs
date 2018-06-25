using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppyHomeClient.Models.Model.Log
{
    public class EntryMessaggio : Entry
    {
        private String _messaggio;

        public EntryMessaggio(DateTime dataOra, String messaggio)
        {
            _dataOra = dataOra;
            _messaggio = messaggio;
        }

        public String Messagio
        {
            get { return _messaggio; }
            set { _messaggio = value; }
        }
    }
}
