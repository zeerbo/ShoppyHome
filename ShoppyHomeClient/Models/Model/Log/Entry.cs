using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppyHomeClient.Models.Model.Log
{
    public abstract class Entry
    {
        protected DateTime _dataOra;

        public DateTime DataOra
        {
            get { return _dataOra; }
            set { _dataOra = value; }
        }
    }
}
