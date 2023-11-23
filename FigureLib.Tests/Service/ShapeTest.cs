using FigureLib.Figure;

namespace FigureLib.Tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]       
    [TestCase(5)]
    [TestCase(32)]
    [TestCase(11)]
    [TestCase(37)]
    public void GetCircleArea_Success(int radius)
    {
        var shape = new Shape(new Circle(radius));
        var response = shape.GetShapeSquare();
        var expectedArea = Math.PI * Math.Pow(radius, 2);
        Assert.That(Math.Round(response, 6), Is.EqualTo(Math.Round(expectedArea, 6)));
    }
   
    [Test]       
    [TestCase(5, 5, 5)]
    [TestCase(5, 4, 5)]
    [TestCase(5, 2, 5)]
    [TestCase(5, 1, 5)]
    [TestCase(5.765, 5.353, 5.1)]
    [TestCase(56773, 5467, 654.3553)]
    [TestCase(1234, 234.967890547, 9.982934892)]
    public void GetTriangleArea_Success(double a, double b, double c)
    {
        var shape = new Shape(new Triangle(a,b,c));
        var response = shape.GetShapeSquare();
        var p = (a + b + c) / 2;
        var expectedArea = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        Assert.That(Math.Round(response, 6), Is.EqualTo(Math.Round(expectedArea, 6)));
    }
}