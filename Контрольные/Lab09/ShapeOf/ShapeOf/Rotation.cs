using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeOf
{
    interface IRotation
    {
        string Rotate();
        double x { get; set; } //центр фигуры
        double y { get; set; } //центр фигуры
        double alpha { get; set; } //угол, на который необходимо повернуть фигуру
        double x1 { get; set; } //начальная координата точки вершины, за которую происходит вращение фигуры
        double y1 { get; set; } //начальная координата точки вершины, за которую происходит вращение фигуры
        double x2 { get; set; } //конечная координата точки вершины, за которую происходит вращение фигуры
        double y2 { get; set; } //конечная координата точки вершины, за которую происходит вращение фигуры
    }
}
