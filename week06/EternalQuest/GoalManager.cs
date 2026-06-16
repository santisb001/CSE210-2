using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;

public class GoalManager
{
    //Attributes
    private List<Goal> _goals;
    private int _score;

    //Constructor
    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    //Methods
    public void Start()
    {
        //Run the program
    }
    public void DisplayPlayerInfo()
    {
        //score and stuff I think
    }
    public void ListGoals()
    {
        foreach(Goal G in _goals)
        {
            G.GetDetails();
        }
    }
}