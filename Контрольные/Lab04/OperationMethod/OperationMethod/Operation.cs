using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OperationMethod
{
    class Operation
    {
        public static double TrSqr (double a, double b, double c, double S)
        {
            bool ok;
            ok = Operation.Existance (a, b, c);
            if (ok==true)
            {                
                double p = (a + b + c) / 2;
                S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                return S;
            }
           else
            {
                Console.WriteLine("Невозможно посчитать площадь");
                return S;
            }
            
        }
        private static bool Existance (double a, double b, double c)
        {          
           
            bool Exist;
            if ((a+b) > c && (b+c) > a && (a+c) > b) 
            {              
                Exist = true;
                Console.WriteLine("Треугольник существует");                                            
            }
            else
            {
                Exist = false;
                Console.WriteLine("Треугольника не существует");              
            }
            return Exist;
        }
        public static double TrSqr(double a,  double S)
        {                       
            double p = a * 3 / 2;
            S = Math.Sqrt(p * Math.Pow((p - a), 3));                         
            return S;
        }
    }
}
