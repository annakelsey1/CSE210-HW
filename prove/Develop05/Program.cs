using System;

class Program
{
    static void Main(string[] args)
    {
        // Pausing with spinner for 5 seconds
        // assignment.PauseWithSpinner(5);

        // Pausing with countdown timer for 5 seconds
        // assignment.PauseWithCountdown(5);

        //Menu Options:
        //  1. Start breathing activity
        //  2. Start reflecting activity
        //  3. Start listing activity
        //  4. Quit
        //Select a choice from the menu:

        bool quit = false;

        while (!quit)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu: ");
            
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    BreathingActivity breathing = new BreathingActivity("60");
                    breathing.Run();
                    break;


                case "2":
                    ReflectionActivity reflecting = new ReflectionActivity("60");
                    reflecting.Run();
                    break;

                case "3":
                    List<string> prompts = new List<string>
                    {
                        "List things you're grateful for.",
                        "List things that make you happy."
                    };
                    ListingActivity listing = new ListingActivity(prompts.Count, prompts, "60");
                    listing.Run();
                    break;

                case "4":
                    quit = true;
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please select a valid option.");
                    break;
            }

            Console.WriteLine();
        }
    }
}