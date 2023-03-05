using System.Collections.Generic;
public class Scripture
{
    private Reference _reference;
    private string _text;
    public List<Word> scripture = new List<Word>();
    public List<int> indexes = new List<int>();
    // string scripture1 = "He doeth not anything save it be for the benefit of the world; for he loveth the world, even that he layeth down his own life that he may draw all men unto him. Wherefore, he commandeth none that they shall not partake of his salvation.";
    public Scripture(Reference reference)
    {
        
        string[] separatedWords = reference._verse.Split(" ");

        int cntr = -1;
        foreach(string _word in separatedWords) {

            cntr += 1;
            indexes.Add(cntr);

            Word word = new Word(_word);
            scripture.Add(word);
        }

        // publish the parameters
        // _reference = reference;
        // _text = text;
        // List<string> scriptureList = _text.Split(" ").ToList(); // convert string to list of strings
        // // convert the list of strings to a list of word objects
        // foreach(string word in scriptureList) {
        //     Word wordObj = new Word(word);
        //     wordObj.HideWord();
        //     scripture.Add(wordObj);

        // }
        // Start with string > convert to a list of strings > convert to a list of word objects

        
        
        
        
        //Set the variables, including break up the text into parts and for each one 
        //create a new word object and add it to the List.        
        //Dont forget to create a new list (e.g. = new List<Word>);  
        //List<string> list1 = new List<string>(); Do I need to make a new
        //list or does the line below work?
        // Random random = new Random();
        // var list = new List<string>();

        // random.Replace("a","_").Replace("b","_").Replace("c","_").Replace("d","_").Replace("e","_").Replace("f","_").Replace("g","_").Replace("h","_").Replace("i","_").Replace("j","_").Replace("k","_").Replace("l","_").Replace("m","_").Replace("n","_").Replace("o","_").Replace("p","_").Replace("q","_").Replace("r","_").Replace("s","_").Replace("t","_").Replace("u","_").Replace("v","_").Replace("w","_").Replace("x","_").Replace("y","_").Replace("z","_").Replace("H","_").Replace("W","_");
        //to print scripture1 string
        //Console.WriteLine(String.Join(" ",result));
        //string a = result [0];
    }
    public void HiddenWords()
    {

        Random random = new Random();

        int randomIndex = random.Next(indexes.Count());

        scripture[indexes[randomIndex]].HideWord();

        indexes.RemoveAt(randomIndex);


        //hides number words at random        
        //replace method to change words to underscores (maybe)    
    }
    public void GetDisplayText()
    {
        foreach (Word word in scripture)
        {
            word.ShowWord();
        }
        //Go through each word, call its GetDisplayText method and append it to a string        return"";
    }
    public void isCompletelyHidden()
    {
        //figure out if all the words are hidden, if so, return true, if not return false.        
        //return false;
    }
}