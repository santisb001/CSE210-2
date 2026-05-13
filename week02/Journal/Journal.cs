using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class Journal
{
    //Atributes
    public List<Entry> _entryList = new List<Entry>();
    public PromptGenerator _promptGenerator = new PromptGenerator();

    //Methods
    public void AddEntry()
    {
        //Add a new Entry objt
        Entry newEntry = new Entry(_promptGenerator);

        Console.WriteLine($"{newEntry._promptText}");
        newEntry._inputText = Console.ReadLine();

        _entryList.Add(newEntry);
    }

    public void LoadFromFile()
    {
        //Load the Journal from a file
        Console.WriteLine("Enter the name of the Journal: ");
        string fileName = Console.ReadLine();

        string[] lines = File.ReadAllLines(fileName);

        Entry newEntry = new Entry(_promptGenerator);

        foreach (string L in lines)
        {
            Console.WriteLine(L);
        }
        
        
    }
    public void SaveToFile()
    {
        //Save the Journal into a file
        Console.WriteLine("Enter a name for the Journal: ");
        string fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Entry E in _entryList)
            {
                //Format the string again
                outputFile.WriteLine($"{E._date} -- {E._promptText}: {E._inputText}");
            }
                
        }
        
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