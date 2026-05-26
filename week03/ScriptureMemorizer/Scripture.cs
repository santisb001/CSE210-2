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
    private List<int> _indexes;
    private Random _randomNum;
        

    //Constructor
    public Scripture(Reference reference, string scriptureText)
    {
        _words = new List<Word>();
        
        _reference = reference;

        _stringList = scriptureText.Split(' ').ToList();
        foreach (string s in _stringList)
        {
            Word wordObjt = new Word(s);
            _words.Add(wordObjt);
        }

        _randomNum = new Random();

        _indexes = new List<int>();
        for (int i = 0; i < _words.Count; i++)
        {
            _indexes.Add(i);
        }
    }

    //Methods
    public void HideRandomWords(int numberToHide)
    {
        
        //Select a random number of words to hide
        for (int i = 0; i < numberToHide; i++)
        {
            if (_indexes.Count == 0)
            {
                break;
            }
            int randInt = _randomNum.Next(0,_indexes.Count);
            int wordIndex = _indexes[randInt];

            _words[wordIndex].Hide();
            _indexes.RemoveAt(randInt);   
        }
         
        //for (int i = 0; i < numberToHide; i++)
        //{
        //    _words[index].Hide();
        //}
    }

    public string GetDisplayText()
    {
        //return a string of the scripture in it's current state
        string refVar = _reference.ReturnReference();
        string display = " ";
        foreach (Word w in _words )
        {
            display += " " + w.GetDisplayText();
        }
        return refVar + display.Trim();
        
    }

    public bool IsCompletelyHidden()
    {
        //Check if a word is hidden or not
        foreach (Word w in _words)
        {
            if (!w.IsHidden())
            {
                return false;
            }
        }
        return true;
    } 
}
