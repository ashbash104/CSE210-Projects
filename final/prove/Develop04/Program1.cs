using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        int firstChoice = 0;

        do
        {

            Console.WriteLine("Menu Options: ");

            //Creates the List
            List<string> menuList = new List<string>()
            {
            "1. Start Breathing Activity",
            "2. Start Reflecting Activity",
            "3. Start Listing Activity",
            "4. Quit"
            };

            //Displays the list in order
            for (int i = 0; i < menuList.Count; i++)
                Console.WriteLine(menuList[i]);

            //Take the input of the user
            Console.WriteLine("Select a choice from the menu: ");
            string userInput = Console.ReadLine();
            firstChoice = int.Parse(userInput);

            if (firstChoice == 1)
            {

                Console.Clear();
                BreathingActivity act1 = new BreathingActivity
                (
                    "Breathing Activity",
                    "This activity will help you relax by walking through breathing in and out slowly. Clear your Mind and focus on your breathing.",
                    "How long, in seconds, would you like"

                );
                Console.WriteLine(act1.GetNameActivity());
                Console.WriteLine();
                Console.WriteLine(act1.GetDescription());
                Console.WriteLine();
                Console.WriteLine(act1.GetQuestion());
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine(act1.GetActivityIntro());
                act1.AnimationMain();
                act1.Activity1();
                act1.DisplayLastMessageActivity();
                act1.AnimationMain();
                Console.Clear();
                

            }

            else if (firstChoice == 2)
            {
                Console.Clear();
                ReflectingActivity act2 = new ReflectingActivity
                (
                    "Reflecting Activity",
                    "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how yu can use it in other aspects of your life.",
                    "How long, in seconds, would you like"
                );
                Console.WriteLine(act2.GetNameActivity());
                Console.WriteLine();
                Console.WriteLine(act2.GetDescription());
                Console.WriteLine();
                Console.WriteLine(act2.GetQuestion());
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine(act2.GetActivityIntro());
                act2.AnimationMain();
                Console.Clear();
                act2.Activity2();
                act2.DisplayLastMessageActivity();
                act2.AnimationMain();
                Console.Clear();

            }


            else if (firstChoice == 3)
            {
                Console.Clear();
                ListingActivity act3 = new ListingActivity
                (
                    "Listing Activity",
                    "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how yu can use it in other aspects of your life.",
                    "How long, in seconds, would you like"
                );
                Console.WriteLine(act3.GetNameActivity());
                Console.WriteLine();
                Console.WriteLine(act3.GetDescription());
                Console.WriteLine();
                Console.WriteLine(act3.GetQuestion());
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine(act3.GetActivityIntro());
                act3.AnimationMain();
                act3.Activity3();
                act3.DisplayLastMessageActivity();
                act3.AnimationMain();
                Console.Clear();

            }

            else
            {
                Console.WriteLine("Thanks for using the Mindfulness Program! See you soon!");
            }


        } while (firstChoice != 4);








    }
}