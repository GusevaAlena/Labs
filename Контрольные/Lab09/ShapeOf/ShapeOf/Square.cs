using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeOf
{
    class Square:Shape, Rotation
    {
        public double st;
        public Square(double st)
        {
            this.st = st;
        }
        public override double Perimetr()
        {
            P = 4 * st;
            return P;
        }
        public override double Area()
        {
            S = Math.Pow(st, 2);
            return S;
        }
        new public void Show()
        {
            name = " квадрат";
            base.Show();
            Console.WriteLine("{0} \nst= {1}", mes, st);
        }
        public double x { get; set; }
        public double y { get; set; }
        public double alpha { get; set; }
        public double x1 { get; set; }
        public double y1 { get; set; }
        public double x2 { get; set; }
        public double y2 { get; set; }
        public string Rotate()
        {
            x2 = x + (x1 - x) * Math.Cos(alpha) - (y1 - y) * Math.Sin(alpha);
            y2 = y + (y1 - y) * Math.Cos(alpha) + (x1 - x) * Math.Sin(alpha);
            string rotationMessage = "Новые координаты вершины, за которую было произведено вращение фигуры равны: x2 = " + $"{x2:.##}" + " " + "y2 = " + $"{y2:.##}";
            return rotationMessage;
        }
    }
}
