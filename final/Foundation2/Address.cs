using System;

class Address
{
    public string _streetAddress;
    public string _city;
    public string _state;
    public int _zip;
    public string _country;

    public Address(string streetAddress, string city, string state, int zip, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _state = state;
        _zip = zip;
        _country = country;

    }
    //Return the address in proper form
    public string GetAddress()
    {
        return $"{_streetAddress}, {_city}, {_state} {_zip} {_country}";

    }

    //Return whether the cm is in the US or not
    public int USA()
    {
        if (_country == "USA")
        {
            return 5;
        }
        else
        {
            return 35;
        }
    }
}