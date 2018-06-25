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
    public partial class VisualStorici : Form
    {
        private Profilo _profilo;
        public VisualStorici(Profilo p)
        {
            _profilo = p;
            InitializeComponent();
        }

        private void TornaProfilo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _profilo.Show();
            Close();
        }
    }
}
