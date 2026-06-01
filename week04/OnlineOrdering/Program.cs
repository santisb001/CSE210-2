using System;

class Program
{
    static void Main(string[] args)
    {
        //First Order
        Address firstAddress = new Address("Wallaby Street 42","Sidney","New South Wales","Australia");
        //Make it outside the US
        firstAddress.OutsideTheUS();
        
        Customer firstCustomer = new Customer("P. Sherman", firstAddress);
        Order firstOrder = new Order(firstCustomer);

        
        //Add products
        firstOrder.AddProduct("Turbo Fan","Q742RT-y",23,4);
        firstOrder.AddProduct("French Wrenches","P982MK-z",15,10);
        firstOrder.AddProduct("Generator","E556KP-t",70,2);
        firstOrder.AddProduct("Gas pump","F201LJ-u",15,1);

        string firstShippingLabel = firstOrder.ShippingLabel();
        Console.WriteLine("ORDER 1 ");
        Console.WriteLine($"{firstShippingLabel}");
        Console.WriteLine("THIS PACKAGE CONTAINS: ");
        Console.WriteLine(firstOrder.PackingLabel());
        Console.WriteLine($"Total cost: ${firstOrder.CalculateTotalPrice()}");


        //Second Order
        Address secondAddress = new Address("Forest Park Ave","St. Louis","Missouri","USA");
        Customer secondCustomer = new Customer("Matias Larroque", secondAddress);
        Order secondOrder = new Order(secondCustomer);
        //Add products
        secondOrder.AddProduct("Peanut butter","MK428P-a",3,25);
        secondOrder.AddProduct("Butter cream","LQ321O-p",7,39);
        secondOrder.AddProduct("Wooden spoon","RP112M-r",14,2);
        secondOrder.AddProduct("Cookies","FN333R-u",2,32);

        string secondShippingLabel = secondOrder.ShippingLabel();
        Console.WriteLine("ORDER 2 ");
        Console.WriteLine($"{secondShippingLabel}");
        Console.WriteLine("THIS PACKAGE CONTAINS: ");
        Console.WriteLine(secondOrder.PackingLabel());
        Console.WriteLine($"Total cost: ${secondOrder.CalculateTotalPrice()}");
        
        
        
        

    
    }
}