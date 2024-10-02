using System;

public class Journal
{
    public List<Entry> _entry = new List<Entry>();
    public void NewEntry()
    {
        Entry newEntry = new Entry();
        newEntry.GenerateEntryDate();
        newEntry.Prompt();
        newEntry.GetEntry();
        _entry.Add(newEntry);
    }

    public void DisplayEntry()
    {
        foreach (Entry i in _entry)
        {
            Console.WriteLine($"Date: {i.EntryDate}");
            Console.WriteLine($"Prompt: {i._prompt}");
            Console.WriteLine($"{i._response}");
            Console.WriteLine();
        }
    }
    public void LoadEntries(string filename)
    {
        if (filename.EndsWith(".csv"))
        {
            string[] lines = System.IO.File.ReadAllLines(filename);
            foreach (string line in lines)
            {
                string[] parts = line.Split(",");
                string date = parts[0];
                string prompt = parts[1];
                string response = parts[2];
                Console.WriteLine($"Date: {date}");
                Console.WriteLine($"Prompt: {prompt}");
                Console.WriteLine($"{response}");
                Console.WriteLine();
            }
        }
        else
        {
            using (StreamReader reader = new StreamReader(filename))
            {
                String journalEntries = reader.ReadToEnd();
                Console.Write(journalEntries);
            }
        }
    }

    public void SaveEntries(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename, true))
        {
            if (filename.EndsWith(".csv"))
            {
                foreach (Entry i in _entry)
                {
                    outputFile.WriteLine($"{i.EntryDate},{i._prompt},{i._response}");
                }
            }
            else
            {
                foreach (Entry i in _entry)
                {
                    outputFile.WriteLine($"Date:{i.EntryDate},{i._prompt},{i._response}");
                    outputFile.WriteLine($"Prompt:{i._prompt}");
                    outputFile.WriteLine($"{i._response}");
                    outputFile.WriteLine();
                }
            }
        }
    }
}


