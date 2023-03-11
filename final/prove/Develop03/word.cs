public class Word
{
    public string _content;
    // private bool _isHidden;
    public Word(string text)
    {
        _content = text;
        // _isHidden = false;
    }

    public void HideWord()
    {
        int letterCount = _content.Length;
        _content = "";
        for (int i = 0; i < letterCount; i++) {
            _content += "_";
        }
        // _isHidden = true; // set the isHidden variable to true    
    }
    public void ShowWord()
    {
        
        Console.Write(_content + " ");
        
        //set the isHidden variable to false    
    }
    // public bool IsHidden()
    // {
    //     return _isHidden;
    // }
}