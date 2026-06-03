using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class BreathingActivity : Activity
{
    //Attributes
    //none

    //Constructor
    public BreathingActivity(string start, string end, string description) : base (start,end,description)
    {
        
    }

    //Methods
    public void Run()
    {
        //code the activity
        //This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.
        Console.WriteLine("Welcome to the Breathing Activity");
        Console.WriteLine("");
        
        Console.WriteLine($"{GetStartMessage()}");
        Console.WriteLine("");
        
        Console.WriteLine("How long, in seconds, would you like for your session to be?");
        int length = Console.ReadLine();
        SetDuration(length);

        ///
        /// Finish latter with the loop
        /// 
        ///Console.WriteLine($"{GetEndMessage}"); 

    }
}