using System;

class Swimming : Activity
{
    private double _laps;
    public Swimming(string date, string nameActivity, double time, double laps) : base(date, nameActivity, time)
    {
        _laps = laps;
    }
    public override double GetDistance()
    {
        return _laps * 50 / 1000;
    }
    public override double GetSpeed()
    {
        return (GetDistance() / _time) * 60;
    }
    public override double GetPace()
    {
        return 60 / GetSpeed();
    }
}