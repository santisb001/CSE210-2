using System;
using System.Collections.Generic;

public class Resume
{
    //Attributes
    public string _name = "";
    public List<Job> _jobs = new List<Job>();

    //Methods
    public void AddJob(Job jobb)
    {
        _jobs.Add(jobb);
    }
    public void Display()
    {
       Console.WriteLine($"{_name}");
       foreach (Job thisJob in _jobs)
        {
            thisJob.Display();
        } 
    }

    
}