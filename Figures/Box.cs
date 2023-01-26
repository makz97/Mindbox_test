namespace Figures;

public class Box : IFigure
{
    public readonly double A;
    public readonly double B;

    public Box(double a, double b)
    {
        A = a;
        B = b;
    }

    public double GetSquare()
    {
        return A * B;
    }
}