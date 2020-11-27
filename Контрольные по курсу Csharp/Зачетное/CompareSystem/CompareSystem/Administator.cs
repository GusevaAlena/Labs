using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareSystem
{
    class Administator : User
    {
        public Administator(string Organization, long ID, string FullName, string Position, bool Permition) : base(Organization, ID, FullName, Position, Permition) { }
        public override string Show()
        {
            return base.Show();
        }
        public string EnterTheRequirements ()
        {           
            Requirements Steel20 = new Requirements("Сталь 20", "Статическое растяжение", "Предел текучести", 20, 300);
            string AdMes = "Администратор вводит требования\t" + "\n"+Steel20.ShowRequirements();
            return AdMes;
        }
        public void CollectionOfRequirements () 
        {
            Requirements St1 = new Requirements("Сталь 20", "Статическое растяжение", "Предел текучести", 20, 300);
            Requirements St2= new Requirements("F450W", "Статическое растяжение", "Предел текучести", 20, 450);
            Requirements St3 = new Requirements("Ст3сп5", "Статическое растяжение", "Предел текучести", 20, 245);
            Requirements St4 = new Requirements("08Х18Н10Т", "Статическое растяжение", "Предел текучести", 20, 195);
            List < Requirements > allrequirements = new List<Requirements> () { St1, St2, St3, St4 };
            foreach (Requirements AllReq in allrequirements)
            {
               Console.WriteLine(AllReq.ShowRequirements());
            }          
                     
        }

    }
}
