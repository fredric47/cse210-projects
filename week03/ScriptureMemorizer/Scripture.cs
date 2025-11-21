using System.Net.Quic;
using System.Runtime.CompilerServices;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        foreach(string word in text.Split(' ')) // ?:]
        {
            _words.Add(new Word(word)); 
        }
        
    }

    public void HideRandomWords()//(int numberToHide) //add user option to choose how many to hide :)
    {
        int verseLength = _words.Count;
        Random randumNumber = new Random();
        int i = 0;
        while (i < 3)
        {
            i++;
            int index;
            index = randumNumber.Next(0, verseLength); //?

            if (IsCompletelyHidden() == false)
            {
                if (_words[index].IsHidden() == false)
                {
                    _words[index].Hide();
                }

                else
                {
                    while (_words[index].IsHidden() == true)
                    {
                        index = randumNumber.Next(0, verseLength);
                    }
                    _words[index].Hide();
                }
            }
        }
    }

    public string GetDisplayText()
    {
        Console.Clear();
        string verse = "";
        foreach (Word word in _words)
        {
            verse += $"{word.GetDisplayText()} ";
        }
        return $"{_reference.GetDisplayText()} {verse}";
    }
    
    public bool IsCompletelyHidden()
    {
        bool trueFalse = true;
        foreach (Word word in _words)
        {
            bool hidden = word.IsHidden();
            if (hidden == false)
            {
                trueFalse = false;
            }
        }

        return trueFalse;
    }
}