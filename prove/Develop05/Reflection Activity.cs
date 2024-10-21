using System;

// Run the activity

// Get a random prompt to show
// Get a random question about the prompt
// Display the prompt
// Display questions about the prompt and get answers

// Run() : void
// GetRandomPrompt() : string
// GetRandomQuestion() : string
// DisplayPrompt() : void
// DisplayQuestions() : void

// _prompts : List<string>
// _questions : List<string>

// For example, a constructor that has no parameters could look like this:
// public ReflectingActivity()
//     {
//         _name = "Reflecting";
//         _description = "This activity will help you reflect on times ...";
//         _duration = 50;

//         // Set other values here that are unique to the Reflecting Activity
//     }
// The code above shows the most simple and straightforward way to do this and assumes the variables are
// protected (not private) in the base class. You could also use setters or pass them to the base base class
// constructor directly.

public class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectionActivity(string duration)
        : base("Welcome to the Reflection Activity.", 
               "Well done! You have completed the Reflection Activity.", 
               "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", 
               duration)
    {
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    public string GetRandomQuestion()
    {
        Random random = new Random();
        int index = random.Next(_questions.Count);
        return _questions[index];
    }

    public void DisplayPrompt()
    {
        string prompt = GetRandomPrompt();
        Console.WriteLine(prompt);
    }

    public void DisplayQuestion()
    {
        string question = GetRandomQuestion();
        Console.WriteLine(question);
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine("Please enter the duration for the reflection activity in seconds:");
        string input = Console.ReadLine();
        int durationInSeconds;

        if (int.TryParse(input, out durationInSeconds))
        {
            DateTime endTime = DateTime.Now.AddSeconds(durationInSeconds);

            Console.WriteLine("Get Ready...");
            PauseWithSpinner(3);

            Console.WriteLine("Consider the following prompt:");
            DisplayPrompt();

            Console.WriteLine("\nWhen you have something in mind, press enter to continue.");
            Console.ReadLine();

            Console.WriteLine("You may begin in:");
            PauseWithCountdown(5);

            while (DateTime.Now < endTime)
            {
                DisplayQuestion();

                PauseWithCountdown(5);
            }

            DisplayEndingMessage();
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number for the duration.");
        }
    }
}
