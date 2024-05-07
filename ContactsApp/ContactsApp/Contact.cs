using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace ContactsApp
{
    /// <summary>
    /// Класс, предназначенный для хранения информации об абоненте.
    /// </summary>
    public class Contact

    {
        private string _name;
        private string _surname;
        private PhoneNumber _phoneNumber = new PhoneNumber();
        private DateTime _birthday = DateTime.Today;
        private string _mail;
        private long _id;



        /// <summary>
        /// Свйоство, предназначеннное для запсии фамилии экземпляра класса.
        /// </summary>
        public string Surname
        {
            get
            {
                return _surname;
            }
            set
            {
                if (!string.IsNullOrEmpty(_surname) && _surname.Length <= 50)
                {
                    _surname = char.ToUpper(_surname[0]) + _surname.Substring(1);
                    _surname = value;
                }
                else
                {
                    throw new ArgumentException("Некорректные данные");
                }
                
            }
        }

        /// <summary>
        /// Свйоство, предназначеннное для запсии имени экземпляра класса.
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (!string.IsNullOrEmpty(_name) && _name.Length <= 50)
                {
                    _name = char.ToUpper(_name[0]) + _name.Substring(1);
                    _name = value;
                }
                else
                {
                    throw new ArgumentException("Некорректные данные");
                }
                
            }
        }

        /// <summary>
        /// Свйоство, предназначеннное для запсии номера телефона.
        /// </summary>
        public PhoneNumber PhoneNumber

        {
            get
            {
                return _phoneNumber;
            }

            set
            {
                
                _phoneNumber = value;
            }
        }

        /// <summary>
        /// Свйоство, предназначеннное для запсии даты рождения экземпляра класса.
        /// </summary>
        public DateTime Birthday
        {
            get
            {
                return _birthday;
            }
            set
            {
                if (_birthday.Year > 1900 && _birthday.Date <= DateTime.Today)
                {
                    _birthday=value;
                }
            else
                {
                    throw new ArgumentException("Некорректные данные");
                }
                
            }
        }

        /// <summary>
        /// Свйоство, предназначеннное для запсии адреса электронной почты экземпляра класса.
        /// </summary>
        public string Mail
        {
            get
            {
                return _mail;
            }
            set 
            {
                if (!string.IsNullOrEmpty(_mail) && _mail.Length <= 50)
                {
                    _mail = value;
                }
                else
                {
                    throw new ArgumentException("Некорректные данные");
                }
                
            }
        }


        /// <summary>
        /// Свйоство, предназначеннное для запсии Id-страницы "ВКонтакте" экземпляра класса.
        /// </summary>
        public long Id
        {
            get
            {
                return _id;
            }
            set
            {
                string ident = _id.ToString();

                if (string.IsNullOrEmpty(ident) && ident.Length > 15)
                {
                    throw new ArgumentException("Неверный номер");
                }

                else _id = value;
                
            }
        }
    }
}
