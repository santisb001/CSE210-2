using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;

public class Rectangle : Shape
{
    //Attributes
    private double _lenght;
    private double _hight;

    //Constructor
    public Rectangle(string name, string color, double lenght, double hight) : base (name,color)
    {
        _lenght = lenght;
        _hight = hight;
    }

    //Methods
    public override double GetArea()
    {
        return _lenght * _hight;
    }
}