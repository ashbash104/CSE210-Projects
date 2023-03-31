using System;

class Event
{
    public string _nameEvent;
    public string _typeEvent;
    public string _description;
    public string _address;
    public int _time;
    IList<string> _listEvent = new List<string>
    {
        " "," "
    };
    public Event(string nameEvent, string typeEvent, string description, int time)
    {
        _nameEvent = nameEvent;
        _typeEvent = typeEvent;
        _description = description;
        _time = time;

    }
    public void DisplayEvent()
    {
        Console.WriteLine($"Event: {_nameEvent}");
        Console.WriteLine($"Type: {_typeEvent}");
        Console.WriteLine($"Description: {_description}");
        Console.WriteLine($"Time: {_time} PM");
    }

}