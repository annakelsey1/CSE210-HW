using System;

public class Program
{
    public static void Main()
    {
        GoalManager goalManager = new GoalManager();
        bool quit = false;

        while (!quit)
        {
            Console.Clear();
            Console.WriteLine($"You have {goalManager.Score} points\n");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    goalManager.CreateGoal();
                    break;
                case "2":
                    goalManager.ListGoalNames();
                    break;
                case "3":
                    goalManager.SaveGoals();
                    break;
                case "4":
                    goalManager.LoadGoals();
                    break;
                case "5":
                    goalManager.RecordEvent();
                    break;
                case "6":
                    quit = true;
                    Console.WriteLine("Exiting program. Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

            if (!quit)
            {
                Console.WriteLine("\nPress Enter to return to the menu...");
                Console.ReadLine();
            }
        }
    }
}
