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

namespace ShoppyHomeClient.Views
{
    public partial class Carrello : Form
    {
        private Catalogo _catalogoSessione;
        private ShoppyHomeClient.Models.Model.Spesa.Carrello _carrello;

        public Carrello(Catalogo catalogo)
        {
            _catalogoSessione = catalogo;
            InitializeComponent();
            _catalogoSessione.CarrelloSessione = this;
            //ottengo un oggetto carrello
            ShoppyHomeClient.Models.Model.Spesa.Carrello carrello = null/*da modificare*/;
            _carrello = carrello;
        }

        private void Termina_Click(object sender, EventArgs e)
        {
            Verifica_Conferma vc = new Verifica_Conferma(this,_catalogoSessione,true);
            vc.Show();
            Hide();
        }  

        private void Catalogo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _catalogoSessione.Show();
            Hide();
        }
    }
}
