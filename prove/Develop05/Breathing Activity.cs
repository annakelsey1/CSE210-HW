using System;

// Run the activity

// Run() : void

public class BreathingActivity : Activity
{
    public BreathingActivity() 
        : base("Welcome to the Breathing Activity.", "Well done! You have completed the Breathing Activity.", "Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
        
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine("Please enter the duration for the activity in seconds:");
        string input = Console.ReadLine();
        
        int durationInSeconds;
        if (int.TryParse(input, out durationInSeconds))
        {
            Console.WriteLine("Get Ready...");
            PauseWithSpinner(3);

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
            Console.WriteLine("Invalid input. Please enter a valid number for the duration.");
        }

        DisplayEndingMessage();
    }
}


