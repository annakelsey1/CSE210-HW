using System;

// Date and length of activity in minutes.
// Distance, speed (mph), pace (minutes per mile), summary:
// 03 Nov 2022 Running (30 min)- Distance 3.0 miles, Speed 6.0 mph, Pace: 10.0 min per mile

// In addition, the base class should contain virtual methods for getting the distance, 
// speed, pace. These methods should be overridden in the derived classes.

// Finally, you should provide a GetSummary method to produce a string with all the summary information.

public class Activity
{
    protected int _length;  // Length of the activity in minutes
    protected int _distance; // Distance covered in meters

    public Activity(int length, int distance)
    {
        _length = length;
        _distance = distance;
    }

    public int Length => _length; // Property to get the length

    public virtual double GetDistance()
    {
        return _distance;
    }

    public virtual double GetSpeed()
    {
        return 0; // Default implementation, override in derived classes
    }

    public virtual double GetPace()
    {
        return 0; // Default implementation, override in derived classes
    }
}
