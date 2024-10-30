using System;

// speed

public class BicycleActivity : Activity
{
    public BicycleActivity(int length, double speed) : base(length, 0)
    {
        _speed = speed;
    }

    private double _speed;

    public override double GetDistance()
    {
        return 0;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return 0;
    }
}
