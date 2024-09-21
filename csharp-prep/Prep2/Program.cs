using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Input your grade percentage:");
        string getGrade = Console.ReadLine();
        int grade = int.Parse(getGrade);
        string inputGrade;

        if (grade >= 90)
        {
            inputGrade = "A";
        }
        else if (grade >= 80)
        {
            inputGrade = "B";
        }
        else if (grade >= 70)
        {
            inputGrade = "C";
        }
        else if (grade >= 60)
        {
            inputGrade = "D";
        }
        else
        {
            inputGrade = "F";
        }

        if (grade >= 70)
        {
            Console.WriteLine($"Your grade is {inputGrade}. Congratulation, you passed!");
        }
        else
        {
            Console.WriteLine($"Your grade is {inputGrade}. You didn't pass this time, but I'm sure you will next time!");
        }
    }
}