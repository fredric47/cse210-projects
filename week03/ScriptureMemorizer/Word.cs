using System.Runtime.CompilerServices;

public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
    }

    public void Hide()
    {
        int textLength = _text.Count();
        _text = new string('_', textLength); // Used Copilot to correct my attempt of using a foreach to replace each letter with an _ to this line.
        _isHidden = true;
    }

    // public void Show()
    // {

    // }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText()
    {
        return _text;
    }
    
    // public void SetDisplayText(string replacementText)
    // {
    //     _text = replacementText;
    //     _isHidden = true;
    // }
}