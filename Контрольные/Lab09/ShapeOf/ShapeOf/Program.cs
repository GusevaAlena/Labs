using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeOf
{
    class Program
    {
        static void Main(string[] args)
        {
            string triangleType;                    
            double S = 0;
            double P = 0;
            string res = "";
            Console.WriteLine("Треугольник равносторонний? (Да - 'yes', Нет -'no')");
            triangleType = Console.ReadLine();
            if (triangleType == "yes")
            {               
                Console.Write("Введите значение стороны треугольника, a = ");
               double a = double.Parse(Console.ReadLine());
                Triangle Tr1 = new Triangle(a);
                Tr1.Show();
                P = Tr1.Perimetr(a);
                S = Tr1.Area(a);              
                Console.WriteLine(Tr1.Result(res));
                Console.WriteLine("Вращение: ");
                Tr1.x = 0;
                Tr1.y = 0;
                Tr1.alpha = 60;
                Tr1.x1 = 1;
                Tr1.y1 = 1;               
                Console.WriteLine(Tr1.Rotate());

            }
            else if (triangleType == "no")
            {
                string par = "";
                Console.Write("a= ");
                double a = double.Parse(Console.ReadLine());
                Console.Write("b= ");
                double b = double.Parse(Console.ReadLine());
                Console.Write("c= ");
                double c = double.Parse(Console.ReadLine());
                Triangle Tr2 = new Triangle(a, b, c);            
                Console.WriteLine(Tr2.Show(par));
                P = Tr2.Perimetr();
                S = Tr2.Area();             
                Console.WriteLine(Tr2.Result(res));
                Console.WriteLine("Вращение: ");
                Tr2.x = 3;
                Tr2.y = -3;
                Tr2.alpha = 45;
                Tr2.x1 = 5;
                Tr2.y1 = 6;
                Console.WriteLine(Tr2.Rotate());
            }
            Console.Write("\nВведите значение радиуса окружности, R= ");
            double R = double.Parse(Console.ReadLine());
            Circle c1 = new Circle(R);
            P = c1.Perimetr();
            S = c1.Area();
            c1.Show();
            Console.WriteLine(c1.Result(res));

            Console.Write("Введите значение стороны квадрата, st= ");
            double st = double.Parse(Console.ReadLine());
            Square k1 = new Square(st);
            P = k1.Perimetr();
            S = k1.Area();
            k1.Show();
            Console.WriteLine(k1.Result(res));
            Console.WriteLine("Вращение: ");
            k1.x =0;
            k1.y = 0;
            k1.alpha = 180;
            k1.x1 = -4;
            k1.y1 = -1;
            Console.WriteLine(k1.Rotate());
            Console.ReadLine();           
        }
    }
}
