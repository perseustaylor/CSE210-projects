using System;
class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity",
        "This activity will help you relax by guiding you through slow breathing. Clear your mind and focus on your breath.")
    {
    }

    public void StartActivity()
    {
        WelcomeMessage();
        GetTimeFromUser();
        Console.WriteLine("Get ready to begin...");
        Spinner(3);
        PerformBreathing();
    }
    public void PerformBreathing()
    {
        int duration = GetDuration();
        int time = 0;
        while (time < duration)
        {
            Console.WriteLine();
            Console.Write("Breathe in... ");
            ShowCountdown(5);
            Console.WriteLine();

            Console.Write("Breathe out... ");
            ShowCountdown(5);
            Console.WriteLine();
            
            time += 10;
        }
        EndMessage();
        Spinner(3);
    }
}