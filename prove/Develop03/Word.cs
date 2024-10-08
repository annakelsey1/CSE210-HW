using System;

// Word: Keeps track of a single word and whether it is shown or hidden.

//WORD CLASS:
// A class is present that encapsulates the responsibilities of a Word 
// (including that the Word class is responsible for storing it's own 
// shown/hidden state). Behavior that is specific to Words is all done by 
// this class, not in other places in the program. And, this class does 
// not include items or behaviors that do not pertain to it.

public class Word
{
    private string _word;
    private bool _hidden;

    public Word(string word) : this(word, false)
    {
    }

    public Word(string word, bool hidden)
    {
        this._word = word;
        this._hidden = hidden;
    }

    public void SetWord(string word)
    {
        this._word = word;
    }

    public string GetWord()
    {
        return _word;
    }

    public bool IsHidden()
    {
        return _hidden;
    }

    public void HideWord()
    {
        this._hidden = true;
    }

    public void ShowWord()
    {
        this._hidden = false;
    }

    public override string ToString()
    {
        return _hidden ? "****" : _word;
    }
}

