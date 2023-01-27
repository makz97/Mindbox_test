namespace Figures;

public class Circle : IFigure
{
    public readonly PositiveDouble radius;

    public Circle(double radius)
    {
        this.radius = (PositiveDouble)radius;
    }

    public double GetSquare()
    {
        return double.Pi * radius * radius;
    }
}