namespace Figures;

public class Box : IFigure
{
    public readonly PositiveDouble A;
    public readonly PositiveDouble B;

    public Box(double a, double b)
    {
        A = (PositiveDouble)a;
        B = (PositiveDouble)b;
    }

    public double GetSquare()
    {
        return A * B;
    }
}