using System;

class Program
{
    static void Main(string[] args)
    {
        //Write the program once you finish the rest
        Console.WriteLine("Welcome to the Journal Program!");
        Console.WriteLine("Please select one of the following choices: ");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        
        Console.WriteLine("What would you like to do?");
        string choice = Console.ReadLine();

        Journal mainJournal = new Journal();

        if (choice == "1")
        {
            mainJournal.AddEntry();
        }
        else if (choice == "2")
        {
            mainJournal.DisplayAllEntries();
        }
        else if (choice == "3")
        {
            mainJournal.LoadFromFile("ENTER A NAME FOR THE FILE");
        }
        else if (choice == "4")
        {
            mainJournal.SaveToFile("ENTER A NAME FOR THE FILE");
        }
        else if (choice == "5")
        {
            break;
        }
    }
}