using System;

using System.Collections.Generic;

public class ListingActivity : BreathingActivity
{
    public ListingActivity(string activity, string text, string question) : base(activity, text, question)
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

        Console.WriteLine("List as many responses you can to the following prompt (Type 'quit' to exit):");

        int index = _random.Next(0, 5);
        Console.WriteLine(_questionsList[index]);
        string _entryUser = Console.ReadLine();

        List<string> entriesUser = new List<string>
        {

        };

        do
        {
            entriesUser.Add(_entryUser);
            _entryUser = Console.ReadLine();
        } while (_entryUser != "quit");

        Console.WriteLine($"You listed {entriesUser.Count} items!");









    }

}
