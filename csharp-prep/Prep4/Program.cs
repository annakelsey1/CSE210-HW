using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int number = -1;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (number != 0)
        {
            Console.WriteLine("Enter a number: ");
            number = int.Parse(Console.ReadLine());

            if (number != 0)
            {
                numbers.Add(number);
            }
        }

        int sum = 0;
        foreach (int i in numbers)
        {
            sum += i;

        }
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {sum / numbers.Count}");

        int largest = 0;
        foreach (int i in numbers)
        {
            if (i > largest)
            largest = i;
        }
        Console.WriteLine($"The largest number is: {largest}");
    }
}