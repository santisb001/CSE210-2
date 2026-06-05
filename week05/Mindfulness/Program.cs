using System;

class Program
{
    static void Main(string[] args)
    {
        //Breathing activity
        BreathingActivity breathingAct = new BreathingActivity("Breathing Activity","This activity will help you relax by walking you through breathing in and out slowly.\nClear your mind and focus on your breathing.");
        
        ///     FINISH THIS     ///
        //Reflecting activity
        ReflectingActivity reflectingAct = new ReflectingActivity();
        ///
        /// 
        /// 
        /// 
        
        ///     FINISH THIS     ///
        //Listing activity
        ListingActivity listingAct = new ListingActivity();
        ///
        /// 
        /// 
        /// 

        while(true)
        {
            //Menu
            Console.WriteLine("Menu Options:");
            Console.WriteLine("    1. Start breathing activity \n    2. Start reflecting activity \n    3. Start listing activity \n    4. Quit");
            Console.WriteLine("Select a choice from the menu: ");
            string choice = Console.ReadLine();
            int chosen = Convert.ToInt32(choice);

            if(chosen == 1)
            {
                breathingAct.Run();
            }
            else if(chosen == 2)
            {
                reflectingAct.Run();
            }
            else if(chosen == 3)
            {
                listingAct.Run();
            }
            else if(chosen == 2)
            {
                break;
            }
        }
        Console.WriteLine("Thank you for using the Mindfulness App!!");
        //test
        //breathingAct.Run();
    }
}