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
    public partial class Login : Form
    {
        private Utente _utente;
        public Login()
        {
            InitializeComponent();
        }

        private void Recupero_Click(object sender, EventArgs e)
        {
            RecuperoPassword rp = new RecuperoPassword(this);
            rp.Show();
            this.Hide();
        }

        private int i = 1;
        private void loginButton_Click(object sender, EventArgs e)
        {
            Object[] parametri = new Object[2];
            parametri[0] = Username.Text;
            parametri[1] = Password.Text;
            Richiesta r = new Richiesta("HomeProfilo", "Login", "VerificaCredenziali", parametri);
            _utente = Task.Run(() => FiltroRichieste.GestisciRichiesta<Utente>(r)).Result;
            HomeSpesa hs = new HomeSpesa(_utente);
            hs.Show();
            this.Hide();
        }

        private void Registrati_Click(object sender, EventArgs e)
        {
            RegistrazioneApp reg = new RegistrazioneApp(this);
            reg.Show();
            this.Hide();
        }
    }
}
