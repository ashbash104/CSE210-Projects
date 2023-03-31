using System;

class Reception : Event
{
    private bool _rsvp;

    public Reception(string nameEvent, string typeEvent, string description, int time, bool rsvp) : base(nameEvent, typeEvent, description, time)
    {
        _rsvp = rsvp;
    }

    public void Register()
    {
        Console.WriteLine("Thank you for responding to the RSVP!");
    }
}