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
    public partial class RegistrazioneApp : Form
    {
        private Login _login;
        public RegistrazioneApp(Login l)
        {
            _login = l;
            InitializeComponent();
        }

        private void VaiLogin_Click(object sender, EventArgs e)
        {
            _login.Show();
            Close();
        }

        private void ConfermaRegistrazione_Click(object sender, EventArgs e)
        {
            Object[] arguments = new object[10];

            arguments[0] = NomeBox.Text;
            arguments[1] = CognomeBox.Text;
            arguments[2] = DataBox.Value;
            Int32.TryParse(CivicoBox.Text, out int n);
            Indirizzo i = new Indirizzo(ProvinciaBox.Text, CittaBox.Text, ViaBox.Text, n);
            arguments[4] = EmailBox.Text;
            arguments[5] = TelefonoBox.Text;
            arguments[6] = UsernameBox.Text;
            arguments[7] = PasswordBox.Text;
            arguments[8] = DomandaBox.Text;
            arguments[9] = RispostaBox.Text;

            Richiesta r = new Richiesta("HomeProfilo", "Registrazione", "RegistraUtente", arguments);

            Boolean result = Task.Run(() => FiltroRichieste.GestisciRichiesta<Boolean>(r)).Result;

            if(result == true)
            {
                _login.Show();
            }
            else
            {
                MessageBox.Show("Registrazione non riuscita");
            }
        }

        private void RegistrazioneApp_Load(object sender, EventArgs e)
        {

        }
    }
}
