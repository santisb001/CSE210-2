using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class Word
{
    //Attributes
    private string _word;
    private string _hiddenContent;
    private bool _isHidden;
    


    //Constructor
    public Word (string word)
    {
        _word = word;
        _hiddenContent = new string ('_', word.Length);
        _isHidden = false;
        
    }

    //Methods
    public void Hide()
    {
        //Show the hidden word  
        Console.WriteLine($"{_hiddenContent}");
    }

    public void Show()
    {
        //Show the word
        Console.WriteLine($"{_word}");
    }

    public bool IsHidden()
    {
        //return that it is, in fact, hidden
        return _isHidden = true;
    }

    public string ReturnDisplayText()
    {
        //return a string
        if (_isHidden == false)
        {
            return _word;
        }
        else
        {
            return _hiddenContent;
        }
    }
}