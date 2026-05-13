using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class Journal
{
    //Atributes
    public List<Entry> _entryList = new List<Entry>();

    //Methods
    public void AddEntry()
    {
        //Add a new Entry objt
        Entry newEntry = new Entry();

        Console.WriteLine($"{newEntry._promptText}");
        newEntry._inputText = Console.ReadLine();

        _entryList.Add(newEntry);
    }

    public void LoadFromFile(string fileName)
    {
        //Load the Journal from a file
        //
        //List<string> JournalList = new List<string>();
        //JournalList = File.ReadAllLines(fileName).ToList();
        //foreach (string l in JournalList)
        //{
        //    
        //}
        //
        
    }
    public void SaveToFile(string fileName)
    {
        //Save the Journal into a file
        
    }

    public void DisplayAllEntries()
    {
        //Display all the Entry class objects
        Console.WriteLine();
        Console.WriteLine("Journal entries:");

        foreach (Entry E in _entryList)
        {
            E.DisplayEntry();
        }
    }

}