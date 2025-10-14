public class Fraction
{
    private int _top;
    private int _bottom;

    // constructors
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }
    public Fraction(int number)
    {
        _top = number;
        _bottom = 1;
    }

    public Fraction(int topNumber, int bottomNumber)
    {
        _top = topNumber;
        _bottom = bottomNumber;
    }
    public string GetFractionAsString()
    {
        return $"{_top}/{_bottom}";
    }

    public double GetNumberValue()
    {
        return _top / _bottom;
    }
     
}