using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Runtime.Serialization;

namespace Budzet_domowy.Classes.BuisnessLogic
{
    [DataContract]
    public class User : XmlStorage<User>
    {
        
        private string m_sUserName, m_sLogin, m_sEmail, m_sPassword;


        [DataMember]
        public string UserName
        {
            get => m_sUserName;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Pole 'Nazwa użytkownika' nie może być puste");

                m_sUserName = value;
            }
            
        }
        [DataMember]
        public string Login
        {
            get => m_sLogin;
            set
            {
                List<string> invalidChars = new List<string>() { "!", "@", "#", "$", "%", "^", "&", "*", "(", ")", "-" };

                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Pole 'Login' nie może być puste");
                } else if (!(!value.Equals(value.ToLower()))) {
                    throw new Exception("Login musi mieć conajmniej jedną wielką literę.");
                } else if (value.Length > 50 || value.Length < 5) {
                    throw new Exception("Nieprawidłowa liczba znaków. Długość Loginu musi być większa niż 4 i krótsza niż 50");
                } else {
                    foreach(string s in invalidChars)
                    {
                        if (value.Contains(s))
                        {
                            throw new Exception("Login zawiera niedowzwolone znaki.");
                        }
                    }
                }
                m_sLogin = value;
            }
            /* TO DO
                - Dodać sprawdzenie czy taki login istnieje już w systemie
                - Sprawdzenie na poziomie klasy czy gdzie indziej?
            */
        }
        [DataMember]
        public string Email
        {
            get => m_sEmail;
            set
            {
                var addr = new MailAddress(value);
                if (addr.Address != value)
                {
                    throw new Exception("Wpisz poprawny adres email.");
                }
                m_sEmail = value;
            }
            /* TO DO
                - Dodać sprawdzenie czy taki email istnieje już w systemie
                - Sprawdzenie na poziomie klasy czy gdzie indziej?
            */
        }
        [DataMember]
        public string Password
        {
            get => m_sPassword;
            set
            {
                string pattern = @"^(?=.*[a - z])(?=.*[A - Z])(?=.*\d).{ 7,20}$";
                var validation = new Regex(pattern);

                if (validation.IsMatch(value))
                {
                    throw new Exception("Hasło musi zawierać od 7 do 20 znaków, zawierać przynajmniej jeden numer oraz przynajmniej jedną wielką i małą literę");
                }
                m_sPassword = value;
            }
        }

        public override bool InitializeFromObject(User Object)
        {
            this.UserName = Object.UserName;
            this.Login = Object.Login;
            this.Email = Object.Email;
            this.Password = Object.Password;

            return true;
        }
    }
}
