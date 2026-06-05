using System;

class Program
{
    static void Main(string[] args)
    {
        //Breathing activity
        BreathingActivity breathingAct = new BreathingActivity("Breathing Activity","This activity will help you relax by walking you through breathing in and out slowly.\nClear your mind and focus on your breathing.");
        
        //Menu
        Console.WriteLine("Menu Options:");
        Console.WriteLine("    1. Start breathing activity \n    2. Start reflecting activity \n    3. Start listing activity \n    4. Quit");
        Console.WriteLine("Select a choice from the menu: ");
    }
}