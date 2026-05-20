using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


public class Scripture
{
    //Attributes
    private Reference _reference;
    private List<Word> _words;
    private List<string> _stringList; 

    //Constructor
    public Scripture(Reference reference, string scriptureText)
    {
        _reference = reference;
        _stringList = scriptureText.Split(' ').ToList();
        foreach (string s in _stringList)
        {
            Word wordObjt = new Word(s);
            _words.Add(wordObjt);
        }

    }

    //Methods
    public void HideRandomWords(int numberToHide)
    {
        //Select a random number of words to hide

    }

    public string GetDisplayText()
    {
        //return a string of the scripture in it's current state
    }

    public bool IsCompletelyHidden()
    {
        //Check is a word is hidden or not
    }
}