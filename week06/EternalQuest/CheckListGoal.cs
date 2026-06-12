using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;

public class CheckListGoal : Goal
{
    //Attributes
    private int _timesToDo;
    private int _times;
    private int _bonus;

    //Constructor
    public CheckListGoal(string name, string description, string points, int timesToDo, int bonus) : base (name,description,points)
    {
        _timesToDo = timesToDo;
        _bonus = bonus;
    }

    //Methods
    public override void RecordEvent()
    {
        //Later
    }
    public override bool IsComplete()
    {
        //return true;
    }
    public override string GetDetails()
    {
        return $"[ ] {_goalName},{_description},{_points},{_times}";
    }
}