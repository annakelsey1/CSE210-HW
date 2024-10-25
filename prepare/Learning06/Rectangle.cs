using System;

// _length : double
// _width : double
// GetArea() : double

public class Rectangle : Shape
{
    protected double _length = 0;
    protected double _width = 0;

    public Rectangle(double length, double width)
    {
        _length = length;
        _width = width;
    }

    public override double GetArea()
    {
        return _length * _width;
    }

    public double GetLength()
    {
        return _length;
    }

    public void SetLength(double length)
    {
        _length = length;
    }

    public double GetWidth()
    {
        return _width;
    }

    public void SetWidth(double width)
    {
        _width = width;
    }
}
