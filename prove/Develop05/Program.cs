using System;

class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();
        bool running = true;

        while (running)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Display Score");
            Console.WriteLine("7. Quit");
            Console.Write("Select a choice from the menu: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    menu.CreateGoal();
                    break;

                case "2":
                    menu.DisplayGoals();
                    break;

                case "3":
                    Console.Write("Enter filename to save goals: ");
                    string saveFilename = Console.ReadLine();
                    menu.Save(saveFilename);
                    break;

                case "4":
                    Console.Write("Enter filename to load goals: ");
                    string loadFilename = Console.ReadLine();
                    menu.Load(loadFilename);
                    break;

                case "5":
                    menu.RecordEvent();
                    break;

                case "6":
                    menu.Printscore();
                    break;

                case "7":
                    running = false;
                    Console.WriteLine("Exiting the program. Goodbye!");
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

            Console.WriteLine();
        }
    }
}
