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
    }

    public void PackingLabel()
    {
        //return a string with the name and ID of each product in the order
    }

}