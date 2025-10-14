using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction = new Fraction();
        Fraction fraction1 = new Fraction(7);
        Fraction fraction2 = new Fraction(2, 2);

        Console.WriteLine(fraction.GetFractionAsString());
        Console.WriteLine(fraction.GetNumberValue());

        Console.WriteLine(fraction1.GetFractionAsString());
        Console.WriteLine(fraction1.GetNumberValue());

        Console.WriteLine(fraction2.GetFractionAsString());
        Console.WriteLine(fraction2.GetNumberValue());


    }
}