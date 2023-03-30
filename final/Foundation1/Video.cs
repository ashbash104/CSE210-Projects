using System;

class Video
{

    //get title
    //get author
    //get length in minutes
    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }
    //set above variables to new variable video
    public string _title { get; set; }
    public string _author { get; set; }
    public int _length { get; set; }

    //displayVideo() in correct form (title, author,length)
    public void DisplayVideo()
    {
        Console.WriteLine("---------------------------------------------------------");
        Console.Write("Video: ");
        Console.WriteLine($"{_title} By: {_author} Length: {_length} minutes.");
    }
}