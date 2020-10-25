using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperationMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Равносторонний ли треугольник (введите 'yes', если да, введите 'no', если нет): ");
            string type = Console.ReadLine();
            double SqrEqTr=0;
            double SqrTr = 0;           
            if (type=="yes")
            {
                Console.Write("Введите длину стороны равностороннего треугольника: ");
                double storona = double.Parse(Console.ReadLine());
                SqrEqTr = Operation.TrSqr(storona, SqrEqTr);
                Console.WriteLine("Площадь равностороннего треугольника = " + $"{SqrEqTr:.##}");
            }
            else if (type=="no")
            {
                Console.Write("Введите длину стороны a: ");
                double sta = double.Parse(Console.ReadLine());
                Console.Write("Введите длину стороны b: ");
                double stb = double.Parse(Console.ReadLine());
                Console.Write("Введите длину стороны c: ");
                double stc = double.Parse(Console.ReadLine());
                SqrTr = Operation.TrSqr(sta, stb, stc, SqrTr);
                if (SqrTr == 0)
                {
                    Console.WriteLine(" ");
                }
                else
                {
                    Console.WriteLine("Площадь треугольника равна = " + $"{SqrTr:.##}");
                }
                
            }
            
            Console.ReadLine();
        }
    }
}
