using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        List<int> Numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        
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
                Numbers.Add(number);    
            }
        }

        //Calculate the largest and smallest positive ones
        int largest = int.MinValue;
        int smallestPositive = int.MaxValue;

        //sum the total
        int sum = 0;
        foreach (int num in Numbers)
        {
            sum += num;
            if (num > largest)
            {
                largest = num;
            }
            if (num < smallestPositive && num > 0)
            {
                smallestPositive = num;
            }
        }

        //Sort the list from small to large
        Numbers.Sort();

        //lenght of the list
        int lenghtOfList = Numbers.Count;
        double avrg = (double)sum / lenghtOfList;

        //Display the results
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {avrg}");
        Console.WriteLine($"The largest number is: {largest}");
        Console.WriteLine($"The smallest positive number is: {smallestPositive}");
        Console.WriteLine($"The sorted list is: ");
        foreach (int num in Numbers)
        {
            Console.WriteLine(num);
        }
    }
}