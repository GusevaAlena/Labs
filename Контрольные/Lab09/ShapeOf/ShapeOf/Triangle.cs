using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeOf
{
    class Triangle:Shape, IRotation
    {
        private double a;
        private double b;
        private double c;       
        public Triangle(double a, double b, double c)
        {
            if (Existance(a,b,c) == true)
            {
                this.a = a;
                this.b = b;
                this.c = c;
            }
        }
        public Triangle(double a)
        {
            this.a = a;
        }
        public override double Perimetr()
        {
            P = a + b + c;
            return P;
        }
        public double Perimetr(double a)
        {
            P = 3 * a;
            return P;
        }
        public override double Area()
        {
            S = Math.Sqrt((P / 2) * (P / 2 - a) * (P / 2 - b) * (P / 2 - c));
            return S;
        }
        public double Area(double a)
        {
            S = Math.Sqrt((P / 2) * Math.Pow((P / 2 - a), 3));
            return S;
        }
        new public void Show()
        {
            name = " треугольник";           
            base.Show();
            Console.WriteLine("{0} \n a= {1}", mes, a);
        }
        public string Show(string par)
        {          
            name = " треугольник";
            base.Show();
            if (Existance(a, b, c) == true)
                par = mes + "\na = " + a + "; " + "b = " + b + "; " + "c = " + c;
            else
                par = "Треугольник с введенными значениями сторон не существует";
            return par;
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
        public double x { get; set; } 
        public double y { get; set; } 
        public double alpha { get; set; } 
        public double x1 { get; set; } 
        public double y1 { get; set; } 
        public double x2 { get; set; } 
        public double y2 { get; set; } 
        public string Rotate ()
        {
            string rotationMessage;
            if (Existance(a, b, c) == true)
            {
                x2 = x + (x1 - x) * Math.Cos(alpha) - (y1 - y) * Math.Sin(alpha);
                y2 = y + (y1 - y) * Math.Cos(alpha) + (x1 - x) * Math.Sin(alpha);
                rotationMessage = "Новые координаты вершины, за которую было произведено вращение фигуры равны: x2 = " + $"{x2:.##}" + " " + "y2 = " + $"{y2:.##}";
                return rotationMessage;
            }
            else
            {
                rotationMessage = "Невозможно вращать несуществующий треугольник";
                return rotationMessage;
            }           
        }        
    }
}

