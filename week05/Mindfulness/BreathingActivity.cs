using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;

public class BreathingActivity : Activity
{
    //Attributes
    //none

    //Constructor
    public BreathingActivity(string start, string description) : base (start,description)
    {
        
    }

    //Methods
    public void Run()
    {
        //code the activity
        //This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.
        Console.WriteLine(GetStartMessage());
        Console.WriteLine("");
        
        Console.WriteLine(GetDescription());
        Console.WriteLine("");
        
        Console.WriteLine("How long, in seconds, would you like for your session to be?");
        string reponse = Console.ReadLine();
        _duration = Convert.ToInt32(reponse);
        //SetDuration(length);
        DateTime startTime = DateTime.Now;
        DateTime timeSpent = startTime.AddSeconds(_duration);

        while(DateTime.Now < timeSpent)
        {
            //Breath in
            Console.WriteLine("Breathe in...");
            for(int t = 5; t > 0; t--)
            {
                Console.Write(t);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
            //Breath out
            Console.WriteLine("Breathe out...");
            for(int t = 5; t > 0; t--)
            {
                Console.Write(t);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }

        }

        Console.WriteLine(GetEndMessage()); 

    }
}