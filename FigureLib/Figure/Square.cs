using FigureLib.Interface;

namespace FigureLib.Figure;

public class Square : ISquareCalc
{
    private double _a { get; set; }

    public Square(double a)
    {
        _a = a;
    }
    public double CalcSquare()
    {
        return _a * _a;
    }
}