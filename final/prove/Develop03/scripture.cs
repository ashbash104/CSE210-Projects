using System.Collections.Generic;
public class Scripture
{
    private Reference _reference;
    private string _text;
    public List<Word> scripture = new List<Word>();
    public List<int> indexes = new List<int>();
    private List<string> hiddenWords;

    public bool _isHidden;

    //this.hiddenWords = new List<string>();
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

    }
    public void HiddenWords()
    {

        Random random = new Random();

        int randomIndex = random.Next(indexes.Count());

        scripture[indexes[randomIndex]].HideWord();

        //string wordToHide = words[randomIndex];

        //hiddenWords.Add(wordToHide);

        indexes.RemoveAt(randomIndex);


        //hides number words at random        
        //replace method to change words to underscores (maybe)    
    }
    public void GetDisplayText()
    {
        Console.Write("2 Nephi 26:24: \"");
        foreach (Word word in scripture)
        {
            word.ShowWord();
        }
        Console.Write("\"");
        Console.WriteLine("");
        //Go through each word, call its GetDisplayText method and append it to a string        return"";
    }
    public bool isCompletelyHidden()
    {
        //figure out if all the words are hidden, if so, return true, if not return false. 
        //string [] words = _text.Split(" ");
        //return hiddenWords.Count == words.Length;
        //{
           
        //}
        //return indexes.Count;
        if(indexes.Count() <= 2)
        {
            Random random = new Random();
            int randomIndex = random.Next(indexes.Count());

            scripture[indexes[randomIndex]].HideWord();
            return true;
        }
        return false;
        
    }
}