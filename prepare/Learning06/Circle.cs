using System;

// _radius : double
// GetArea() : double

public class Circle : Shape
{
    protected double _radius = 0;

    public Circle(double radius)
    {
        _radius = radius;
    }

    public override double GetArea()
    {
        return Math.PI * _radius * _radius;
    }

    public double GetRadius()
    {
        return _radius;
    }

    public void SetRadius(double radius)
    {
        _radius = radius;
    }
}
