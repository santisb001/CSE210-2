using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class Activity
{
    //Attributes
    private string _startMessage;
    private string _description;
    protected int _duration;

    //Constructor
    public Activity(string start, string description)
    {
        _startMessage = start;
        _description = description;
        _duration = 0;
    }

    //Methods
    public string GetStartMessage()
    {
        return $"Welcome to the {_startMessage}";
    }
    public string GetEndMessage()
    {
        return $"Well Done!!\n\nYou have completed another {_duration} seconds of {_startMessage}";
    }
    public void SetDuration(int seconds)
    {
        _duration = seconds;
    }
    public int GetDuration()
    {
        return _duration;
    }
    public string GetDescription()
    {
        return _description;
    }
    public void GetSpinner()
    {
        List<string> animationStrings = new List<string>();
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("—");
        animationStrings.Add("\\");
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("—");
        animationStrings.Add("\\");
        foreach(string s in animationStrings)
        {
            Console.Write(s);
            Thread.Sleep(500);
            Console.Write("\b \b");
        }
    }
}