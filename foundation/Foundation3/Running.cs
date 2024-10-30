using System;

// distance

public class RunningActivity : Activity
{
    private const double MetersToMiles = 1609.34;

    public RunningActivity(int length, int distance) : base(length, distance) {}

    public override double GetDistance()
    {
        return _distance / MetersToMiles;
    }

    public override double GetSpeed()
    {
        double distanceInMiles = GetDistance();
        double timeInHours = _length / 60.0;
        return distanceInMiles / timeInHours;
    }

    public override double GetPace()
    {
        double distanceInMiles = GetDistance();
        return _length / distanceInMiles;
    }
}
