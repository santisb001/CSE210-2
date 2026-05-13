using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
public class PromptGenerator
{
    //Atributes
    public List<string> _listOfPrompts = new List<string>();
    public string _file = "promptsFile.csv";
    //public string[] _prompts = File.ReadAllLines(_file);
    public Random _random = new Random(); 

    //Methods
    public string ReturnRandomPrompt()
    {
        //Select a prompt from the list and return it as a string, and make them not repeat
        if (_listOfPrompts.Count == 0)
        {
            _listOfPrompts = File.ReadAllLines(_file).ToList();
        }

        int index = _random.Next(_listOfPrompts.Count);

        string chosenPrompt = _listOfPrompts[index];

        _listOfPrompts.RemoveAt(index);

        return chosenPrompt;
    }

}