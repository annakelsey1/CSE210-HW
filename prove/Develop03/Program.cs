using System;

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Develop03 World!");


        Reference reference = new Reference("Ether", 12, 6);
        string example = "And now, I, Moroni, would speak somewhat concerning these things; I would show unto the world that faith is things which are hoped for and not seen; wherefore, dispute not because ye see not, for ye receive no witness until after the trial of your faith.";
        Scripture scripture = new Scripture(reference, example.Split(' ').ToList());

        string op = "";
        Random rnd = new Random();

        while (op != "quit")
        {
            Console.Clear();
            string response = scripture.GetScripture(); 
            Console.WriteLine(response);
            Console.WriteLine("\nPlease press 'enter' to continue or type 'quit' to finish: ");
            op = Console.ReadLine().ToLower();

            int randomNumber = rnd.Next(1, 3);
            for (int i = 0; i < randomNumber; i++)
            {
                scripture.HideRandomWord();
            }
        }
    }
}
