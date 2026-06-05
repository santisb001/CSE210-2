using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class ListingActivity : Activity
{
    //Attributes
    private List<string> _prompts;
    private int _count;
    private string _promptsFile;

    //Constructor
    public ListingActivity(string start, string description) : base (start,description)
    {
        _prompts = new List<string>();
        _count = 0;
        _promptsFile = "ListingPrompts.csv";
    }

    //Methods
    public void Run()
    {
        //code the execution of the class
        Console.WriteLine(GetStartMessage());
        Console.WriteLine("");
        
        //This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.
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
        while (DateTime.Now < startTime.AddSeconds(3))
        {
            GetSpinner();
        }

        //Random prompt
        Console.WriteLine(GetPrompt());

        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine("You may begin in:");

        ///
        ///         FINISH THIS         ///
        ///         FINISH THIS         ///
        ///         FINISH THIS         ///
        /// 

    
        Console.WriteLine(GetEndMessage());
    }

    public string GetPrompt()
    {
        //not sure how to use this one
        if (_prompts.Count == 0)
        {
            _prompts = File.ReadAllLines(_promptsFile).ToList();
        }
        
        int index = _random.Next(_prompts.Count);
        
        string chosenPrompt = $" --- {_prompts[index]} ---\n";
        
        _prompts.RemoveAt(index);
        
        return chosenPrompt;
    }
     
    public List<string> GetListFromUser(string answer)
    {
        answer
    /// 
    /// Create a file with the responses of the user, then take that file and
    /// dump it into a List
    /// then return it
    /// 
        //return List<string>;
    }
 
}