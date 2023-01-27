namespace Figures;

public struct PositiveDouble
{
    private double _value;

    public PositiveDouble(double value)
    {
        if (value < 0)
        {
            throw new ArgumentOutOfRangeException("Value must be greater than 0");
        }

        _value = value;
    }

    public static implicit operator double(PositiveDouble positiveDouble)
    {
        return positiveDouble._value;
    }

    public static explicit operator PositiveDouble(double d)
    {
        return new PositiveDouble(d);
    }
}