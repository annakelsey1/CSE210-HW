using System;
//Write a new entry - Show the user a random prompt (from a list that you create), 
//and save their response, the prompt, and the date as an Entry.

//Display the journal - Iterate through all entries in the journal and display them to the screen.

public class Entry
{
    public string _response;
    public string _prompt;

    private DateTime _entrydate;

    public DateTime EntryDate
    {
        get {return _entrydate;}
    }

    public void GenerateEntryDate()
    {
        _entrydate = DateTime.Now;
    }

    // public class EntryDate()
    // {
    //     _entrydate = DateTime.Now;
    //     //This may be an issue later, make sure this is the right
    //     //place to put this. I may need to put it in program.cs
    // }

    //Your list of prompts must contain at least five different prompts
    public void Prompt()
    {
        List<string> prompts = new List<string>()
        {
            "What 5 lessons would you tell your 18 year old self?",
            "What are you grateful for today?",
            "What is something you wish you did differently today and why?",
            "What is a list of things you are not?",
            "Write down what advice a loved one has given that changed your world-view",
            "What accomplishment are you proud of today?"
        };

        Random random = new Random();

        int randomIndex = random.Next(prompts.Count);
        _prompt = prompts[randomIndex];
        Console.WriteLine($"{_prompt}");
    }

    public void GetEntry()
    {
        Console.WriteLine(">");
        _response = Console.ReadLine();
    }
}