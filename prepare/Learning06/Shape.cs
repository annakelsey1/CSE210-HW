using System;

// _color : string
// GetColor() : string
// SetColor() : void
// GetArea() : double

public class Shape
{
    protected string _color = "";

    public string GetColor()
    {
        return _color;
    }

    public void SetColor(string color)
    {
        _color = color;
    }

    public double GetArea()
    {
        return 0;
    }
}