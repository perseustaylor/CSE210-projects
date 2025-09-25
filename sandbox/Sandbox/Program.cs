using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        string randomWords = "Hello Sandbox World!";
        TextInfo textInfo = CultureInfo.CurrentUICulture.TextInfo;
        string capitalized = textInfo.ToTitleCase(randomWords)
        Console.WriteLine(capitalized);
    }
}