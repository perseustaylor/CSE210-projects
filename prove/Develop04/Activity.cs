using System;
using System.Collections.Generic;
using System.Threading;

class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    private List<string> _quotes = new List<string>
    {
        "You are stronger than you think.",
        "you can do hard things.",
        "Every day is a new beginning.",
        "be proud of your progress.",
        "God loves you.",
        "Believe in yourself.",
        "Stay strong.",
        "Keep moving forward.",

    };

    public void DisplayRandomQuote()
    {
        Random rand = new Random();
        Console.WriteLine("\nQuote of the Day:");
        Console.WriteLine($"{_quotes[rand.Next(_quotes.Count)]}");
        Console.WriteLine();
    }

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    protected string GetName()
    {
        return _name;
    }

    protected string GetDescription()
    {
        return _description;
    }

    protected int GetDuration()
    {
        return _duration;
    }

    protected void SetDuration(int duration)
    {
        _duration = duration;
    }

    public void WelcomeMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} activity.");
        Console.WriteLine(_description);
        Console.WriteLine();
    }

    public void EndMessage()
    {
        Console.WriteLine();
        Console.WriteLine($"You have completed the {_name} activity in {_duration} seconds.");
        Console.WriteLine("Great job!");
        Spinner(3);
        DisplayRandomQuote();
    }

    public void Spinner(int duration)
    {
        List<string> spinnerChars = new List<string> { "|", "/", "-", "\\" };
        DateTime endTime = DateTime.Now.AddSeconds(duration);
        int i = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write(spinnerChars[i]);
            Thread.Sleep(200);
            Console.Write("\b \b");  
            i = (i + 1) % spinnerChars.Count;
        }
    }

    public void GetTimeFromUser()
    {
        Console.Write("Enter the duration of the activity in seconds: ");
        int duration = int.Parse(Console.ReadLine());
        SetDuration(duration);
    }

    public void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}
    
        

        
        
    

