using System;

class Program
{
    static void Main(string[] args)
    {
        Scripture scripture = new Scripture(new Reference("Ether", 12, 9), "Wherefore, ye may also have hope, and be partakers of the gift, if ye will but have faith.");
        scripture.DisplayScripture();

        while (true)
        {
            Console.WriteLine("Press Enter to hide words or type 'quit' to exit");
            string userInput = Console.ReadLine();
            if (userInput.ToLower() == "quit")
            {
                break;
            }

            scripture.Hidewords(3);
            Console.Clear();
            scripture.DisplayScripture();
            

            if (scripture.AllWordsHidden())
            {
                Console.WriteLine("All words are hidden. Exiting program.");
                break;
            }
        }
    }
}