using System;
using System.Collections.Generic;

public class BreathingActivity
{

    private string _activity;
    private string _text;
    private string _question;

    public BreathingActivity(string activity, string text, string question)
    {
        _activity = activity;
        _text = text;
        _question = question;
    }
    public string GetNameActivity()
    {
        return $"Welcome to the {_activity}.";
    }

    public string GetDescription()
    {
        return $"Description: {_text}";
    }
    public string GetQuestion()
    {
        return $"{_question} in the {_activity} session?";

    }
    public string GetActivityIntro()
    {
        return $"{_activity} session is starting. Get ready...";
    }
    public void AnimationMain()
    {
        List<string> animation0 = new List<string>();
        animation0.Add("|");
        animation0.Add("/");
        animation0.Add("-");
        animation0.Add("\\");
        animation0.Add("|");

        foreach (string b in animation0)
        {
            Console.Write(b);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }

        Console.WriteLine();
    }
    public void AnimationNumbers()
    {
        List<string> animationN = new List<string>();
        animationN.Add("5");
        animationN.Add("4");
        animationN.Add("3");
        animationN.Add("2");
        animationN.Add("1");

        foreach (string a in animationN)
        {
            Console.Write(a);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
    public void DisplayLastMessageActivity()
    {
        Console.WriteLine();
        Console.WriteLine("Well Done!");
        Console.WriteLine();
        Console.WriteLine($"You have completed 10 seconds of the {_activity}.");
        Console.WriteLine();
        Console.WriteLine("Going back to the menu, please wait...");
    }

    public void Activity1()
    {
        Console.WriteLine("Breathe in...");
        AnimationNumbers();

        Console.WriteLine();

        Console.WriteLine("Breathe out...");
        AnimationNumbers();
    }

}


