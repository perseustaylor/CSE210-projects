using System;
using System.Collections.Generic;
using System.Threading;

class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you overcame a significant challenge.",
        "Recall a moment when you helped someone in need.",
        "Reflect on a personal achievement that you are proud of.",
        "Consider a time when you learned something new about yourself.",
        "Think about a situation where you showed kindness to others."
    };

    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "What did you learn about yourself from this experience?",
        "How did this experience change your perspective?",
        "What strengths did you demonstrate during this experience?",
        "How can you apply what you learned from this experience in the future?"
    };

    public ReflectionActivity() : base("Reflection Activity",
        "This activity will help you reflect on times in your life when you have shown strength and resilience. Think about these moments to gain a deeper understanding of yourself.")
    {
    }

    public void StartActivity()
    {
        WelcomeMessage();
        GetTimeFromUser();
        Console.WriteLine("Get ready to begin...");
        Spinner(3);
        PerformReflection();
    }

    public void PerformReflection()
    {
        Random rand = new Random();

        string prompt = _prompts[rand.Next(_prompts.Count)];
        Console.WriteLine();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine($"--- {prompt} ---");
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press Enter to continue.");
        Console.ReadLine();

        int duration = GetDuration();
        DateTime endTime = DateTime.Now.AddSeconds(duration);

        
        while (DateTime.Now < endTime)
        {
            string question = _questions[rand.Next(_questions.Count)];
            Console.WriteLine();
            Console.WriteLine(question);
            Spinner(5); 
        }

        EndMessage();
    }
}

