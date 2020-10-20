using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class TrSq
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение периметра равностороннего треугольника");
            double P = double.Parse(Console.ReadLine());
            double a = P / 3;
            double p = P / 2;
            double S = Math.Sqrt(p * Math.Pow((p - a), 3));
            string st = String.Format("{0:f2}", a);
            string pl = String.Format("{0:f2}", S);
            Console.WriteLine("Сторона\t Площадь\n {0}\t {1}", st ,pl);
            Console.ReadLine();
        }
    }
}