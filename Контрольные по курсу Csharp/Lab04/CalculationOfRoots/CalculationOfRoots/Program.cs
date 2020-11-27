using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationOfRoots
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = 0;
            double x2 = 0;
            int result = 0;
            Console.Write("Введите коэффициент а: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Введите коэффициент b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Введите коэффициент c: ");
            double c = double.Parse(Console.ReadLine());
            result = CalcRoots.SquareRoots(a, b, c, ref x1, ref x2);
            if (result==1)
            {
                Console.WriteLine("Корни уравнения с коэффициентами a = {0}, b = {1}, c = {2} равны: x1 = {3}, x2 = {4}", a, b, c, $"{x1:.##}", $"{x2:.##}");
            }
            else if (result == 0)
            {
                Console.WriteLine("Корень уравнения с коэффициентами a = {0}, b = {1}, c = {2} один: x1 = x2 = {3}", a, b, c, $"{x1:.##}");
            }
            else if (result == -1)
            {
                Console.WriteLine("Корней уравнения с коэффициентами a = {0}, b = {1}, c = {2} нет", a, b, c);
            }
            Console.ReadLine();
        }
    }
}
