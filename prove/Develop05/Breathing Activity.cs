using System;

// Run the activity

// Run() : void

public class BreathingActivity : Activity
{
    public BreathingActivity(string startMessage, string endingMessage, string name, string description, string duration) : base(startMessage, endingMessage, name, description, duration)
    {
    }

    
    public void Run()
    {
        DisplayStartingMessage();
        
        int durationInSeconds;
        if (int.TryParse(_duration, out durationInSeconds))
        {
            DateTime endTime = DateTime.Now.AddSeconds(durationInSeconds);
            
            while (DateTime.Now < endTime)
            {
                Console.WriteLine("Breathe in...");
                PauseWithCountdown(4);
                
                Console.WriteLine("Breathe out...");
                PauseWithCountdown(6);
            }
        }
        else
        {
            Console.WriteLine("Invalid duration specified.");
        }

        DisplayEndingMessage();
    }
}
