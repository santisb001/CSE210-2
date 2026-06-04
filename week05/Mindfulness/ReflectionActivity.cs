using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class ReflectionActivity : Activity
{
    //Attributes
    private List<string> _prompts;
    private List<string> _reflections;
    Random _random;

    //Constructor
    public ReflectionActivity(string start, string end, string description) : base (start,end,description)
    {
        _prompts = new List<string>();
        _reflections = new List<string>();
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
        ///
        /// 
        ///Think of a time when you stood up for someone else.
        ///Think of a time when you did something really difficult.
        ///Think of a time when you helped someone in need.
        ///Think of a time when you did something truly selfless.   
        /// 
        /// 
        //return string
    }

    public string GetReflection()
    {
        //Select and return a random Reflection
        ///
        ///Why was this experience meaningful to you?
        ///Have you ever done anything like this before?
        ///How did you get started?
        ///How did you feel when it was complete?
        ///What made this time different than other times when you were not as successful?
        ///What is your favorite thing about this experience?
        ///What could you learn from this experience that applies to other situations?
        ///What did you learn about yourself through this experience?
        ///How can you keep this experience in mind in the future?
        ///
        //return string
    } 
}