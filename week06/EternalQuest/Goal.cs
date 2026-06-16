using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;

public abstract class Goal
{
    //Attributes
    protected string _goalName;
    protected string _description;
    protected int _points;
    protected bool _complete;

    //Constructor
    public Goal(string name, string description, int points)
    {
        _goalName = name;
        _description = description;
        _points = points;
        _complete = false;
    }

    //Methods
    public abstract void RecordEvent();
    public bool IsComplete()
    {
        return _complete;
    }
    public abstract string GetDetails();
    //public abstract string GetStringRepresentation();

}