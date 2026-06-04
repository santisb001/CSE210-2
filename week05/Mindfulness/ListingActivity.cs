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
    public ListingActivity(string start, string end, string description) : base (start,end,description)
    {
        _prompts = new List<string>();
        _count = 0;
        _promptsFile = "ListingPrompts.csv";
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

    public void GetPrompt()
    {
        /////not sure how to use this one
        ///if (_prompts.Count == 0)
        ///{
        ///    _prompts = File.ReadAllLines(_promptsFile).ToList();
        ///}
        ///
        ///int index = _random.Next(_prompts.Count);
        ///
        ///string chosenPrompt = _prompts[index];
        ///
        ///_prompts.RemoveAt(index);
        ///
        ///return chosenPrompt;
    }
     
    public List<string> GetListFromUser()
    {
    ///     
    /// Create a file with the responses of the user, then take that file and
    /// dump it into a List
    ///  then return it
    /// 
    /// //return List<string>
    }
 
}