using System;

public class Program
{
    public static void Main(string[] args)
    {
        RunningActivity running = new RunningActivity(30, 4828);
        BicycleActivity biking = new BicycleActivity(45, 15.0);
        SwimmingActivity swimming = new SwimmingActivity(30, 20);

        DisplayActivityResults(running, "03 Nov 2022");
        DisplayActivityResults(biking, "03 Nov 2022");
        DisplayActivityResults(swimming, "03 Nov 2022");
    }

    private static void DisplayActivityResults(Activity activity, string date)
    {
        string activityType = activity is RunningActivity ? "Running" :
                              activity is BicycleActivity ? "Biking" :
                              activity is SwimmingActivity ? "Swimming" : "Unknown Activity";

        string length = $"{activity.Length} min";
        string distance = $"Distance {activity.GetDistance() / 1609.34:F1} miles";
        string speed = $"Speed {activity.GetSpeed():F1} mph";
        string pace = $"Pace: {activity.GetPace():F1} min per mile";

        if (activity is SwimmingActivity)
        {
            Console.WriteLine($"{date} {activityType} ({length}) - {distance}, {pace}");
        }
        else
        {
            Console.WriteLine($"{date} {activityType} ({length}) - {distance}, {speed}, {pace}");
        }
    }
}
