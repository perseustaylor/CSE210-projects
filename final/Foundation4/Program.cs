using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();
        {
            Running run1 = new Running("2024-06-01", 30, 3);
            activities.Add(run1);

            Cycling cycle1 = new Cycling("2024-06-02", 45, 15);
            activities.Add(cycle1);

            Swimming swim1 = new Swimming("2024-06-03", 60, 40);
            activities.Add(swim1);

            foreach (Activity activity in activities)
            {
                Console.WriteLine(activity.GetSummary());
                Console.WriteLine();
            }
        }
    }
}