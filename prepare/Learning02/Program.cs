using System;

class Program
{
    static void Main(string[] args)
    {
        Job currentjob = new Job();
        currentjob._company = "KLAS Research";
        currentjob._jobtitle = "Associate Researcher";
        currentjob._startyear = 2024;
        currentjob._endyear = 2024;

        Job lastjob = new Job();
        lastjob._company = "Davidson Defense";
        lastjob._jobtitle = "Shipper";
        lastjob._startyear = 2023;
        lastjob._endyear = 2023;

        Job overlast = new Job();
        overlast._company = "Church of Jesus Christ of Latter-day Saints";
        overlast._jobtitle = "Service Missionary";
        overlast._startyear = 2022;
        overlast._endyear = 2023;

        Resume anna = new Resume();
        anna._name = "Anna Kelsey";
        anna._jobs.Add(currentjob);
        anna._jobs.Add(lastjob);
        anna._jobs.Add(overlast);

        anna.Display();

    }
}