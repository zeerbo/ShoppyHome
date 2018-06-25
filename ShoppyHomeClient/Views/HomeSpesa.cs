using ShoppyHomeClient.Models.Model.Profilo;
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
    public partial class HomeSpesa : Form
    {
        public HomeSpesa(Utente u)
        {
            Utente = u;
            InitializeComponent();
        }

        public Utente Utente { get; set; }

        private void VaiProfilo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
                Profilo obj = new Profilo(this);
                obj.Show();
                Hide();
        }

        private void SelezionaMarket_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SelezioneMarket obj = new SelezioneMarket(this);
            obj.Show();
            Hide();
        }

        private void HomeSpesa_Load(object sender, EventArgs e)
        {

        }
    }
}
