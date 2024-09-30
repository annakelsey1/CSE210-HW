using System;


public class Resume
{
    public string _name;
    public List<Job> _jobs = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine($"Work History: ");

        foreach (Job i in _jobs)
        {
            i.Display();
        }
    }
}
// Keeps track of the person's name and a list of their jobs.
// Displays the resume, which shows the name first, followed by displaying each one of the jobs.

