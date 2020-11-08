using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareSystem
{
    class Engineer:User, IComment
    {
        private string department;
        public Engineer (string Organization, string Department, long ID, string FullName,string Position, bool Permition):base(Organization, ID, FullName,Position, Permition)
        {
            department = Department; ;
        }
        public override string Show()
        {
            string eng = "\nОтдел: " + department + base.Show();
            return eng;
        }
        public string EnterTheResults1 ()
        {
            Tests test1 = new Tests("Сталь 20","Статическое растяжение", "Предел текучести", 20, 400);
            string engMes1 = "\nИнженер вводит результаты испытаний" + "\n"+ test1.ShowResults();            
            return engMes1;
        }
        public string EnterTheResults2()
        {          
            Tests test2 = new Tests("Сталь 20", "Статическое растяжение", "Предел текучести", 20, 300);
            string engMes2 = "\nИнженер вводит результаты испытаний" + "\n" + test2.ShowResults();
            return engMes2;
        }
        public string message { get; set; }
        public string Comment()
        {
            message = "\nРезультаты испытаний дополнительных образцов";
            return message;
        }
    }
}
