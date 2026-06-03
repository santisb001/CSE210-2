using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class Activity
{
    //Attributes
    private string _startMessage;
    private string _endMessage;
    private string _description;
    private int _duration;

    //Constructor
    public Activity(string start, string end, string description)
    {
        _startMessage = start;
        _endMessage = end;
        _description = description;
        _duration = 0;
    }

    //Methods
    public string GetStartMessage()
    {
        return _startMessage;
    }
    public string GetEndMessage()
    {
        return _endMessage;
    }
    public void SetDuration(int seconds)
    {
        _duration = seconds;
    }
    public int GetDuration()
    {
        return _duration;
    }

}