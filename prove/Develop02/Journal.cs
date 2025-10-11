using System;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    // add entry to journal
    public  void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    // save(Write) to file

    public void WriteToFile(string filename)
    {
       
        using (StreamWriter outputfile = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                outputfile.WriteLine($"{entry._date}#{entry._prompt}#{entry._response}");
            }
        }
    }
    // load from file
    public void ReadFromFile(string filename)
    {
        string[] lines = System.IO.File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            String[] parts = line.Split('#');
            string date = parts[0];
            string prompt = parts[1];
            string response = parts[2];

            Entry entry = new Entry();
            entry._date = date;
            entry._prompt = prompt;
            entry._response = response;
            _entries.Add(entry);
        }

    }


    // display
    public void DisplayEntries()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("You have no entries bro!!!");
        }
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }
}