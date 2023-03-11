using System;
namespace Develop04 {
    class Program
    {
        static void Main(string[] args)
        {
            BreathingActivity breathingActivityEx = new BreathingActivity("Breathing","Activity");
            ReflectingActivity reflectingActivityEx = new ReflectingActivity("R","A");
            Console.WriteLine(breathingActivityEx.GetActivityType());
            Console.WriteLine(reflectingActivityEx.GetActivityType());

            // Menu
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");
            Console.WriteLine("Select a choice from the menu: ");
            string userInput = "";
            userInput = Console.ReadLine();
            
            bool done = false;
            while (!done) {
                if (userInput == "1") {
                    BreathingActivity breathingActivity = new BreathingActivity("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
                    // Step 1: Display starting message
                    breathingActivity.DisplayStartingMessage();
                    // Step 2: Ask how many seconds
                    Console.Write("How long would you like the activity to last (in seconds)? ");
                    int _seconds = Int32.Parse(Console.ReadLine());
                    // Step 3: Start timer
                    DateTime startTime = DateTime.Now;
                    DateTime futureTime = startTime.AddSeconds(_seconds);

                    DateTime currentTime = DateTime.Now;
                    while (currentTime < futureTime)
                    {
                        Console.Write("Breate in...");
                        int num = 0;
                        while (num < 5) {
                            Console.Write("+");

                            Thread.Sleep(500);

                            Console.Write("\b \b"); // Erase the + character
                            Console.Write("-"); // Replace it with the - character
                            Thread.Sleep(500);
                            Console.Write("\b \b"); // Erase the + character

                            num ++;
                        }
                        Console.WriteLine();
                        Console.Write("Breathe out...");
                        num = 0;
                        while (num < 5) {
                            Console.Write("+");

                            Thread.Sleep(500);

                            
                            Console.Write("\b \b"); // Erase the + character
                            Console.Write("-"); // Replace it with the - character
                            Thread.Sleep(500);
                            Console.Write("\b \b"); // Erase the + character

                            num ++;
                        }
                        Console.WriteLine();
                        currentTime = DateTime.Now;
                    }
                    done = true;

                }
                else if (userInput == "2") {
                    ReflectingActivity reflectingActivity = new ReflectingActivity("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                }
                else if (userInput == "3") {
                    ListingActivity listingActivity = new ListingActivity("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                }
                else if (userInput == "4") {done = true;}
            }

            // abstact method example
            // Activity activity = new Activity();
        
        }
    }

}