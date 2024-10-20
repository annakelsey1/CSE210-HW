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

    public ListingActivity(int count, List<string> prompts, string startMessage, string endingMessage, string description, string duration)
        : base(startMessage, endingMessage, description, duration)
    {
        this._count = count;
        this._prompts = prompts;
    }
}
