using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class ListingActivity : Activity
{
    //Attributes
    private List<string> _prompts;
    private int _count;

    //Constructor
    public ListingActivity(string start, string end, string description) : base (start,end,description)
    {
        _prompts = new List<string>();
        _count = 0;
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

    ///
    /// 
    public void GetPrompt()
    {
        /////not sure how to use this one
        ///Who are people that you appreciate?
        ///What are personal strengths of yours?
        ///Who are people that you have helped this week?
        ///When have you felt the Holy Ghost this month?
        ///Who are some of your personal heroes?
    }
     
    public List<string> GetListFromUser()
    {
    ///     //return List<string>
    }
 
}