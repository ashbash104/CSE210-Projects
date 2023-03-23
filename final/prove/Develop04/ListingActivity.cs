using System;

using System.Collections.Generic;

public class ListingActivity : BreathingActivity
{
    public string _activity3;
    private int seconds = 0;
    public ListingActivity(string activity, string text) : base(activity, text)
    {

    }
    public void Activity3()
    {
        Random _random = new Random();

        List<string> _questionsList = new List<string>
        {
            "List things you love about yourself.",
            "List what you are grateful for.",
            "Where do you feel most comfortable?",
            "What are things you can do to make people feel seen or appreciated?",
            "Who are some of your role models?",
        };
        //Clear the console for the activity
        Console.Clear();
        // Console.Write("How long would you like the activity to last (in seconds)? ");
        // int seconds = Int32.Parse(Console.ReadLine());
        // _secondsString = seconds.ToString();
        Console.WriteLine("List as many responses you can to the following prompt (Type 'quit' to exit):");

    //    // Step 3: Start timer
    //     DateTime startTime = DateTime.Now;
    //     DateTime futureTime = startTime.AddSeconds(seconds);
    //     DateTime currentTime = DateTime.Now;
    //     while (currentTime < futureTime)
    //     {

            int index = _random.Next(0, 4);
            Console.WriteLine(_questionsList[index]);
            string _entryUser = Console.ReadLine();

            List<string> entriesUser = new List<string>
            {

            };

            do
            {
                entriesUser.Add(_entryUser);
                _entryUser = Console.ReadLine();
                Console.WriteLine();
                // currentTime = DateTime.Now; 
            }
            //User quits the program
            while (_entryUser != "quit");

            Console.WriteLine($"You listed {entriesUser.Count} items!");
        }
    public void DisplayLastMessageActivity3()
    {
        string activity = _activity3;
        Console.WriteLine();
        Console.WriteLine("Well Done!");
        Console.WriteLine();
        // Console.WriteLine($"You have completed {_secondsString} seconds of the Listing Activity.");
        // Console.WriteLine();
        Console.WriteLine("Going back to the menu, please wait...");
    }

}
