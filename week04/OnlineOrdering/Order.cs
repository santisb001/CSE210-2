using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class Order
{
    //Attributes
    private List<Product> _products;
    private Customer _customer;
    private bool _inUSA;
    

    //Constructor
    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
        _inUSA = _customer.InsideTheUSA();
    }

    //Methods
    public void AddProduct(string nameProd, string ID, int Q, double price)
    {
        Product newProduct = new Product(nameProd, ID, Q, price);
        _products.Add(newProduct);

    }

    public string ShippingLabel()
    {
        //return a string with the name and address of the customer
        return _customer.ReturnCustomer();
    }

    public string PackingLabel()
    {
        //return a string with the name and ID of each product in the order
        string label = "";

        foreach(Product P in _products)
        {
            label += P.PackingData() + "\n";
        }

        return label;
    }

    public double CalculateTotalPrice()
    {
        double totalPrice = 0;

        foreach(Product P in  _products)
        {
            totalPrice += P.ProdCost();
        }


        totalPrice += _inUSA ? 5 : 35;
        //if (_inUSA == false)
        //{
        //    _totalPrice += 35;
        //}
        //else
        //{
        //    _totalPrice += 5;
        //}

        return totalPrice;
    }

}