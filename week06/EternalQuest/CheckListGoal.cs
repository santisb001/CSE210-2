using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;

public class CheckListGoal : Goal
{
    //Attributes
    private int _target;
    private int _times;
    private int _bonus;

    //Constructor
    public CheckListGoal(string name, string description, string points, int target, int bonus) : base (name,description,points)
    {
        _target = target;
        _bonus = bonus;
        _times = 0;
    }

    //Methods
    public override void RecordEvent()
    {
        if(_times == _target)
        {
            _complete = CompleteIt;
        }
        else
        {
            _times + 1;
            _points + _points;
        }
    }
    public bool CompleteIt()
    {
        return true;
    }
    public override string GetDetails()
    {
        if(!_complete)
        {
            return $"[ ] {_goalName},{_description},{_points},{_bonus}, ----- {_times}/{_target}";    
        } 
        else if(_complete)
        {
            return $"[ X ] {_goalName},{_description},{_points},{_bonus}, ----- {_times}/{_target}";
        }
    }
}