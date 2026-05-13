using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class Entry
{
    //Atributes
    public string _date;
    public string _inputText = "";
    public string _promptText = "";
    public PromptGenerator _promptGeneratorChoice;

    //Constructor
    public Entry(PromptGenerator promptGenerator)
    {
        _date = DateTime.Now.ToShortDateString();
        _promptGeneratorChoice = promptGenerator;
        _promptText = _promptGeneratorChoice.ReturnRandomPrompt();
    }
    
    //Methods
    public string DisplayEntry()
    {
        //Show a string with all the info of the entry to the screen
        //Console.WriteLine($"{_date} -- {_promptText}: {_inputText}");
        return _date + " -- " + _promptText + ": " + _inputText;
    }

}