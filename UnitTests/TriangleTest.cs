using Figures;

namespace UnitTests;

[TestClass]
public class TriangleTest
{
    private readonly Random _random = new();

    [TestMethod]
    public void NormalInput()
    {
        var a = 3.5;
        var b = 6.5;
        var c = 5.7;
        var triangle = new Triangle(a, b, c);
        var square = triangle.GetSquare();
        var halfSum = (a + b + c) / 2;
        var expected = double.Sqrt(halfSum * (halfSum - a) * (halfSum - b) * (halfSum - c));
        Assert.AreEqual(expected, square);
    }

    [TestMethod]
    public void ZeroInput()
    {
        Assert.ThrowsException<ArgumentException>(() =>
        {
            var triangle = new Triangle(0, 5, 7);
        });
    }

    [TestMethod]
    public void RightTriangle()
    {
        var triangle = new Triangle(3, 5, 4);
        var isRight = triangle.IsRight();
        Assert.IsTrue(isRight);
    }

    [TestMethod]
    public void NotRightTriangle()
    {
        var triangle = new Triangle(3, 3, 3);
        var isRight = triangle.IsRight();
        Assert.IsFalse(isRight);
    }

    [TestMethod]
    public void IncorrectInput()
    {
        var a = -3.5;
        var b = -6.5;
        var c = -5.7;
        Assert.ThrowsException<ArgumentOutOfRangeException>(() =>
        {
            var triangle = new Triangle(a, b, c);
        });
    }
}