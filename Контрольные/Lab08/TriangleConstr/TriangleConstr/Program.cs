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
        public Triangle (double A, double B, double C)
        {
            a = A;
            b = B;
            c = C;
        }
        public Triangle (double A)
        {
            a = A;
        }
        public double Perimetr(double a, double b, double c)
        {
            double P = a + b + c;
            return P;
        }
        public double Perimetr(double a)
        {
            double P = a * 3;
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
        public double Area(double a)
        {
            double P = Perimetr(a);
            double p = P / 2;
            double S = Math.Sqrt(p * Math.Pow((p - a), 3));
            return S;
        }
        public void Write(double a, double b, double c)
        {
            Console.Write("a={0} ", a);
            Console.Write("b={0} ", b);
            Console.WriteLine("c={0} ", c);
        }
        public void Write(double a)
        {
            Console.WriteLine("a={0} ", a);
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
            double A=0, B=0, C=0, P, S;
            Console.Write("Равносторонний ли треугольник (введите 'yes', если да, введите 'no', если нет): ");
            string type = Console.ReadLine();
            if (type == "yes")
            {
                Triangle Tr1 = new Triangle(A);
                Console.Write("Введите значение стороны: ");
                A = double.Parse(Console.ReadLine());
                Tr1.Write(A);
                P = Tr1.Perimetr(A);
                S = Tr1.Area(A);
            }
            else
            {
                Triangle Tr2 = new Triangle(A, B, C);
                Console.Write("Введите значение стороны а: ");
                A = double.Parse(Console.ReadLine());
                Console.Write("Введите значение стороны b: ");
                B = double.Parse(Console.ReadLine());
                Console.Write("Введите значение стороны c: ");
                C = double.Parse(Console.ReadLine());
                Tr2.Write(A,B,C);
                P = Tr2.Perimetr(A, B, C);
                S = Tr2.Area(A, B, C);
            }                                
            if (S == 0)
            {
                Console.WriteLine("Треугольника со сторонами {0}, {1}, {2} не существует", A,B,C);
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

