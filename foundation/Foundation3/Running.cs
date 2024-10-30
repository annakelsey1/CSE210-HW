using System;

// distance

public class RunningActivity : Activity
{
    private const double MetersToMiles = 1609.34;

    public RunningActivity(int length, int distance) : base(length, distance) {}

    // Override to return distance in miles
    public override double GetDistance()
    {
        return _distance / MetersToMiles; // Convert distance to miles
    }

    // Override to calculate speed in miles per hour
    public override double GetSpeed()
    {
        double distanceInMiles = GetDistance(); // Use the overridden GetDistance method
        double timeInHours = _length / 60.0; // Convert time to hours
        return distanceInMiles / timeInHours; // Speed in miles per hour
    }

    // Override to calculate pace in minutes per mile
    public override double GetPace()
    {
        double distanceInMiles = GetDistance(); // Use the overridden GetDistance method
        return _length / distanceInMiles; // Pace in minutes per mile
    }
}
