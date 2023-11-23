using FigureLib.Interface;

namespace FigureLib;

public class Shape
{
    private ISquareCalc SquareCalc { get; set; }

    public Shape(ISquareCalc squareCalc)
    {
        SquareCalc = squareCalc;
    }

    public double GetShapeSquare()
    {
        var response = SquareCalc.CalcSquare();
        return response;
    }
}