using System;
using System.Collections.Generic;

public class Entry
{
    //Atributes
    public string _date = "";
    public string _inputText = "";
    public string _promptText = "";

    //Methods
    public string DisplayEntry()
    {
        //Show a string with all the info of the entry to the screen
        Console.WriteLine($"{_promptText}: {_inputText} -- {_date}");
    }

}