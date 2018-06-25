using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using ShoppyHomeServer.Controllers.Profilo;
using ShoppyHomeServer.Models.Model.Profilo;

namespace ShoppyHomeServer.Controllers.Profilo
{
    public class GestioneProfiloController : IGestioneProfiloController
    {
        private Utente _utente;
        private ISession _session;

        public GestioneProfiloController(Utente utente, ISession session)
        {
            _utente = utente;
            _session = session;
        }

        public Boolean ModificaDati(String nome, String cognome, DateTime dataNascita, Indirizzo indirizzo,
            String email, String telefono, String username, String password)
        {
            Boolean result = true;

            DateTime now = DateTime.Today;
            int age = now.Year - dataNascita.Year;
            if (dataNascita > now.AddYears(-age)) age--;
            if (age < 18) result = false;
            if (!email.Contains("@")) result = false;
            if (!IsNumeric(telefono)) result = false;
            if (password.Length < 8) result = false;
            if (username.Length < 6 || !UsernameValido(username)) result = false;

            Indirizzo indUtente = new Indirizzo(_utente.Provincia, _utente.Citta, _utente.Via, _utente.NumeroCivico);

            if (result)
            {
                if (!_utente.Nome.Equals(nome)) _utente.Nome = nome;
                if (!_utente.Cognome.Equals(cognome)) _utente.Cognome = cognome;
                if (_utente.DataNascita.CompareTo(dataNascita) != 0) _utente.DataNascita = dataNascita;
                if (!indUtente.Equals(indirizzo))
                {
                    _utente.Provincia = indirizzo.Provincia;
                    _utente.Citta = indirizzo.Citta;
                    _utente.Via = indirizzo.Via;
                    _utente.NumeroCivico = indirizzo.NumeroCivico;
                }
                if (!_utente.Email.Equals(email)) _utente.Email = email;
                if (!_utente.Email.Equals(email)) _utente.Telefono = telefono;
                if (!_utente.Username.Equals(username)) _utente.Username = username;
                if (!_utente.Password.Equals(password)) _utente.Password = password;

                using (ITransaction t = _session.BeginTransaction())
                {
                    _session.SaveOrUpdate(_utente);
                    t.Commit();
                }
            }

            return result;
        }

        public Utente GetUtente()
        {
            return _utente;
        }

        private Boolean UsernameValido(String username)
        {
            Boolean result = false;
            using (ITransaction t = _session.BeginTransaction())
            {
                Utente utente = _session.Query<Utente>().Where(u => u.Username == username).FirstOrDefault();
                if (utente == null) result = true;
                t.Commit();
            }
            return result;
        }

        private Boolean IsNumeric(String stringa)
        {
            return int.TryParse(stringa, out int n);
        }
    }
}
