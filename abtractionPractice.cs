// A code template for object known as person. 
// The responsibility of a person is to hold and display name
public class person
{
    //The C# convention is to start member variables with _
    //New keyword followed by the class name and ()
    public string _givenName = "";
    public string _familyName = "";

    //Constructor method is invoked using new keyword
    //followed by the class name and ()
    public person()
    {
    }

    //A method that displays full name as used in eastern
    //countries (family name, given name)
    public void ShowEasternName()
    {
        Console.WriteLine($"{_familyName},{_givenName}");
    }

    //Method that displays name as shown in western countries
    public void ShowWesternName()
    {
        Console.WriteLine($"{_givenName} {_familyName}");
    }
}


