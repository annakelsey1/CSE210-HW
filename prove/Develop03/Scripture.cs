using System;
using System.Collections.Generic;
using System.Text;

// Scripture: Keeps track of both the reference and the text of the scripture. 
// Can hide words and get the rendered display of the text.

//SCRIPTURE CLASS:
// A class is present that encapsulates the responsibilities of a Scripture. 
// Behavior that is specific to Scriptures is all done by this class, not 
// in other places in the program. And, this class does not include items 
// or behaviors that do not pertain to it.

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();
    private int hiddenWords = 0;

    // Constructor with List<string>
    public Scripture(Reference reference, List<string> words)
    {
        this._reference = reference;

        foreach (string word in words)
        {
            Word aWord = new Word(word);
            _words.Add(aWord);
        }
    }

    // Constructor with List<Word>
    public Scripture(Reference reference, List<Word> words)
    {
        this._reference = reference;
        this._words = words;
    }

    // Returns the Scripture string with hidden words as underscores
    public string GetScripture()
    {
        string reference = _reference.GetReference();
        StringBuilder wordsBuilder = new StringBuilder();

        foreach (Word aWord in _words)
        {
            if (aWord.IsHidden())
            {
                wordsBuilder.Append(" ").Append(new string('_', aWord.GetWord().Length));
            }
            else
            {
                wordsBuilder.Append(" ").Append(aWord.GetWord());
            }
        }

        return $"{reference} {wordsBuilder.ToString().Trim()}";
    }

    // Sets scripture by splitting a string into words and converting to Word objects
    public void SetScripture(Reference reference, string words) 
    {
        this._reference = reference;
        List<string> scriptureList = words.Split(' ').ToList();
        
        _words.Clear();  // Clear existing words
        foreach (string word in scriptureList)
        {
            Word aWord = new Word(word);
            _words.Add(aWord);
        }
    }

    // Hides a random word, ensuring no infinite recursion
    public void HideRandomWord()
    {
        if (hiddenWords == _words.Count)
        {
            Console.Clear();
            Console.WriteLine(GetScripture());
            Environment.Exit(0);  // Exit if all words are hidden
        }

        Random rnd = new Random();
        int randomIndex = rnd.Next(0, _words.Count);

        if (!_words[randomIndex].IsHidden())
        {
            _words[randomIndex].HideWord();
            hiddenWords += 1;
            Console.WriteLine(hiddenWords);
        }
        else
        {
            HideRandomWord();  // Recursive call to hide another word
        }
    }
}



