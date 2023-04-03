using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Foundation4 World!");
        Console.WriteLine("Exercise Tracking");
        Console.WriteLine("Summary:");

        List<Activity> _activities = new List<Activity>();

        Running _ra = new Running("April 3rd, 2023", "Running", 20.00, 2.5);
        _activities.Add(_ra);

        Cycling _ca = new Cycling("April 1st, 2023", "Cycling", 120.00, 40.00);
        _activities.Add(_ca);

        Swimming _sa = new Swimming("March 31st, 2023", "Swimming", 30.00, 15.00);
        _activities.Add(_sa);

        Console.WriteLine();

        foreach (Activity a in _activities)
        {
            string _na = a.GetNameActivity();
            Console.WriteLine(_na.ToUpper());
            double distance = a.GetDistance();
            double speed = a.GetSpeed();
            double pace = a.GetPace();
            Console.WriteLine($"{a.GetDate()} - {a.GetNameActivity()} ({a.GetTime()} min) - Distance: {a.GetDistance()} km - Speed: {a.GetSpeed()} kph - Pace: {a.GetPace()} min per km");
            Console.WriteLine();
        }
    }
}