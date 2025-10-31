using System;
class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("Perseus Taylor", "Addition");
        Console.WriteLine(assignment.GetSummary());

        MathAssignment mathAssignment = new MathAssignment("Perseus Taylor", "Calculus", "2.3", "1-10 ");
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());

        WritingAssignment writingassignment = new WritingAssignment("Perseus Taylor", "English", "Shakespeare's Hamlet");
        Console.WriteLine(writingassignment.GetSummary());
        Console.WriteLine(writingassignment.GetWritingInformation());
    }
}