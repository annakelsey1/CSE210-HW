using System;

// _side : double
// Get Area() : double

public class Square : Shape
{
    protected double _side = 0;

    public Square(double side)
    {
        _side = side;
    }

    public override double GetArea()
    {
        return _side * _side;
    }

    public double GetSide()
    {
        return _side;
    }

    public void SetSide(double side)
    {
        _side = side;
    }
}