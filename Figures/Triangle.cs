namespace Figures;

public class Triangle : IFigure
{
    public readonly PositiveDouble A;
    public readonly PositiveDouble B;
    public readonly PositiveDouble C;

    private const double TOLERANCE = 0.0001; //для сравнения чисел с плавающей запятой

    public Triangle(double a, double b, double c)
    {
        A = (PositiveDouble)a;
        B = (PositiveDouble)b;
        C = (PositiveDouble)c;

        #region Проверка нужная, но она мне не нравится

        if (a > b && a > c)
        {
            if (b + c < a)
            {
                throw new ArgumentException("Sum of cathets less then hypotenuse");
            }
        }

        if (b > a && b > c)
        {
            if (a + c < b)
            {
                throw new ArgumentException("Sum of cathets less then hypotenuse");
            }
        }

        if (c > b && c > a)
        {
            if (a + b < c)
            {
                throw new ArgumentException("Sum of cathets less then hypotenuse");
            }
        }

        #endregion
    }

    public double GetSquare()
    {
        var halfPerimeter = (A + B + C) / 2;
        return double.Sqrt(halfPerimeter * (halfPerimeter - A) * (halfPerimeter - B) * (halfPerimeter - C));
    }

    public bool IsRight()
    {
        if (A == 0 || B == 0 || C == 0) return false;

        return Math.Abs(C * C - (A * A + B * B)) < TOLERANCE ||
               Math.Abs(A * A - (B * B + C * C)) < TOLERANCE ||
               Math.Abs(B * B - (A * A + C * C)) < TOLERANCE;
    }
}