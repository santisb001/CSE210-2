using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;

public class SimpleGoal : Goal
{
    //Attributes
    private bool _isComplete;
    //Constructor
    public SimpleGoal(string name, string description, int points) : base (name,description,points)
    {
        _isComplete = false;
    }

    //Methods
    public override void RecordEvent()
    {
        //Call the IsComplete() method and record what happened
    }

    public override bool IsComplete()
    {
        _isComplete = true;
        return _isComplete;
    }

    public override string GetDetails()
    {
        return $"Goal: {_goalName}, {_description}, points earned: {_points}";
    }

    //public override string GetStringRepresentation()
    //{
    //    
    //}
}