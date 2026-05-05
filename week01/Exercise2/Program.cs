using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your grade: ");
        string userInput = Console.ReadLine();
        int grade = int.Parse(userInput);

        string letter = "";
        int sign = 0;

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
         letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else if (grade < 60)
        {
            letter = "F";
        }

        //Check the sign
        sign = grade % 10;

        if (sign < 4)
        {
            if (grade < 60)
            {
                Console.WriteLine($"Your grade is {letter}");
            }
            else
            {
                string negative = "-";
                Console.WriteLine($"Your grade is {letter}{negative}");   
            }            
        }
        else if (sign >= 7)
        {
            if (grade >=97)
            {
                Console.WriteLine($"Your grade is {letter}");
            }
            else
            {
                string positive = "+";
                Console.WriteLine($"Your grade is {letter}{positive}");   
            }
        }
        else
        {
            Console.WriteLine($"Your grade is {letter}");
        }

        //Check for a passing grade
        if (grade >= 70)
        {
            Console.WriteLine("Congratulations! You passed the test.");
        }
        else
        {
            Console.WriteLine("I know you will make it next time, keep trying!");
        }
    }
}