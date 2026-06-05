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
        Console.WriteLine(GetStartMessage());
        Console.WriteLine("");
        
        //This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.
        Console.WriteLine(GetDescription());
        Console.WriteLine("");
        
        Console.WriteLine("How long, in seconds, would you like for your session to be?");
        string reponse = Console.ReadLine();
        _duration = Convert.ToInt32(reponse);

        //DateTime
        DateTime startTime = DateTime.Now;
        DateTime timeSpent = startTime.AddSeconds(_duration);
        
        //Clear the console
        Console.Clear();
        Console.WriteLine("Get Ready...\n\n");
        while (DateTime.Now < startTime.AddSeconds(5))
        {
            GetSpinner();
        }
        //Show random prompt
        string chosenPrompt = GetPrompt();
        Console.WriteLine(chosenPrompt);
        Console.WriteLine("When you have something in mind, press enter to continue.");
        string answer = Console.ReadLine();
        
        
        
        while (DateTime.Now < timeSpent)
        {
            string reflection = GetReflection();
            Console.WriteLine(reflection);
            Thread.Sleep(7000);    
        }
        
        Console.WriteLine(GetEndMessage());
    }
    
    public string GetPrompt()
    {
        //Select and return a random prompt
        if (_prompts.Count == 0)
        {
            _prompts = File.ReadAllLines(_promptsFile).ToList();
        }

        int index = _random.Next(_prompts.Count);

        string chosenPrompt = $" --- {_prompts[index]} ---\n";

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