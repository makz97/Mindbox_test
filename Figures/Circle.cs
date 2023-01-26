namespace Figures;

public class Circle : IFigure
{
    public readonly double radius;

    public Circle(double radius)
    {
        this.radius = radius;
    }

    public double GetSquare()
    {
        return double.Pi * radius * radius;
    }
}