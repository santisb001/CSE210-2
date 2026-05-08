using System;
using System.Collections.Generic;

public class Journal
{
    //Atributes
    public List<Entry> _entryList = new List<Entry>();

    //Methods
    public void AddEntry(Entry newEntry)
    {
        //Add a new Entry objt
        _entryList.Add(newEntry);
    }

    public void LoadToFile(string fileName)
    {
        //Load the Journal from a file
    }
    public void SaveToFile(string fileName)
    {
        //Save the Journal into a file
    }

    public void DisplayAllEntries()
    {
        //Display all the Entry class objects
        foreach (Entry E in _entryList)
        {
            E.DisplayEntry();
        }
    }

}