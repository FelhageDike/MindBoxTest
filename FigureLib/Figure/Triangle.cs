using FigureLib.Interface;

namespace FigureLib.Figure;

public class Triangle : ISquareCalc
{
    private double _a { get; set; }
    private double _b { get; set; }
    private double _c { get; set; }

    private bool isRight { get; set; }

    public Triangle(double a, double b, double c)
    {
        _a = a;
        _b = b;
        _c = c;
    }
    public double CalcSquare()
    {
        var semiPerimeter = (_a + _b + _c) / 2;
        var response = Math.Sqrt(semiPerimeter * (semiPerimeter - _a) * (semiPerimeter - _b) * (semiPerimeter - _c));
        return response;
    }
    public bool CheckIsRight()
    {
        if (((_a * _a + _b * _b) == (_c * _c)) || 
            ((_c * _c + _b * _b) == (_a * _a)) ||
            ((_a * _a + _c * _c) == (_b * _b))) 
            return isRight = true;
        return false;
    }
}