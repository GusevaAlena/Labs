using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeOf
{
    class Circle:Shape
    {
        private double R;     
        public const double pi = 3.14;
        public Circle(double R)
        {
           this.R = R;
        }
        public override double Perimetr()
        {
            P = 2 * 3.14 * R;
            return P;  
        }
        public override double Area()
        {
            S = pi * Math.Pow(R, 2);
            return S;
        }
        new public void Show()
        {
            name = " окружность";
            base.Show();
            Console.WriteLine("{0} \nR= {1}", mes, R);
        }
    }
}
