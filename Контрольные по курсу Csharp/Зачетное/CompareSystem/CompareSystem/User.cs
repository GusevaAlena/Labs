using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareSystem
{
    class User
    {
        private string fullName { get; set; }
        private long id { get; set; }
        private string organization { get; set; }
        private bool permition { get; set; }
        private string position { get; set; }
        public User (string Organization, long ID, string FullName, string Position, bool Permition)
        {
            id= ID;
            fullName = FullName;
            organization=Organization;
            permition = Permition;
            position = Position;
        }
        public virtual string Show() 
        {
            string us = "\nОрганизация: " + organization + "\nТабельный номер: " + id + "\nФИО: " + fullName + "\nДолжность: " + position + "\nДоступ: " + permition;
            return us;
        }
 
    }
}
