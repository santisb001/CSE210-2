using System;

class Program
{
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }

        static string PromptUserName()
        {
            Console.WriteLine("Please enter your name: ");
            string name = Console.ReadLine();

            return name;
        }

        static int PromptUserNumber()
        {
            Console.WriteLine("Please enter your favorite number: ");
            string userInput = Console.ReadLine();
            int number = int.Parse(userInput);

            return number;
        }

        static int SquareNumber(int num)
        {
            int square = num * num;

            return square;
        }

        static void DisplayResult(string name, int sqr)
        {
            Console.WriteLine($"{name}, the square of your number is {sqr}");
        }

    static void Main(string[] args)
    {
       DisplayWelcome();
       string name = PromptUserName();
       int number = PromptUserNumber();
       int squareNumber = SquareNumber(number);
       DisplayResult(name,squareNumber);
    }
}