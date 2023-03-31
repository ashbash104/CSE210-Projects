using System;

class Lecture : Event
{
    public string _speaker;
    public int _capacity;
    public Lecture(string nameEvent,string typeEvent, string description, int time, string speaker, int capacity) : base( nameEvent, typeEvent, description, time)
    {
        _speaker = speaker;
        _capacity = capacity;
    }
    public void GetSpeaker()
    {
        Console.WriteLine($"Speaker: {_speaker}");
    }
    public int GetCapacity()
    {
        return _capacity;
    }
}