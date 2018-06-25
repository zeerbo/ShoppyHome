using ShoppyHomeClient.Models.Model.Log;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoppyHomeClient.Views
{
    public partial class Log : Form
    {
        public Log()
        {
            InitializeComponent();
        }

        public void printLog(List<Entry> le)
        {
            DateTime dt;
            ListViewItem lvi = new ListViewItem();
            EntryMessaggio em = new EntryMessaggio(dt = new DateTime(), null);

            foreach (Entry e in le)
            {
                if (e.GetType().Equals(em.GetType()))
                {
                    em = (EntryMessaggio)e;
                    lvi.Text = e.DataOra.ToString();
                    lvi.SubItems.Add(em.Messagio);
                    ListaLog.Items.Add(lvi);
                }
            }
        }

        private void Chiudi_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
