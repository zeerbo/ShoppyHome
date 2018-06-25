using ShoppyHomeClient.Broker;
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
    public partial class RecuperoPassword : Form
    {
        private Login _login;
        public RecuperoPassword(Login l)
        {
            _login = l;
            InitializeComponent();
        }

        private void TornaLogin_Click(object sender, EventArgs e)
        {
            _login.Show();
            Close();
        }

        private void RichiediRecupero_Click(object sender, EventArgs e)
        {
            Object[] arguments = new object[2];

            arguments[0] = RispostaRecupero.Text;
            arguments[1] = TextUsername.Text;         
            Richiesta r = new Richiesta("HomeProfilo", "RecuperoPassword", "VerificaDomandaSicurezza", arguments);
            Boolean recupero = Task.Run(() => FiltroRichieste.GestisciRichiesta<Boolean>(r)).Result;

            if(recupero == true)
            {
                _login.Show();
            }
            else
            {
                MessageBox.Show("Recupero Password non riuscito");
            }
        }
    }
}
