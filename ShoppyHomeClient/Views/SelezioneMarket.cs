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
    public partial class SelezioneMarket : Form
    {
        private HomeSpesa _homeSpesa;
        public SelezioneMarket(HomeSpesa hs)
        {
            _homeSpesa = hs;
            InitializeComponent();
        }

        private void ConfermaButton_Click(object sender, EventArgs e)
        {
            String market = (String)ListaMarketBox.SelectedItem;
            //messaggio a schermo per verifica, da cancellare
            System.Windows.Forms.MessageBox.Show(market);
            //the end verifica
            Catalogo cat = new Catalogo(_homeSpesa);
            Carrello car = new Carrello(cat);
            cat.Show();
            Close();
        }
    }
}