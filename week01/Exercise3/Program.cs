using System;

class Program
{
    static void Main(string[] args)
    {
        int magicNumber = 7;
        string guess = "0";
        int numberGuessed = 0;

        while (true)
        {
           Console.WriteLine("What is the magic number? ");
           guess = Console.ReadLine();
           numberGuessed = int.Parse(guess);

           if (numberGuessed == magicNumber)
            {
                break;
            } 
        }
    }
}