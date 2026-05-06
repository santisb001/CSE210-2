using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        List<int> Numbers = new List<int>();
        
        while (true)
        {
            Console.WriteLine("Enter a number: ");
            string useInput = Console.ReadLine();
            int number = int.Parse(useInput);

            if (number == 0)
            {
                break;
            }
            else
            {
                Numbers.add(number);    
            }
        }

        //Calculate the largest one
        int largest = 0;

        //sum the total
        int sum = 0;
        foreach (int num in Numbers)
        {
            sum += num;
            if (num > largest)
            {
                largest = num;
            }
        }

        //lenght of the list
        int lenghtOfList = Numbers.Count();
        double avrg = sum / lenghtOfList;

        //Display the results
        Console.WriteLine($"The sum is {sum}");
        Console.WriteLine($"The average is: {avrg}");
        Console.WriteLine($"The largest number is {largest}");
    }
}