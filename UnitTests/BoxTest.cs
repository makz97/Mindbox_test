using Figures;

namespace UnitTests;

[TestClass]
public class BoxTest
{
    private readonly Random _random = new();

    [TestMethod]
    public void NormalInput()
    {
        var a = 5.6;
        var b = 4.2;
        IFigure box = new Box(a, b);
        var square = box.GetSquare();
        var expected = a * b;
        Assert.AreEqual(expected, square);
    }

    [TestMethod]
    public void ZeroInput()
    {
        IFigure box = new Box(0, 5);
        var square = box.GetSquare();
        var expected = 0;
        Assert.AreEqual(expected, square);
    }

    [TestMethod]
    public void IncorrectInput()
    {
        var a = -5.2;
        var b = 4.8;
        Assert.ThrowsException<ArgumentOutOfRangeException>(() =>
            {
                IFigure box = new Box(a, b);
            }
        );
    }
}