using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 11);
        Console.WriteLine("What is your guess?");
        int guess = int.Parse(Console.ReadLine());
        while (guess != magicNumber)
        {
            
            if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
                Console.WriteLine("What is your guess?");
                guess = int.Parse(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("Higher");
                Console.WriteLine("What is your guess?");
                guess = int.Parse(Console.ReadLine());
            }
            
        }
        Console.WriteLine("You got it right!");

    }
}