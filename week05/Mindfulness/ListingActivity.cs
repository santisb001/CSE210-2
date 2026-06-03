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
    /// public void GetPrompt()
    /// {
    ///     //not sure how to use this one
    /// }
    /// 
    /// 
    /// public GetListFromUser()
    /// {
    ///     //return List<string>
    /// }
    /// 
    /// 
}