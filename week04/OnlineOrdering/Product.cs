using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class Product
{
    //Attributes
    private string _prodName;
    private string _prodID;    
    private int _quantity;
    private double _price;
    
    //Constructor
    public Product(string name, string id, int quantity, double price)
    {
        _prodName = name;
        _prodID = id;
        _quantity = quantity;
        _price = price;
    }

    //Methods
    public double ProdCost()
    {
        //Calculate total cost of the product
        double cost = _price * _quantity;

        return cost;
    }

    public string PackingData()
    {
        return $"CODE: {_prodID}, PRODUCT: {_prodName}";
    }
}