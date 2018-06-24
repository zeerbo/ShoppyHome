﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using ShoppyHomeServer.Models.Model.Profilo;

namespace ShoppyHomeServer.Controllers.Profilo
{
    public class RegistrazioneController : IRegistrazioneController
    {
        private Utente _utente;
        private ISession _session;

        public RegistrazioneController(ISession session)
        {
            _session = session;
        }

        private Boolean UsernameValido(String username)
        {
            Boolean result = false;
            //query su db che imposta result a "true" se non trova altri username uguali
            return result;
        }

        private Boolean IsNumeric(String stringa)
        {
            return int.TryParse(stringa, out int n);
        }

        public Boolean RegistraUtente(String nome, String cognome, DateTime dataNascita, Indirizzo indirizzo,
            String email, String telefono, String username, String password, String domandaRecPass, String rispostaRecPass)
        {
            Boolean result = true;

            DateTime now = DateTime.Today;
            int age = now.Year - dataNascita.Year;
            if (dataNascita > now.AddYears(-age)) age--;
            if (age < 18) result = false;
            if (!email.Contains("@")) result = false;
            if (!IsNumeric(telefono)) result = false;
            if (username.Length < 6 || !UsernameValido(username)) result = false;
            if (password.Length < 8) result = false;

            if (result)
            {
                int idDomanda = 0;
                //query per ottere l'Id della domanda
                _utente = new Utente
                {
                    Nome = nome,
                    Cognome = cognome,
                    DataNascita = dataNascita,
                    Provincia = indirizzo.Provincia,
                    Citta = indirizzo.Citta,
                    Via = indirizzo.Via,
                    NumeroCivico = indirizzo.NumeroCivico,
                    Email = email,
                    Telefono = telefono,
                    Username = username,
                    Password = password,
                    DomandaRecuperoPassword = idDomanda,
                    RispostaRecuperoPassword = rispostaRecPass
                };

                //aggiorno DB
            }
            return result;
        }
    }
}