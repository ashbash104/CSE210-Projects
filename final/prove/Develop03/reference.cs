public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;
    public Reference(string book, int _chapter, int verse)
    {
        _book = book;
        //set the other values
        //_chapter = _chapter;?
        _verse = verse;
    }
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        //set the values 
        book = "2 Nephi";  
        chapter = 26;
        startVerse = 24;

    }
    public string GetReferenceText()
    {
        //returns a string version of the scripture reference      
        return _book + " " + _chapter + ":" + _verse + "-" + _endVerse;
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