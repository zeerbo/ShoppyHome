using ShoppyHomeClient.Broker;
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
    public partial class Profilo : Form
    {
        private HomeSpesa _hs;
        private Utente _utente;

        public Profilo(HomeSpesa hs)
        {
            _hs = hs;
            InitializeComponent();
        }

        private void TornaHome_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _hs.Show();
            this.Close();
        }

        private void VaiStorico_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Profilo p = this;
            VisualStorici vs = new VisualStorici(p);
            vs.Show();
            this.Hide();
        }

        private void Modifica_Click(object sender, EventArgs e)
        {
            Object[] arguments = new Object[11];
            arguments[0] = BoxNomeModifica.Text;
            arguments[1] = BoxCognomeModifica.Text;
            arguments[2] = BoxDataModifica.Value;
            Int32.TryParse(BoxCivicoModifica.Text, out int n);
            int numeroCivico = n;
            arguments[3] = new Indirizzo(BoxProvinciaModifica.Text, BoxCittàModifica.Text, BoxViaModifica.Text, n);
            arguments[4] = BoxEmailModifica.Text;
            arguments[5] = BoxtelefonoModifica.Text;
            arguments[6] = BoxUsernameModifica.Text;
            arguments[7] = BoxPasswordModifica.Text;
         
            Richiesta r = new Richiesta("HomeProfilo", "Profilo", "ModificaDati", arguments);
        }

        private void Profilo_Load(object sender, EventArgs e)
        {
            _utente = _hs.Utente;

            if(_utente == null)
            {
                System.Windows.Forms.MessageBox.Show("Errore nel caricamento dei dati");
            }
            else
            {
                BoxNome.Text = _utente.Nome;
                BoxCognome.Text = _utente.Cognome;
                BoxData.Value = _utente.DataNascita;
                BoxProvincia.Text = _utente.Provincia;
                BoxCittà.Text = _utente.Citta;
                BoxVia.Text = _utente.Via;
                BoxCivico.Text = _utente.NumeroCivico.ToString();
                BoxEmail.Text = _utente.Email;
                BoxTelefono.Text = _utente.Telefono;
                BoxUsername.Text = _utente.Username;
                BoxPassword.Text = _utente.Password;
            }
        }
    }
}
