using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello FinalProject World!");
        //create 3-4 videos 
        var video1 = new Video("Get Ready With Me!", "Ashlee Hart", 3);
        var video2 = new Video("Walk Around Boston with Rain Sounds", "Ashlee Hart", 90);
        var video3 = new Video("Replace Power Steering Pump 2008 Honda Accord", "Brandon Marble", 22);
        Comments comments = new Comments();

        //Iterate through videos and comments and print.
        video1.DisplayVideo();
        comments.GetNumberofComments1();
        comments.DisplayCommentsVid1();
        comments.EndOFComments();

        video2.DisplayVideo();
        comments.GetNumberofComments2();
        comments.DisplayCommentsVid2();
        comments.EndOFComments();

        video3.DisplayVideo();
        comments.GetNumberofComments3();
        comments.DisplayCommentsVid3();
        comments.EndOFComments();
    }
}