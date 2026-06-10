using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;

public class Square : Shape
{
    //Attributes
    private double _side;

    //Constructor
    public Square(string name, string color, double side) : base(name,color)
    {
        _side = side;
    }

    //Methods
    public override double GetArea()
    {
        return _side * _side;
    }
}