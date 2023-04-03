using System;

class Running : Activity
{
    private double _distance;
    public Running(string date, string nameActivity, double time, double distance) : base(date, nameActivity, time)
    {
        _distance = distance;
    }
    public override double GetDistance()
    {
        return _distance;
    }
    public override double GetSpeed()
    {
        return (_distance / _time) * 60;
    }
    public override double GetPace()
    {
        return 60 / GetSpeed();
    }
}