using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class Address
{
    //Attributes
    private string _street;
    private string _city;
    private string _stateProvince;
    private string _country;
    private bool _inUSA;

    //Constructor
    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _stateProvince = state;
        _country = country;
        _inUSA = true;
    }

    //Methods
    public void OutsideTheUS()
    {
        _inUSA = false;
    }
    public bool InTheUS()
    {
        return _inUSA;
    }
    public string MakeAddress()
    {
        return $"{_street}, {_city}, {_stateProvince}, {_country}";
    }


    
}