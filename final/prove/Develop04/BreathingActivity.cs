using System;
using System.Collections.Generic;

public class BreathingActivity
{
    private string _activity;
    private string _text;
    private string _question;

    public int _seconds = 0;
    public string _secondsString;

    public BreathingActivity(string activity, string text)
    {
        _activity = activity;
        _text = text;
    }
    public void DisplayStartingMessage() 
        {
            Console.WriteLine($"Welecome to the {_activity}! {_text}");
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
        Console.WriteLine($"You have completed {_secondsString} seconds of the {_activity}.");
        Console.WriteLine();
        Console.WriteLine("Going back to the menu, please wait...");
    }

    public void Activity1()
    {
        Console.Write("How long would you like the activity to last (in seconds)? ");
        int _seconds = Int32.Parse(Console.ReadLine());
        _secondsString = _seconds.ToString();
         //breathingActivity.PromptDuration();

        // Step 3: Start timer
        //breathingActivity.StartTimer();
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_seconds);
        DateTime currentTime = DateTime.Now;
        while (currentTime < futureTime)
        {
            Console.Write("Breate in...");
            int num = 0;
            while (num < 5) 
            {
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
                while (num < 5) 
                {
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
    }

}



