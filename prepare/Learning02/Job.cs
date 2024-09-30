using System;

public class Job
{
    public string _company;
    public string _jobtitle;
    public int _startyear;
    public int _endyear;

    public void Display()
    {
        Console.WriteLine($"{_company}, {_jobtitle} {_startyear} - {_endyear}");
    }
}
// Keeps track of the company, job title, start year, and end year.
// Displays the job information in the format "Job Title (Company) StartYear-EndYear", for example: "Software Engineer (Microsoft) 2019-2022".
