using System;
using System.Collections.Generic;

namespace Develop04 
{
    // parent class for breathing, reflecting, and listing activities
    // will hold the code which its children will use
    public abstract class Activity 
    {
        public string _activityName = "";
        public string _activityDescription = "";
        public int _activityPoints = 0;

        // public static int _duration = 0;
        // public static string _durationString;

        // Constructor function
        // Whatver you want the class to do right at the beginning, upon its creation,
        // you put inside the constructor. i.e. store the activity name & description
        // for later as global member variables
        public Activity (string activityName, string activityDescription) 
        {
            _activityName = activityName;
            _activityDescription = activityDescription;
        }

        public string GetActivityName () 
        {
            return _activityName;
        }

        // public void DisplayStartingMessage() 
        // {
        //     Console.WriteLine($"Welecome to the {_activityName}. {_activityDescription}");
        // }

        // public string PromptDuration() 
        // {
        //     Console.Write("How long would you like the activity to last? (In seconds) ");
        //     _duration = Int32.Parse(Console.ReadLine());
        //     _durationString = _duration.ToString();
        //     return _durationString;
        // }
        
        public abstract int GetPoints();
        // public abstract string GetUniqueString();

        public virtual string GetActivityType() 
        {
            return "Activity";
        }
        //public abstract bool StartTimer();

    }

} 