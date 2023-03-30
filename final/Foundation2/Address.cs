using System;

class Address
{
    public string _streetAddress;
    public string _city;
    public string _state;
    public int _zip;
    public bool _usa;

    public Address(string streetAddress, string city, string state, int zip, bool usa)
    {
        streetAddress = _streetAddress;
        city = _city;
        state = _state;
        zip = _zip;
        usa = _usa;

    }
    //Return the address in proper form
    public string GetAddress()
    {
        return $"Address: {_streetAddress}, {_city}, {_state} {_zip}";
    }
    // public void Country()
    // {

    // }
    //Return whether the cm is in the US or not
    public bool USA()
    {
        
    }
    public string GetAddress()
    {

    }
}