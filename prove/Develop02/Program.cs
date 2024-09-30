using System;

//Save the journal to a file - Prompt the user for a filename and then save 
//the current journal (the complete list of entries) to that file location.

//Load the journal from a file - Prompt the user for a filename and then load 
//the journal (a complete list of entries) from that file. This should replace any entries currently stored the journal.

//Provide a menu that allows the user choose these options

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

            // Handling user input with switch statement
            switch (answer)
            {
                case 1:
                    Console.WriteLine("Write selected.");
                    // Add logic to write an entry
                    break;
                case 2:
                    Console.WriteLine("Display selected.");
                    // Add logic to display entries
                    break;
                case 3:
                    Console.WriteLine("Load selected.");
                    // Add logic to load entries
                    break;
                case 4:
                    Console.WriteLine("Save selected.");
                    // Add logic to save entries
                    break;
                case 5:
                    Console.WriteLine("Quit selected.");
                    running = false;  // Exit the loop
                    break;
                default:
                    Console.WriteLine("Sorry, that's not an option. Please type a number between 1 and 5.");
                    break;
            }
        }
    }
}
