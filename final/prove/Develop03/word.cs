public class Word
{
    private string _content;
    private bool _isHidden;
    public Word(string text)
    {
        _content = text;
        _isHidden = false;
    }
    public void GetDisplayText()
    {
        //return the text or ____        return "";
    }
    public void HideWord()
    {
        _isHidden = true; // set the isHidden variable to true    
    }
    public void ShowWord()
    {
        Console.Write(_content + " ");
        //set the isHidden variable to false    
    }
    public bool IsHidden()
    {
        return _isHidden;
    }
}