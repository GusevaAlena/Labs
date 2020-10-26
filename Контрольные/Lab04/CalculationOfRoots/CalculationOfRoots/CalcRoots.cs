using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CalculationOfRoots
{
    class CalcRoots
    {
        public static int SquareRoots (double a, double b, double c, ref double x1, ref double x2)
        {           
            int n=0;
            double D = Math.Pow(b, 2) - 4 * a * c;
            if (D>0)
            {
                n = 1;
                x1 = (-b + Math.Sqrt(D)) / (2 * a);
                x2 = (-b - Math.Sqrt(D)) / (2 * a);
            }
            else if (D==0)
            {
                n = 0;
                x1 = (-b) / (2 * a);
            }
            else if (D<0)
            {
                n = -1;
            }
            return n;
        }
    }
}
