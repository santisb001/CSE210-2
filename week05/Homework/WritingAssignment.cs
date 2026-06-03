using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class WritingAssignment : Assignment
{
    //Attributes
    private string _title;

    //Constructor
    public WritingAssignment(string name, string topic, string title) : base(name,topic)
    {
        _title = title;
    }

    //Methods
    public string GetWritingInformation()
    {
        return $"{_title} by {GetName()}";
    }


}