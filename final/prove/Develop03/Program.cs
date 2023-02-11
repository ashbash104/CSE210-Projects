using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Develop03 World!");
        Reference reference1 = new Reference("2 Nephi", 26,24);
        string text = "He doeth not anything save it be for the benefit of the world; for he loveth the world, even that he layeth down his own life that he may draw all men unto him. Wherefore, he commandeth none that they shall not partake of his salvation.";
        Scripture scripture1 = new Scripture(reference1, text);
        Console.Clear();
        //scripture1.GetDisplayText();
        scripture1.GetDisplayText();
        while(true)
        {
    
           Console.WriteLine("Press enter to continue or type 'quit' to finish: ");
           string userInput = Console.ReadLine();
           if(userInput.ToLower()=="quit")
           {
                break;
           }    
           else
           {
                Console.Clear();
                scripture1.GetDisplayText();
                //if (scripture1.isCompletelyHidden())
                // {
                //     break;
                // }
           }  
                //scripture1.HiddenWords();
        }
    }
}