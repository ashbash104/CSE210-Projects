using System;

class Cycling : Activity
{
    private double _speed;
    public Cycling(string date, string nameActivity, double time, double speed) : base(date, nameActivity, time)
    {
        _speed = speed;
    }
    public override double GetDistance()
    {
        return _speed * _time;
    }
    public override double GetSpeed()
    {
        return _speed;
    }
    public override double GetPace()
    {
        return 60 / _speed;
    }
}