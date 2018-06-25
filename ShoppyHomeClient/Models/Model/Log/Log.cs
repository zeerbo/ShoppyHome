using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppyHomeClient.Models.Model.Log
{
    public class Log
    {
        private List<Entry> _entries;

        public Log(List<Entry> entries)
        {
            _entries = entries;
        }

        public List<Entry> Entries
        {
            get { return _entries; }
            set { _entries = value; }
        }
    }
}
