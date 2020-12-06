using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMO.Lab03.Ex4
{
    class User
    {
        private string firstName{get;set;}
        private string lastName { get; set; }
        private DateTime birthday { get; set; }
        private string telnumber { get; set; }
        private string email { get; set; }
        public User() { }
        public User (string FirstName, string LastName, DateTime Birthday, string Telnumber, string Email)
        {
            firstName=FirstName;
            lastName = LastName;
            birthday = Birthday;
            telnumber = Telnumber;
            email = Email;
        }
        public override string ToString()
        {
            return "Имя: " + firstName + "\nФамилия: " + lastName + "\nДата рождения: " + birthday + "\nТелефон: " + telnumber + "\nАдрес электронной почты: " + email;
        }
    }
}
