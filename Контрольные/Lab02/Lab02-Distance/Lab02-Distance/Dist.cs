using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02_Distance
{
    public struct Distance
    {
        public int foot;
        public int inch;
    }
    class Dist
    {
        static void Main(string[] args)
        {
            Distance d1, d2, sum;
            Console.Write("d1.foot: ");
            d1.foot = int.Parse(Console.ReadLine());
            Console.Write("d1.inch: ");
            d1.inch = int.Parse(Console.ReadLine());
            Console.Write("d2.foot: ");
            d2.foot = int.Parse(Console.ReadLine());
            Console.Write("d2.inch: ");
            d2.inch = int.Parse(Console.ReadLine());
            sum.foot = (d1.foot + d2.foot)+((d1.inch + d2.inch)/12);
            sum.inch = (d1.inch + d2.inch)%12;
            Console.WriteLine("Distance = {0}'-{1}''", sum.foot, sum.inch);
        }
    }
}
