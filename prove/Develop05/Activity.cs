using System;

// Displaying the starting message
// Displaying the ending message
// Pausing while showing a spinner for a certain number of seconds
// Pausing while showing a countdown timer for a certain number of seconds

// For example, each of the following are common behaviors that should be in the base class:
// Displaying the starting message
// Displaying the ending message
// Pausing while showing a spinner for a certain number of seconds
// Pausing while showing a countdown timer for a certain number of seconds

// DisplayStartingMessage() : void
// DisplayEndingMessage() : void
// ShowSpinner(seconds : int) : void
// ShowCountDown(second : int) : void

// The activity name
// The description
// The duration in seconds


public class Activity
{
    protected string _startMessage = "";  
    protected string _endingMessage = "";
    protected string _description = "";
    protected string _duration = "";


    public Activity(string startMessage, string endingMessage, string description, string duration)
    {
        _startMessage = startMessage;
        _endingMessage = endingMessage;
        _description = description;
        _duration = duration;
    }



    public void DisplayStartingMessage()
    {
        Console.WriteLine(_startMessage);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine(_endingMessage);
    }

    public void PauseWithSpinner(int seconds)
    {
        char[] spinnerChars = new char[] { '|', '/', '-', '\\' };
        DateTime endTime = DateTime.Now.AddSeconds(seconds);

        int i = 0;
        while (DateTime.Now < endTime)
        {
            Console.Write(spinnerChars[i % spinnerChars.Length]);
            Thread.Sleep(250);
            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
            i++;
        }

        Console.WriteLine();
    }

    public void PauseWithCountdown(int seconds)
    {
        for (int i = seconds; i >= 0; i--)
        {
            Console.Write($"\rCountdown: {i} seconds remaining");
            Thread.Sleep(1000);
        }

        Console.WriteLine();
    }
}
