using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleClass
{
    class Triangle
    {
        private double a;
        private double b;
        private double c;       
        public void Set(double A, double B, double C)
        {
            a = A;
            b = B;
            c = C;
        }
        public double Perimetr(double a, double b, double c)
        {
            double P = a + b + c;
            return P;
        }
        public double Area(double a, double b, double c)
        {
            bool ok;
            double S = 0;
            ok = Triangle.Existance(a, b, c);
            if (ok == true)
            {
                double P = Perimetr(a, b, c);
                double p = P / 2;
                S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                return S;
            }
            else
            {
                S = 0;
                return S;
            }
        }
        public void Write()
        {
            Console.Write("a={0} ", a);
            Console.Write("b={0} ", b);
            Console.WriteLine("c={0} ", c);
        }
        private static bool Existance(double a, double b, double c)
        {
            bool Exist;
            if ((a + b) > c && (b + c) > a && (a + c) > b)
            {
                Exist = true;
            }
            else
            {
                Exist = false;
            }
            return Exist;
        }

                   
    }
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C, P, S;          
            Triangle Tr = new Triangle();           
            Console.Write("Введите значение стороны а: ");
            A = double.Parse(Console.ReadLine());
            Console.Write("Введите значение стороны b: ");
            B = double.Parse(Console.ReadLine());
            Console.Write("Введите значение стороны c: ");
            C = double.Parse(Console.ReadLine());
            Tr.Set(A, B, C);
            Tr.Write();
            P = Tr.Perimetr(A,B,C);
            S = Tr.Area(A, B, C);
            if (S == 0)
            {
                Console.WriteLine("Треугольник не существует");
            }
            else
            {
                Console.WriteLine("Периметр треугольника равен: {0}", P);
                Console.WriteLine("Площадь треугольника равна: " + $"{S:.##}");
            }
            Console.ReadLine();
        }
    }
}
