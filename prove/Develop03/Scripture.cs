using System;

// Scripture: Keeps track of both the reference and the text of the scripture. 
// Can hide words and get the rendered display of the text.

//SCRIPTURE CLASS:
// A class is present that encapsulates the responsibilities of a Scripture. 
// Behavior that is specific to Scriptures is all done by this class, not 
// in other places in the program. And, this class does not include items 
// or behaviors that do not pertain to it.

public class Scripture
{
    private Reference _reference = new Reference();
    private List<Word> _word = new List<Word> {};
    private int hiddenWords = 0;

    public Scripture(Reference reference, List<string> words)
   {
    this._reference = reference;
    // Converte WordList into a Object Word 
    foreach(string word in words)
    {
        Word aWord = new Word();
        aWord.SetWord(word);
        _word.Add(aWord);
    }
   }

   public Word(string word)
    {
        this._word = word;
        this._hidden = false;
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
    
}


