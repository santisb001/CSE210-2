using System;

class Program
{
    static void Main(string[] args)
    {
        Reference referenceObj = new Reference("Exodus",20,2,3);
        string text = "2 I am the Lord thy God, which have brought thee out of the land of Egypt, out of the house of bondage 3 Thou shalt have no other gods before me";
        Scripture scriptureObj = new Scripture(referenceObj,text);

        //bool keepGoing = true;
        Console.WriteLine("Welcome to the Scripture Memorizer program!");
        Random random = new Random();
        Console.WriteLine(scriptureObj.GetDisplayText());

        while (true)
        {
            Console.WriteLine("Press Enter to start or type 'quit' to fisish the program");
            string answer = Console.ReadLine();

            if (answer.Trim().ToLower() == "quit")
            {
                Console.WriteLine("Ending...");
                break;
            }

            Console.Clear();   
        
            //Hide a random number of words
            int randInt = random.Next(1,10); 
            scriptureObj.HideRandomWords(randInt);

            //Print the current state of the scripture
            string currentState = scriptureObj.GetDisplayText();
            Console.WriteLine(currentState);
            
            //Check if all words are hidden
            bool cHidden = scriptureObj.IsCompletelyHidden();
            if (cHidden)
            {
                Console.WriteLine("Worderful work, may the Lord guide you in your path to achieve salvation!");
                break;
            }

            
        }
    }
}