using System;

public abstract class Activity
{
    protected string _date;
    protected double _time;
    protected string _nameActivity;
    public Activity(string date, string nameActivity, double time)
    {
        _date = date;
        _nameActivity = nameActivity;
        _time = time;
    }
    public string GetNameActivity()
    {
        return _nameActivity;
    }
    public string GetDate()
    {
        return _date;
    }
    public double GetTime()
    {
        return _time;
    }
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();
}
