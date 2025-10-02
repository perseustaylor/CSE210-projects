using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._companyName = "Tesla Energy";
        job1._title = "Senior Mechanic";
        job1._startDate = 2002;
        job1._endDate = 2016;

        Job job2 = new Job();
        job2._companyName = "Ubisoft";
        job2._title = "Software engineer";
        job2._startDate = 2016;
        job2._endDate = 2024;

        // job1.displayJob();
        // Console.WriteLine("");
        // job2.displayJob();
        // Console.WriteLine("");

        Resume userResume = new Resume();
        userResume._userName = "Perseus Taylor";
        userResume._jobs.Add(job1);
        userResume._jobs.Add(job2);

        userResume.Display();
    }
}