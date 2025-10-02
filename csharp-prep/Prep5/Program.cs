using System;
using System.Reflection.Metadata.Ecma335;

class Program
{
    static void Main(string[] args)
    {
        WelcomeMessage();
        string Name = UserName();
        int Number = UserNumber();
        int SquareNumber = NumberSquared(Number);
        int BirthYear = UserYear();
        int CurrentAge = ThisYear(BirthYear);

        display(Name, CurrentAge, SquareNumber);

    }
    static void WelcomeMessage()
    {
        Console.WriteLine("Welcome to the program! ");
    }


    static string UserName()
    {
        Console.Write("What is your name? ");
        string Name = Console.ReadLine();

        return Name;
    }
    static int UserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int Number = int.Parse(Console.ReadLine());
        return Number;
    }
    static int UserYear()
    {
        Console.Write("What year were you born: ");
        int Year = int.Parse(Console.ReadLine());
        return Year;

    }
    static int NumberSquared(int Number)
    {
        int Squared = Number * Number;
        return Squared;
    }
    static int ThisYear(int Year)
    {
        int CurrentYear = 2025;
        int CurrentAge = CurrentYear - Year;
        return CurrentAge;
    }

    static void display(string Name, int CurrentAge, int Squared)
    {
        Console.WriteLine($"{Name}, the square of your number is {Squared}");
        Console.WriteLine($"{Name}, you will turn {CurrentAge} this year. ");
    }
}