using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomNum = new Random();
        string answer = "yes";

        while (answer == "yes")
        {
            
            int magicNumber = randomNum.Next(1, 100);
            string guess = "0";
            int numberGuessed = 0;
            int tries = 0;
            while (true)
            {
               Console.WriteLine("What is the magic number? ");
               guess = Console.ReadLine();
               numberGuessed = int.Parse(guess);
               tries += 1;

                if (numberGuessed < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (numberGuessed > magicNumber)
                {
                    Console.WriteLine("Lower");
                }

                if (numberGuessed == magicNumber)
                {
                    Console.WriteLine("You guessed it!");
                    Console.WriteLine($"Number of tries: {tries}");
                    break;
                } 
            }

            Console.WriteLine("Do you want to play again?");
            answer = Console.ReadLine().ToLower();
            if (answer == "no")
            {
                break;
            }
        }
    }
}