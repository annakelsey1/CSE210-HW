using System;

// Reference: Keeps track of the book, chapter, and verse information.

//REFERENCE CLASS:
// A class is present that encapsulates the responsibilities of a Reference 
// (including handling multiple verses). Behavior that is specific to 
// references is all done by this class, not in other places in the program. 
// And, this class does not include items or behaviors that do not pertain 
// to it.

public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;

    public Reference(string book, int chapter, int verse)
    {
        this._book = book;
        this._chapter = chapter;
        this._verse = verse;
    }

    public string Book
    {
        get { return _book; }
        set { _book = value; }
    }

    public int Chapter
    {
        get { return _chapter; }
        set { _chapter = value; }
    }

    public int Verse
    {
        get { return _verse; }
        set { _verse = value; }
    }

    public string GetReference() 
    {
        string reference = $"{_book} {_chapter}:{_verse}";
        return reference;
    }

    public void SetReference(string book, int chapter, int verse)
    {
        this._book = book;
        this._chapter = chapter;
        this._verse = verse;
    }
}
