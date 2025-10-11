using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        int UserInput = -1;
        while (UserInput != 5)
        {
            Console.WriteLine("Please input the number to do one of the following");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.WriteLine();

            String Usernumber = Console.ReadLine();
            UserInput = int.Parse(Usernumber);

            if (UserInput == 1)
            {   
                Console.WriteLine("How are you feeling today?");
                string mood = Console.ReadLine();
                String prompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine(prompt);
                Console.Write(">>>");
                String response = Console.ReadLine();

                Entry entry = new Entry();
                entry._date = DateTime.Now.ToShortDateString();
                entry._prompt = prompt;
                entry._response = response;
                entry._mood = mood;
                journal.AddEntry(entry);

            }
            else if (UserInput == 2)
            {
                journal.DisplayEntries();
            }
            else if (UserInput == 3)
            {
                Console.Write("What is the filename: ");
                string filename = Console.ReadLine();
                journal.ReadFromFile(filename);
                Console.WriteLine($"Journal succesfully loaded from {filename}");

            }
            else if (UserInput == 4)
            {
                Console.Write("What is the filename: ");
                string filename = Console.ReadLine();
                journal.WriteToFile(filename);
                Console.WriteLine($"Journal saved under name {filename}");
            }
            else if (UserInput == 5)
            {
                Console.WriteLine("See you later Bro");
            }
            else
            {
                Console.WriteLine("Make sure your choice is valid");
            }
        }
    }
}