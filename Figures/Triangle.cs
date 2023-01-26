namespace Figures;

public class Triangle : IFigure
{
    public readonly double A;
    public readonly double B;
    public readonly double C;

    private const double TOLERANCE = 0.0001; //для сравнения чисел с плавающей запятой

    public Triangle(double a, double b, double c)
    {
        A = a;
        B = b;
        C = c;
    }

    public double GetSquare()
    {
        var halfPerimeter = (A + B + C) / 2;
        return double.Sqrt(halfPerimeter * (halfPerimeter - A) * (halfPerimeter - B) * (halfPerimeter - C));
    }

    public bool IsRight()
    {
        return Math.Abs(C * C - (A * A + B * B)) < TOLERANCE ||
               Math.Abs(A * A - (B * B + C * C)) < TOLERANCE ||
               Math.Abs(B * B - (A * A + C * C)) < TOLERANCE;
    }
}