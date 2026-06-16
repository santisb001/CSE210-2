using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;

public class SimpleGoal : Goal
{
    //Attributes
    //none
    //Constructor
    public SimpleGoal(string name, string description, int points) : base (name,description,points)
    {
        
    }

    //Methods
    public override void RecordEvent()
    {
        //Call the IsComplete() method and record what happened
    }
    public bool CompleteIt()
    {
        _complete = true;
        return _complete;
    }

    public override string GetDetails()
    {
        return $"{_goalName},{_description},{_points}";
    }

    //public override string GetStringRepresentation()
    //{
    //    
    //}
}