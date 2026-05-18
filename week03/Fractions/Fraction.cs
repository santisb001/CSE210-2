using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class Fraction
{
    //Attributes
    private int _numerator;
    private int _denominator;

    //Constructors
    public Fraction()
    {
        _numerator = 1;
        _denominator = 1;
    }
    public Fraction(int onlyTopNum)
    {
        _numerator = onlyTopNum;
        _denominator = 1;
    }
    public Fraction (int top, int bottom)
    {
        _numerator = top;
        _denominator = bottom;
    }


    //Getters 
    public int GetNumerator()
    {
        return _numerator;
    } 
     
    public int GetDenominator()
    {
        return _denominator;
    } 

     
    //Setters
    public void SetNumerator(int newNumerator)
    {
        _numerator = newNumerator;
    } 

    public void SetDenominator(int newDenominator)
    {
        _denominator = newDenominator;
    } 


    //Methods
    public string ReturnFractionString()
    {
        return _numerator + "/" + _denominator;
    }

    public double ReturnDecimalValue()
    {
        double decimalValue = (double)_numerator / (double)_denominator;

        return decimalValue;
    }


}