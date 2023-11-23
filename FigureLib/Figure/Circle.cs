using FigureLib.Interface;

namespace FigureLib.Figure;

public class Circle : ISquareCalc
{
    private double _radius { get; set; }
    public Circle(int radius)
    {
        _radius = radius;
    }
    public double CalcSquare()
    {
         return Math.PI * _radius * _radius;
    }
}