using ShoppyHomeClient.Models.Model.Spesa;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.ListView;

namespace ShoppyHomeClient.Views
{
    public partial class Catalogo : Form
    {
        private Carrello _carrelloSessione;
        private HomeSpesa _homeSpesa;

        public Carrello CarrelloSessione
        {
            get { return _carrelloSessione; }
            set { _carrelloSessione = value; }
        }

        public HomeSpesa homeSpesa
        {
            get { return _homeSpesa;  }
        }

        public Catalogo(HomeSpesa hs)
        {
            _homeSpesa = hs;
            InitializeComponent();
            List<Prodotto> prodotti = null;
            /*ricevo la lista dal Controller, FiltroRichieste/CatalogoController.GetElencoProodotti()*/
            if (prodotti == null)
            {
                System.Windows.Forms.MessageBox.Show("Errore nel caricamento dei dati");
            }
            else
            {
                ListViewItem lvi = new ListViewItem();
                foreach (Prodotto p in prodotti)
                {
                    lvi.Text = p.Nome;
                    lvi.SubItems.Add(p.Descrizione);
                    //lvi.SubItems.Add("" + p.Prezzo);
                    //lvi.SubItems.Add(Immagine)
                    VistaCatalogo.Items.Add(lvi);
                }
            }
        }

        private void AggiungiButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show(toStringa(VistaCatalogo.SelectedItems));
        }

        public String toStringa(SelectedListViewItemCollection slvic)
        {
            String result = "";
            foreach (ListViewItem lvi in slvic)
            {
                result += lvi.Text + " ";
            }
            return result;
        }

        private void Termina_Click(object sender, EventArgs e)
        {
            Verifica_Conferma vc = new Verifica_Conferma(_carrelloSessione, this, false);
            vc.Show();
            Hide();
        }

        private void Carrello_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _carrelloSessione.Show();
            Hide();
        }

    }
}