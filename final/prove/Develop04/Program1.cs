using System;
using System.Collections.Generic;

public class Program
{
    static void Main(string[] args)
    {
        
             //Console.WriteLine(breathingActivity.GetActivityType());
            //Console.WriteLine(reflectingActivity.GetActivityType());

            //Menu
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");
            Console.WriteLine("Select a choice from the menu: ");
            string userInput = "";
            userInput = Console.ReadLine();
            
            
            bool done = false;
            while (!done) 
            {
                if (userInput == "1") 
                {
                    Console.Clear();
                    BreathingActivity breathingActivity = new BreathingActivity("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
                    // Step 1: Display starting message
                    breathingActivity.DisplayStartingMessage();

                    //Step 2: Run Breathing Activity/ Activity 1
                    breathingActivity.Activity1();

                    //End of activity message and animation
                    breathingActivity.DisplayLastMessageActivity();
                    breathingActivity.AnimationMain();

                    //done = true;
                }

                else if (userInput == "2") {
                    ReflectingActivity reflectingActivity = new ReflectingActivity("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                    reflectingActivity.Activity2();
                    reflectingActivity.DisplayLastMessageActivity2();
                    //done = true;
                }
                else if (userInput == "3") {
                    ListingActivity listingActivity = new ListingActivity("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                    listingActivity.Activity3();
                    listingActivity.DisplayLastMessageActivity3();
                    //done = true;
                }
                else if (userInput == "4") {done = true;}
            }

            // abstact method example
            // Activity activity = new Activity();
        
    }
}
