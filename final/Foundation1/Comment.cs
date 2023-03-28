using System;

class Comments
{
    //public List<comments1>()
    
    
        //get name of person
//get comment text
//decide if I'm having any requirements in ()
    public Comments()
    {
        List<Comments> comments1 = new List<Comments>
        {
            comments1.Add("I love that mirror, where did you get it?"), 
            "Why did I just waste my time watching you wash your face?", 
            "I use that moisturizer too! It's so good."
        };
        List<Comments> comments2 = new List<Comments>
        {
            "I love putting this on when I do homework",
            "You should try doing renderings",
            "So relaxing. Makes me miss home"
        };
        List<Comments> comments3 = new List<Comments>
        {
            "Do I need an extender adaptor for any of those bolts?",
            "You make it look so easy",
            "I think I broke my car..."
        };
    }
    //string name, string text)
    // {
    //     Name = name;
    //     Text = text;
    // }
    
    // public string Name { get; set; }
    // public string Text { get; set; }


//store comments in a list

//return number of comments
public int GetNumberofComments1()
{
    int number = comments1.Count();
}

public int GetNumberofComments1()
{
    int number2 = comments2.Count();
}
public int GetNumberofComments3()
{
    int number3 = comments3.Count();
}
//create 3-4 comments for each video
//displayComments() in correct form (# of comments,name, text)
public string DisplayCommentsVid1()
{
 foreach (string comment in comments1)
 {
    Console.Writeline("Comment: "+comment);
 }
}
public string DisplayCommentsVid2()
{
     foreach (string comment in comments2)
 {
    Console.Writeline("Comment: "+comment);
 }
}
public string DisplayCommentsVid3()
{
     foreach (string comment in comments3)
 {
    Console.Writeline("Comment: "+comment);
 }
}
public string EndOFComments()
{
    return "---------------------------------------------------------";
}
}
