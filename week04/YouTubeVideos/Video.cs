using System.IO.Compression;
using System.Net;
using System.Reflection;
using System.Transactions;

public class Video
{
    private string _title;
    private string _author;
    private float _length;

    private List<Comment> _comment = new List<Comment>();

    public int NumberOfComments()
    {
        return _comment.Count();
    }

    public void SetTitleAuthorLength(string title, string author, float length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public void AddComment(string name, string text)
    {
        Comment comment = new Comment();
        comment.SetCommentNameText(name, text);
        _comment.Add(comment);
    }

    public string GetTitle()
    {
        return _title;
    }
    public string GetAuthor()
    {
        return _author;
    }

    public float GetLength()
    {
        return _length;
    }
    
    public void GetComment()
    {
        foreach (Comment comment in _comment)
        {
            Console.WriteLine($"-{comment.GetName()}: {comment.GetText()}");
        }   
    }
    
}