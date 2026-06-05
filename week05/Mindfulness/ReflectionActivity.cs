using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class ReflectionActivity : Activity
{
    //Attributes
    private List<string> _prompts;
    private List<string> _reflections;
    private string _reflectionFile;
    private string _promptsFile;
    Random _random;

    //Constructor
    public ReflectionActivity(string start, string description) : base (start,description)
    {
        _prompts = new List<string>();
        _reflections = new List<string>();
        _reflectionFile = "Reflections.csv";
        _promptsFile = "ReflectionPrompts.csv";
        _random = new Random();
    }

    //Methods
    public void Run()
    {
        //code the execution of the class
        ///
        /// 
        /// 
        /// Finish later with the loop
        /// 
        /// 
        /// 
    }
    
    public string GetPrompt()
    {
        //Select and return a random prompt
        if (_prompts.Count == 0)
        {
            _prompts = File.ReadAllLines(_promptsFile).ToList();
        }

        int index = _random.Next(_prompts.Count);

        string chosenPrompt = _prompts[index];

        _prompts.RemoveAt(index);

        return chosenPrompt;
        //return string
    }

    public string GetReflection()
    {
        //Select and return a random Reflection
        
        if (_reflections.Count == 0)
        {
            _reflections = File.ReadAllLines(_reflectionFile).ToList();
        }

        int index = _random.Next(_reflections.Count);

        string chosenRef = _reflections[index];

        _reflections.RemoveAt(index);

        return chosenRef;
        //return string
    } 
}