using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;

//You may have to make it an ABSTRACT or INTERFACE
public abstract class Shape
{
    //Attributes
    private string _name;
    private string _color;

    //Constructor
    public Shape(string name, string color)
    {
        _name = name;
        _color = color;
    }

    //Methods
    public string GetName()
    {
        return _name;
    }
    public string GetColor()
    {
        return _color;
    }

    public abstract double GetArea();
}