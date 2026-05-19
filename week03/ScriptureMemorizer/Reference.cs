using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class Reference
{
    //Attributes
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    //Constructor
    public Reference (string bookProvided, int chProvided, int verseProvided)
    {
        _book = bookProvided;
        _chapter = chProvided;
        _verse = verseProvided;
        _endVerse = 0;
    }
    public Reference (string bookProvided, int chProvided, int verseProvided, int endVerseProvided)
    {
        _book = bookProvided;
        _chapter = chProvided;
        _verse = verseProvided;
        _endVerse = endVerseProvided;
    }

    //Methods
    public string ReturnReference()
    {
        if (_endVerse == 0)
        {
            return _book + " " + _chapter + ": " + _verse;    
        }
        else
        {
            return _book + " " + _chapter + ": " + _verse + "-" + _endVerse;
        }
    }

}