using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What was your grade percentage? ");
        string userNumberString = Console.ReadLine();
        int userNumberValue = int.Parse(userNumberString);

        if (userNumberValue >= 90)
        {
            Console.WriteLine("Your grade is A");
        }
        else if (userNumberValue >= 80)
        {
            Console.WriteLine("Your grade is B");
        }
        else if (userNumberValue >= 70)
        {
            Console.WriteLine("Your grade is C");
        }
        else if (userNumberValue >= 60)
        {
            Console.WriteLine("Your grade is D");
        }
        else
        {
            Console.WriteLine("Your grade is F");
        }
    }
}