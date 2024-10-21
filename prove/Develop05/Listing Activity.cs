using System;

// Run the activity

// Get a random prompt
// Get a list of responses from the user

// Run() : void
// GetRandomPrompt() : string
// GetListFromUser() : List<string>

// _count : int
// _prompts : List<string>

public class ListingActivity : Activity
{
    protected int _count;
    protected List<string> _prompts = new List<string>();
    protected List<string> _responses = new List<string>();

    public ListingActivity(int count, List<string> prompts, string duration)
        : base("Welcome to the Listing Activity.", 
               "Well done! You have completed the Listing Activity.", 
               "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", 
               duration)
    {
        this._count = count;
        this._prompts = prompts;
    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine(_description);

        Console.Write("How long, in seconds, would you like for your session? ");
        string input = Console.ReadLine();
        int durationInSeconds;

        if (int.TryParse(input, out durationInSeconds))
        {
            Console.WriteLine("Get ready...");
            PauseWithSpinner(3);

            Random random = new Random();
            int index = random.Next(_prompts.Count);
            Console.WriteLine("List as many responses you can to the following prompt:");
            Console.WriteLine(_prompts[index]);

            Console.WriteLine("You may begin in:");
            PauseWithCountdown(10);

            DateTime endTime = DateTime.Now.AddSeconds(durationInSeconds);
            while (DateTime.Now < endTime)
            {
                Console.Write("> ");
                string response = Console.ReadLine();
                
                if (!string.IsNullOrWhiteSpace(response))
                {
                    _responses.Add(response);
                }
            }

            Console.WriteLine($"\nYou listed {_responses.Count} items!");

            DisplayEndingMessage();
            
            PauseWithSpinner(3);

            Console.WriteLine($"You have completed another {durationInSeconds} seconds of the Listing Activity.");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number for the duration.");
        }
    }
}

