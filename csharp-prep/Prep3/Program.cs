using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.Write("What is the magic number? ");
        // int magicNumber = int.Parse(Console.ReadLine());
        // int guess = -1;
        // while (magicNumber != guess)
        // this is for the first part
        Random numberGenerator = new Random();
        int magicNumber = numberGenerator.Next(1, 101);
        int guess = -1;
        // {
        //     Console.Write("What is your guess? ");
        //     guess = int.Parse(Console.ReadLine());

        //     if (guess > magicNumber)
        //     {
        //         Console.WriteLine("Lower");
        //     }
        //     else if (guess < magicNumber)
        //     {
        //         Console.WriteLine("Higher");
        //     }
        //     else
        //     {
        //         Console.WriteLine("You guessed it");
        //     }

        // }
        while (guess != magicNumber)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (magicNumber > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it");
            }
        
        }

    }
}   
        



        