using System;

// number of laps - 50 meters

public class SwimmingActivity : Activity
{
    private int _laps;

    public SwimmingActivity(int length, int laps) : base(length, laps * 50) // Calculate distance based on laps
    {
        _laps = laps;
    }

    // Override to return the distance based on laps
    public override double GetDistance()
    {
        return _laps * 50; // Each lap is 50 meters, so this returns the total distance in meters
    }

    // Override GetSpeed to indicate that speed is not measured in this context
    public override double GetSpeed()
    {
        return 0; // Speed is not relevant for swimming activity in this case
    }

    // New method specific to SwimmingActivity to get the number of laps
    public int GetLaps()
    {
        return _laps;
    }

    // Override GetPace to calculate the time per lap
    public override double GetPace()
    {
        return _length / (double)_laps; // Returns the pace in minutes per lap
    }
}
