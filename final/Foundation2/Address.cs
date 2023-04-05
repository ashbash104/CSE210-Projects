using System;

class Address
{
    private string _streetAddress;
    private string _city;
    private string _state;
    private int _zip;
    private string _country;

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