using System;

public class Program
{
    public static void Main(string[] args)
    {
        // Creating and initializing the activities
        RunningActivity running = new RunningActivity(30, 4828); // 30 min, 4828 meters (~3.0 miles)
        BicycleActivity biking = new BicycleActivity(45, 15.0); // 45 min, speed 15.0 mph
        SwimmingActivity swimming = new SwimmingActivity(30, 20); // 30 min, 20 laps (1000 meters)

        // Display results
        DisplayActivityResults(running, "03 Nov 2022");
        DisplayActivityResults(biking, "03 Nov 2022");
        DisplayActivityResults(swimming, "03 Nov 2022");
    }

    private static void DisplayActivityResults(Activity activity, string date)
    {
        // Define custom names for the activities
        string activityType = activity is RunningActivity ? "Running" :
                              activity is BicycleActivity ? "Biking" :
                              activity is SwimmingActivity ? "Swimming" : "Unknown Activity";

        string length = $"{activity.Length} min"; // Length of the activity
        string distance = $"Distance {activity.GetDistance() / 1609.34:F1} miles"; // Convert distance from meters to miles
        string speed = $"Speed {activity.GetSpeed():F1} mph"; // Speed in mph
        string pace = $"Pace: {activity.GetPace():F1} min per mile"; // Pace in min per mile

        // Output based on activity type
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
