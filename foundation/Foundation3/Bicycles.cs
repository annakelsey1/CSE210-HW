using System;

// speed

public class BicycleActivity : Activity
{
    public BicycleActivity(int length, double speed) : base(length, 0) // Distance is set to 0 by default
    {
        _speed = speed;
    }

    private double _speed;

    // Override GetDistance to indicate no specific distance is measured
    public override double GetDistance()
    {
        return 0; // Indicating that distance is not tracked for bicycle activities
    }

    // Override GetSpeed to return the speed that was passed to the constructor
    public override double GetSpeed()
    {
        return _speed; // Speed is set directly, in miles per hour for example
    }

    // Override GetPace if it’s relevant, otherwise you could omit it
    public override double GetPace()
    {
        return 0; // Pace might not be relevant for this activity type
    }
}
