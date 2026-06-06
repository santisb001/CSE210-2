using System;

class Program
{
    static void Main(string[] args)
    {
        //Breathing activity
        BreathingActivity breathingAct = new BreathingActivity("Breathing Activity","This activity will help you relax by walking you through breathing in and out slowly.\nClear your mind and focus on your breathing.");

        //Reflecting activity
        ReflectionActivity reflectingAct = new ReflectionActivity("Reflection Activity","This activity will help you reflect on times in your life when you have shown strength and resilience.\nThis will help you recognize the power you have and how you can use it in other aspects of your life.");

        //Listing activity
        ListingActivity listingAct = new ListingActivity("Listing Activity","This activity will help you reflect on the good things in your life\nby having you list as many things as you can in a certain area.");

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
                DateTime startTime = DateTime.Now;
                DateTime timeSpent = startTime.AddSeconds(3);

                while(DateTime.Now < timeSpent)
                {
                    breathingAct.GetSpinner();
                }
            }
            else if(chosen == 2)
            {
                reflectingAct.Run();
                DateTime startTime = DateTime.Now;
                DateTime timeSpent = startTime.AddSeconds(3);
                while(DateTime.Now < timeSpent)
                {
                    breathingAct.GetSpinner();
                }
            }
            else if(chosen == 3)
            {
                listingAct.Run();
                DateTime startTime = DateTime.Now;
                DateTime timeSpent = startTime.AddSeconds(3);
                while(DateTime.Now < timeSpent)
                {
                    breathingAct.GetSpinner();
                }
            }
            else if(chosen == 4)
            {
                DateTime startTime = DateTime.Now;
                DateTime timeSpent = startTime.AddSeconds(3);
                while(DateTime.Now < timeSpent)
                {
                    breathingAct.GetSpinner();
                }
                break;
            }
        }
        Console.WriteLine("Thank you for using the Mindfulness App!!");
        //test
        //breathingAct.Run();
    }
}