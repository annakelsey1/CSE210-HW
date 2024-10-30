using System;

// number of laps - 50 meters

public class SwimmingActivity : Activity
{
    private int _laps;

    public SwimmingActivity(int length, int laps) : base(length, laps * 50)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return _laps * 50;
    }

    public override double GetSpeed()
    {
        return 0;
    }

    public int GetLaps()
    {
        return _laps;
    }

    public override double GetPace()
    {
        return _length / (double)_laps;
    }
}
