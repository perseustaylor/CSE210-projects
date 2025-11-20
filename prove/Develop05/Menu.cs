using System;
using System.Collections.Generic;
using System.IO;

class Menu
{
    private List<Goal> _goals = new List<Goal>();
    private int _totalPoints = 0;

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public void CreateGoal()
    {
        Console.WriteLine("The types of goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Which type of goal would you like to create today? ");
        string choice = Console.ReadLine();
        if (choice != "1" && choice != "2" && choice != "3")
        {
            Console.WriteLine("Invalid choice.");
            return;
        }

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();

        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        Goal goal = null;

        if (choice == "1")
        {
            goal = new SimpleGoal(name, description, points);
        }
        else if (choice == "2")
        {
            goal = new EternalGoal(name, description, points);
        }
        else if (choice == "3")
        {
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int target = int.Parse(Console.ReadLine());

            Console.Write("What is the bonus for accomplishing it that many times? ");
            int bonus = int.Parse(Console.ReadLine());

            goal = new ChecklistGoal(name, description, points, target, bonus);
        }
        else
        {
            Console.WriteLine("Invalid choice.");
            return;
        }

        _goals.Add(goal);
        Console.WriteLine("Goal created successfully.");
    }

    public void DisplayGoals()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals available.");
            return;
        }

        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.GetEvent());
        }
    }

    public void Printscore()
    {
        Console.WriteLine($"Total Points: {_totalPoints}");
        Console.WriteLine($"Level: {GetLevel()}");
    }

    public void RecordEvent()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals available.");
            return;
        }

        Console.WriteLine("Enter the number of the goal you accomplished:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetName()}");
        }

        Console.Write("Enter goal number: ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int goalNumber) && goalNumber >= 1 && goalNumber <= _goals.Count)
        {
            Goal selectedGoal = _goals[goalNumber - 1];
            int points = selectedGoal.RecordEvent();
            _totalPoints += points;
            Console.WriteLine($"You earned {points} points!");
        }
        else
        {
            Console.WriteLine("Invalid goal number.");
        }
    }

    public void Save(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine(_totalPoints);

            foreach (Goal goal in _goals)
            {
                writer.WriteLine(goal.GetstringRepresentation());
            }
        }

        Console.WriteLine("Goals saved successfully.");
    }

    public void Load(string filename)
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }

        string[] lines = File.ReadAllLines(filename);
        _goals.Clear();
        _totalPoints = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string line = lines[i];

            string[] parts = line.Split(':', 2);
            string type = parts[0];
            string[] data = parts[1].Split('|');

            Goal goal = null;

            if (type == "SimpleGoal")
            {
                goal = new SimpleGoal(data[0], data[1], int.Parse(data[2]));

                if (bool.Parse(data[3])) goal.CompleteGoal();
            }
            else if (type == "EternalGoal")
            {
                goal = new EternalGoal(data[0], data[1], int.Parse(data[2]));
            }
            else if (type == "ChecklistGoal")
            {
                ChecklistGoal Checklist = new ChecklistGoal(
                    data[0], 
                    data[1], 
                    int.Parse(data[2]),
                    int.Parse(data[5]), 
                    int.Parse(data[6])
                );

                int current = int.Parse(data[4]);
                bool complete = bool.Parse(data[3]);

                Checklist.SetCurrentNumber(current);
                
                if (complete) 
                Checklist.CompleteGoal();
                goal = Checklist;
            }

            _goals.Add(goal);
        }

        Console.WriteLine("Goals loaded successfully.");
    }

    public string GetLevel()
    {
        if (_totalPoints < 200)
        {
            return "Beginner";
        }
        else if (_totalPoints < 600)
        {
            return "Intermediate";
        }
        else if (_totalPoints < 1000)
        {
            return "Advanced";
        }
        else
        {
            return "Expert";
        }
    }
}


