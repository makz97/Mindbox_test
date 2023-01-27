using Figures;

namespace UnitTests;

[TestClass]
public class CircleTest
{
    private readonly Random _random = new();
    private const double TOLERANCE = 0.00001;

    [TestMethod]
    public void NormalInput()
    {
        var radius = 14.2;
        var circle = new Circle(radius);
        var square = circle.GetSquare();
        var expected = radius * radius * Double.Pi;
        var isEqual = Math.Abs(square - expected) < TOLERANCE;
        Assert.IsTrue(isEqual);
    }


    [TestMethod]
    public void ZeroInput()
    {
        var circle = new Circle(0);
        var square = circle.GetSquare();
        var expected = 0;
        Assert.AreEqual(expected, square);
    }

    [TestMethod]
    public void IncorrectInput()
    {
        var radius = -12.7;
        Assert.ThrowsException<ArgumentOutOfRangeException>(() =>
        {
            var circle = new Circle(radius);
        });
    }
}