using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class Comment
{
    //Attributes
    private string _author;
    private string _text;

    //Constructor
    public Comment(string person, string text)
    {
        _author = person;
        _text = text;
    }

    //Methods
    public void DisplayComment()
    {
        Console.WriteLine($"{_author}: {_text}");
    }

    
}