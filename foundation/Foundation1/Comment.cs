using System;

// “Comment” Class:
//             _name : string  |  keeps track of the name of the commenter
//             _text: string  |  keeps track of the text in the comment

public class Comment
{
    private string _name;
    private string _text;

    public Comment(string name, string text)
    {
        _name = name;
        _text = text;
    }

    public string CommenterName()
    {
        return _name;  
    }

    public string CommentText()
    {
        return _text;  
    }
}

