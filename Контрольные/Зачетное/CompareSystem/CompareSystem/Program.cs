using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Administator Admin = new Administator("-", 1, "Шуманов Дмитрий Васильевич", "Администратор", true);
            Console.WriteLine(Admin.EnterTheRequirements());
            Engineer en1 = new Engineer("ЦНИИ КМ Прометей", "Научно-производственный комплекс 3", 01132, "Иванов Иван Иванович", "Старший научный сотрудник", true);
            Engineer en2 = new Engineer("ОМЗ Спецсталь", "Испытательная лаборатория", 0142, "Федоров Петр Васильевич", "Инженер 3 категории", false);
           
            Console.WriteLine(en1.EnterTheResults1());
            Inspector inspect1 = new Inspector("Российский Морской Регистр Судохоства", 0953, "Петров Алексей Витальевич", "Старший инспектор", 25, true);
            Console.WriteLine(inspect1.DontApprove());
            Console.WriteLine(inspect1.Comment());
            Console.WriteLine(en2.Comment());
            Console.WriteLine(en2.EnterTheResults2());
            Console.WriteLine(inspect1.Approve());
            Console.WriteLine("=====================================================================");
            Console.WriteLine("Требования:");
           
            Admin.CollectionOfRequirements();
            Console.WriteLine("=====================================================================");
            Console.WriteLine("Пользователи:");
            Console.WriteLine(en1.Show());
            Console.WriteLine(en2.Show());
            Console.WriteLine(Admin.Show());
            Console.WriteLine(inspect1.Show());

            Console.ReadLine();
        }
    }
}
