using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class Assignment
{
    //Attributes
    private string _studentName;
    private string _topic;

    //Constructor
    public Assignment(string name, string topic)
    {
        _studentName = name;
        _topic = topic;
    }

    //getters and setters
    public string GetName()
    {
        return _studentName;
    }
    public void SetName(string name)
    {
        _studentName = name;
    }

    public string GetTopic()
    {
        return _topic;
    }
    public void SetTopic(string topic)
    {
        _topic = topic;
    }

    //Methods
    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }
}