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
    public partial class GestioneLog : Form
    {
        public GestioneLog()
        {
            InitializeComponent();
        }

        private void VisioneLogB_Click(object sender, EventArgs e)
        {
            Log l = new Log();
            l.Show();
        }

        private void ElencoAnomalieB_Click(object sender, EventArgs e)
        {
            Anomalie a = new Anomalie();
            a.Show();
        }

        private void AnalisiOperazioneB_Click(object sender, EventArgs e)
        {

        }
    }
}
