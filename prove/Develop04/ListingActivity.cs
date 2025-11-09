using System;
using System.Collections.Generic;
using System.Threading;

class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "List as many things as you can that you are grateful for.",
        "List the people who have positively influenced your life.",
        "List your personal strengths and qualities.",
        "List the achievements you are most proud of.",
        "List the activities that bring you joy and fulfillment."
    };
    public ListingActivity() : base("Listing Activity",
        "This activity will help you reflect on the good things in your life.")
    {
    }

    public void StartActivity()
    {
        WelcomeMessage();
        GetTimeFromUser();
        Console.WriteLine("Get ready to begin...");
        Spinner(3);
        PerformListing();
    }

    public void PerformListing()
    {
        Random rand = new Random();
        string prompt = _prompts[rand.Next(_prompts.Count)];
        Console.WriteLine();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine($"--- {prompt} ---");
        Console.WriteLine();
        Console.WriteLine("You may begin listing items. Press Enter after each item.");
        Console.WriteLine("When you are finished, type 'done' and press Enter.");
        Console.WriteLine();

        int duration = GetDuration();
        DateTime endTime = DateTime.Now.AddSeconds(duration);
        int itemCount = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string input = Console.ReadLine();
            if (input.ToLower() == "done")
            {
                break;
            }
            itemCount++;
        }

        Console.WriteLine();
        Console.WriteLine($"You listed {itemCount} items. Well done!");
        EndMessage();
    }
}