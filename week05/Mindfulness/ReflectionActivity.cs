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
        //return string
    }

    public string GetReflection()
    {
        //Select and return a random Reflection
        //return string
    } 
}