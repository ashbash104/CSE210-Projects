public class Reference
{
    // Member variables
    public string _book;
    public string _chapter;
    public string _verse;

    public Reference(string book, string chapter, string verse)
    {
        _book = book;
        //set the other values
        _chapter = chapter;
        _verse = verse;
    }
    /*
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        //set the values 
        book = "2 Nephi";  
        chapter = 26;
        startVerse = 24;

    }
    */
    public string GetReferenceText()
    {
        //returns a string version of the scripture reference      
        return _book + " " + _chapter + ":" + _verse + "-";
    }
    public string GetBook()
    {
        return _book;
    }
    public void SetBook(string book)
    {
        _book = book;
    }
}