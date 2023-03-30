using System;

class Comments
{
        //get name of person?
//get comment text?
//decide if I'm having any requirements in ()
    List<string> comments1 = new List<string>
    {
        "Ashbash: I love that mirror, where did you get it?", 
        "HallahB: Why did I just waste my time watching you wash your face?", 
        "KaitieB: I use that moisturizer too! It's so good."
    };
    List<string> comments2 = new List<string>
    {
        "Jared_: I love putting this on when I do homework",
        "SimonC: You should try doing renderings",
        "SarahAnn: So relaxing. Makes me miss home"
    };
    List<string> comments3 = new List<string>
    {
        "RichardP: Do I need an extender adaptor for any of those bolts?",
        "Its_Rachel: : You make it look so easy",
        "Sn00zy: I think I broke my car..."
    };


    //return number of comments
    public int GetNumberofComments1()
    {
        int number = comments1.Count();
        return number;
    }

    public int GetNumberofComments2()
    {
        int number2 = comments2.Count();
        return number2;
    }
    public int GetNumberofComments3()
    {
        int number3 = comments3.Count();
        return number3;
    }
    //create 3-4 comments for each video
    //displayComments() in correct form (# of comments,name, text)
    public void DisplayCommentsVid1()
    {
        foreach (string comment in comments1)
        {
            Console.WriteLine("Comment: " +comment);
        }
    }
    public void DisplayCommentsVid2()
    {
        foreach (string comment in comments2)
        {
            Console.WriteLine("Comment: "+comment);
        }
    }
    public void DisplayCommentsVid3()
    {
        foreach (string comment in comments3)
        {
            Console.WriteLine("Comment: "+comment);
        }
    }
    public string EndOFComments()
    {
        return "---------------------------------------------------------";
    }
}
