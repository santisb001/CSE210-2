using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;

public class Circle : Shape
{
    //Attributes
    private double _radius;

    //Constructor
    public Circle(string name, string color, double radius) : base (name,color)
    {
        _radius = radius;
    }

    //Methods
    public override double GetArea()
    {
        return 3.14 * (_radius * _radius);
    }
}