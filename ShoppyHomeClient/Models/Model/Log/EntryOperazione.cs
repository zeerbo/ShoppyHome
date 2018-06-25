using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppyHomeClient.Models.Model.Log
{
    public class EntryOperazione : Entry
    {
        private String _operazione;

        public EntryOperazione(DateTime dataOra, String operazione)
        {
            _dataOra = dataOra;
            _operazione = operazione;
        }


        public String Operazione
        {
            get { return _operazione; }
            set { _operazione = value; }
        }
    }
}
