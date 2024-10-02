using System;

//Save the journal to a file - Prompt the user for a filename and then save 
//the current journal (the complete list of entries) to that file location.

//Load the journal from a file - Prompt the user for a filename and then load 
//the journal (a complete list of entries) from that file. This should replace any entries currently stored the journal.

//Provide a menu that allows the user choose these options

//In addition, your program must:
//Contain classes for the major components in the program.
//Contain at least two classes in addition to the Program class.
//Demonstrate the principle of abstraction by using member variables and methods appropriately.

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        bool running = true;
        while (running)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.WriteLine("What would you like to do? ");
            int answer = int.Parse(Console.ReadLine());
            Console.WriteLine();
            
            switch (answer)
            {
                case 1:
                    journal.NewEntry();
                    Console.WriteLine();
                    break;
                case 2:
                    journal.DisplayEntry();
                    Console.WriteLine();
                    break;
                case 3:
                    Console.Write("Enter the file you want to load: ");
                    string loadFileName = Console.ReadLine();
                    journal.LoadEntries(loadFileName);
                    Console.WriteLine();
                    break;
                case 4:
                    Console.Write("Enter the name of the file you want to save: ");
                    string saveFileName = Console.ReadLine();
                    journal.SaveEntries(saveFileName);
                    Console.WriteLine("Your entry was saved.");
                    Console.WriteLine();
                    break;
                case 5:
                    Console.WriteLine("Quitting. Thank you for writing today!");
                    running = false; 
                    break;
                default:
                    Console.WriteLine("Sorry, that's not an option. Please type a number between 1 and 5.");
                    break;
            }
        }
    }
}
