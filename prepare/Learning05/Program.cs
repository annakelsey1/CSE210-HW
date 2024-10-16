using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment("Anna Kelsey", "Classes and C#");
        Console.WriteLine(assignment1.GetSummary());

        MathAssignment assigment2 = new MathAssignment("Adam Thiriot", "House Renovations 101", "5", "7");
        Console.WriteLine(assigment2.GetSummary());
        Console.WriteLine(assigment2.GetHomeworkList());

        WritingAssignment assignment3 = new WritingAssignment("Mark Kelsey", "Business Management", "How to Be A Boss");
        Console.WriteLine(assignment3.GetSummary());
        Console.WriteLine(assignment3.GetWritingInformation());
    }
}