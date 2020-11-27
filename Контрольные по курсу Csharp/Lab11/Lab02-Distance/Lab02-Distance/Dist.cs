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
        float inch { get; set; }
        public Distance() { }
        public Distance(int Foot,float Inch)
        {
            foot = Foot;
            inch = Inch;
            this.Normalize();
        }
        public static Distance operator + (Distance d1, Distance d2)
        {
            
            int newFoot = d1.foot + d2.foot;
            float newInch = d1.inch + d2.inch;
            return new Distance(newFoot, newInch);
        }
        public static Distance operator - (Distance d1, Distance d2)
        {
            int newFoot = Math.Abs( d1.foot - d2.foot);
            float newInch = Math.Abs(d1.inch - d2.inch);
            return new Distance(newFoot, newInch);
        }
        public override string ToString()
        {
            return String.Format(foot + "'" + "-" + $"{inch:#####}"+"''");
        }    
       
        private void Normalize()
        {                  
            foot += (int)inch / 12;
            inch %= 12;
        }
        private float TotalInches()
        {
            return foot * 12 + inch;
        }
        public static bool operator >(Distance d1, Distance d2)
        {
            return (d1.TotalInches())>(d2.TotalInches());
        }

        public static bool operator <(Distance d1, Distance d2)
        {
            return !((d1 > d2) || (d1 == d2));
        }

    }
    class Dist
    {
        static void Main(string[] args)
        {
            int Foot;
            float Inch;
           
            Console.Write("d1.foot: ");
            Foot= int.Parse(Console.ReadLine());
            Console.Write("d1.inch: ");
            Inch = float.Parse(Console.ReadLine());
            Distance d1 = new Distance(Foot, Inch);           
            Console.Write("d2.foot: ");
            Foot = int.Parse(Console.ReadLine());
            Console.Write("d2.inch: ");
            Inch = float.Parse(Console.ReadLine());
            Distance d2 = new Distance(Foot, Inch);
            Distance d3 = new Distance();
            d3 = d1 + d2;
            Console.WriteLine(d3.ToString());
            Distance d4 = new Distance();
            d4 = d1 - d2;
            Console.WriteLine(d4.ToString());
            if (d1>d2)
            {
                Console.WriteLine("{0} больше чем {1}", d1, d2);
            }
            else if (d2>d1)
            {
                Console.WriteLine("{0} меньше чем {1}", d1, d2);
            }
            Console.ReadLine();
        }
    }
}
