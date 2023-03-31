using System;

class Program
{
    static void Main(string[] args)
    {
        //Once you have the classes in place
        //write a program that creates at least one event of each type
        //and sets all of their values. Then, for each event, 
        //call each of the methods to generate the marketing messages 
        //and output their results to the screen.
        Address address = new Address();
        //Lecture Event
        Lecture lecture = new Lecture("Learn How to Network!","Lecture", "Come and learn how to effecttively network online, at events, and in several other ways!",
        4, "Michael Scott", 300);
        Console.WriteLine("=========================================================");
        lecture.DisplayEvent();
        address.GetLectureAddress();
        Console.WriteLine("Hope to see you there!");
        Console.WriteLine(" ");



        //Reception Event
        Reception reception = new Reception("Mary & Scott's Wedding Reception", "Reception", "Come celebrate the newlyweds as they begin their new adventure!",
        6, true);
        Console.WriteLine("=========================================================");
        reception.DisplayEvent();
        address.GetReceptionAddress();
        reception.Register();
        Console.WriteLine(" ");

        //Outdoor Event
        Outdoor outdoor = new Outdoor("Easter Social", "Outdoor Brunch", "Come celebrate Easter with us! Bring your friends and family to enjoy great food as a neighborhood",
        12, "70 Degrees and Sunny!");
        Console.WriteLine("=========================================================");
        outdoor.DisplayEvent();
        address.GetOutdoorAddress();
        outdoor.Forecast();
        Console.WriteLine(" ");
    }
}