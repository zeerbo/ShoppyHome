using ShoppyHomeClient.Models.Model.Profilo;
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
    public partial class Verifica_Conferma : Form
    {
        private Carrello _carrelloSessione;
        private Catalogo _catalogoSessione;
        private Boolean _fromCarrello;
        private Utente _utente;
        private ShoppyHomeClient.Models.Model.Spesa.Carrello _carrello;

        public Verifica_Conferma(Carrello carrello, Catalogo catalogo, Boolean fc)
        {
            _carrelloSessione = carrello;
            _catalogoSessione = catalogo;
            _fromCarrello = fc;
            InitializeComponent();
            //ottengo utente e carello
            _utente = null;
            _carrello = null;
            if (_utente == null || _carrello == null)
            {
                System.Windows.Forms.MessageBox.Show("Errore");
            }
            else
            {
                int qta;
                ListViewItem lvi = new ListViewItem();
                List<ElementoCatalogo> keys = new List<ElementoCatalogo>(_carrello.ElencoProdottiScelti().Keys);
                foreach (ElementoCatalogo e in keys)
                {
                    _carrello.ElencoProdottiScelti().TryGetValue(e, out qta);
                    lvi.Text = e.IdNegozio.ToString();
                    //lvi.SubItems.Add("" + p.Prezzo);
                    lvi.SubItems.Add("" + qta);
                    VistaCarrello.Items.Add(lvi);
                }

                this.Nome.Text = _utente.Nome;
                this.Cognome.Text = _utente.Cognome;
                this.Email.Text = _utente.Email;
                this.Telefono.Text = _utente.Telefono;
                this.Provincia.Text = _utente.Provincia;
                this.Citta.Text = _utente.Citta;
                this.Via.Text = _utente.Via;
                this.Civico.Text = "" + _utente.NumeroCivico;
                DateTime now = DateTime.Today;
                now = new DateTime(now.Year, now.Month, now.Day + 1, 8, 30, 0);
                this.DataConsegna.Value = now;
            }
        }

        public Verifica_Conferma()
        {
        }

        private void Concludi_Click(object sender, EventArgs e)
        {
            _catalogoSessione.homeSpesa.Show();
            _catalogoSessione.Close();
            _carrelloSessione.Close();
            //termina spesa (Controller) con CambiaIndirizzo.Checked

            Close();
        }

        private void Annulla_Click(object sender, EventArgs e)
        {
            if (_fromCarrello) _carrelloSessione.Show();
            else _catalogoSessione.Show();
            Close();
        }
    }
}
