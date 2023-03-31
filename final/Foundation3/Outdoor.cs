using System; 

class Outdoor : Event
{
    private string _weather;

    public Outdoor (string nameEvent, string typeEvent, string description, int time, string weather) : base(nameEvent, typeEvent, description, time)
    {
        _weather = weather;
    }
    public void Forecast()
    {
        Console.WriteLine($"Forecast: {_weather}");
    }
}