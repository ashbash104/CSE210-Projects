using System;

using System.Collections.Generic;

public class ReflectingActivity : BreathingActivity
{
        public ReflectingActivity(string activity, string text, string question) : base(activity, text, question)
    {

    }
    public void Activity2()
    {

        Random _random = new Random();

        List<string> _thinker = new List<string>
        {
            "Visualize the kind of person you want to be, in detail.",
            "If you could tell your younger self something, what would you say?",
            "What is one thing you did to day to make a positive difference?",
            "What emotions did you feel today and how did that affect you?",

        };

        Console.WriteLine("Consider the following prompt:");

        int index = _random.Next(0, 4);
        Console.WriteLine(_thinker[index]);

        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();

        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");

        AnimationNumbers();
        
        Console.Clear();

        List<string> _questions = new List<string>
        {
            "Why was this experience meaningful to you? ",
            "Have you ever done anything like this before? ",
            "How did you get started? ",
            "How did you feel when it was complete? ",
            "What made this time different than other times when you were not as successful? ",
            "What is your favorite thing about this experience? ",
            "What could you learn from this experience that applies to other situations? ",
            "What did you learn about yourself through this experience? ",
            "How can you keep this experience in mind in the future? ",
        };

        List<string> animationQRA = new List<string>();
            animationQRA.Add("|");
            animationQRA.Add("/");
            animationQRA.Add("-");
            animationQRA.Add("\\");
            animationQRA.Add("|");
            animationQRA.Add("/");
            animationQRA.Add("-");
            animationQRA.Add("\\");
            animationQRA.Add("|");
            animationQRA.Add("/");
            animationQRA.Add("-");
            animationQRA.Add("\\");
            animationQRA.Add("|");
            animationQRA.Add("/");
            animationQRA.Add("-");

        foreach (string a in _questions)
        {
            int index2 = _random.Next(0, 9);
            Console.Write(_questions[index2]);

            foreach (string b in animationQRA)
            {
                Console.Write(b);
                Thread.Sleep(1000);
                Console.Write("\b \b");       
            }
            
            Console.WriteLine();
        }

    }

}
