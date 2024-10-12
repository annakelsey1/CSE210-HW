using System;

// “Video” Class:
// _title : string  |  keeps track of the title of the video the add plays on
//             _author : string  |  keeps track of the name of the youtuber
//             _length : int  |  keeps track of how long the video is
// lol, I needed way more than I initially thought

public class Video
{
    private string _title;
    private string _author;
    private decimal _length;
    private List<Comment> _comments;

    public Video(string title, string author, decimal length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comment>();
    }

    public string NumberOfComments()  // Fixed the method name for consistency
    {
        return _comments.Count.ToString();
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public void DisplayComments()
    {
        foreach (Comment comment in _comments)
        {
            Console.WriteLine(comment.CommenterName() + " commented: " + comment.CommentText());
        }
    }

    public string Title()
    {
        return _title;
    }

    public string Author()
    {
        return _author;
    }

    public decimal Length()
    {
        return _length;
    }
}

