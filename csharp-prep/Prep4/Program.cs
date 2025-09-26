using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int userNumber = -96621;
        Console.WriteLine("Enter a list of numbers, type 0 when finished");

        while (userNumber != 0)
        {

            Console.Write("Enter number: ");
            userNumber = int.Parse(Console.ReadLine());
            if (userNumber != 0)
                numbers.Add(userNumber);
        }


        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is {sum}");

        int maxNumber = numbers[0];
        foreach (int number in numbers)
        {
            if (number > maxNumber)
                maxNumber = number;
        }
        Console.WriteLine($"The max number is {maxNumber}");

        numbers.Sort();
        foreach (int numero in numbers)
        {
            Console.WriteLine($"{numero}");
        }
    }
    

}