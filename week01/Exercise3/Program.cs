using System;

class Program
{
    static void Main(string[] args)
    {
        int magicNumber = 7;
        string guess = "0";
        int numberGuessed = 0;

        while (numberGuessed != magicNumber);
        {
            Console.WriteLine("What is the magic number? ");
            guess = Console.ReadLine();
            numberGuessed = int.Parse(guess);
            Console.WriteLine($"{numberGuessed}");
        } 

        
    }
}