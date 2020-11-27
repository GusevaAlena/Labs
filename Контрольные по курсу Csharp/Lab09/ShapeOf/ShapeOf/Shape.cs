using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeOf
{
    abstract class Shape
    {
        protected double P;
        protected double S;
        protected string name = "NoName";
        protected string mes;
        public abstract double Perimetr();
        public abstract double Area();
        public string Show()
        {
            mes = "Параметры фигуры" + name;
            return mes;
        }
        public string Result(string res)
        {
            res = "Периметр, P=" + P + "\n" + "Площадь, S=" + $"{ S:.##}" + "\n";
            return res;
        }
    }
}
