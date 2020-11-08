using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02_Distance
{
    class Distance
    {
        int foot { get; set; }
        double inch { get; set; }
        public Distance() { }
        public Distance(int Foot,double Inch)
        {
            foot = Foot;
            inch = Inch;
            this.Normalize();
        }
        public static Distance operator + (Distance d1, Distance d2)
        {
            
            int newFoot = d1.foot + d2.foot;
            double newInch = d1.inch + d2.inch;
            return new Distance(newFoot, newInch);
        }
        public static Distance operator - (Distance d1, Distance d2)
        {
            int newFoot = Math.Abs( d1.foot - d2.foot);
            double newInch = Math.Abs(d1.inch - d2.inch);
            return new Distance(newFoot, newInch);
        }
        public override string ToString()
        {
            return String.Format("{0}'-{1}''", foot, inch);
        }
        private void Normalize()
        {                  
            foot += (inch / 12);
            inch %= 12;
        }
    }
    class Dist
    {
        static void Main(string[] args)
        {
            int Foot = 0;
            int Inch = 0;
            Distance d1 = new Distance(Foot, Inch);
            Console.Write("d1.foot: ");
            Foot= int.Parse(Console.ReadLine());
            Console.Write("d1.inch: ");
            Inch = int.Parse(Console.ReadLine());
            Distance d2 = new Distance(Foot, Inch);
            Console.Write("d2.foot: ");
            Foot = int.Parse(Console.ReadLine());
            Console.Write("d2.inch: ");
            Inch = int.Parse(Console.ReadLine());
            Distance d3 = new Distance();
            d3 = d1 + d2;
            Console.WriteLine(d3.ToString());
            Distance d4 = new Distance();
            d4 = d1 - d2;
            Console.WriteLine(d4.ToString());
        }
    }
}
