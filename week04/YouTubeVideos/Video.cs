using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class Video
{
    //Attributes
    private string _title;
    private string _author;
    private int _duration;
    private List<Comment> _comments;

    //Constructor
    public Video(string title, string author, int duration)
    {
        _title = title;
        _author = author;
        _duration = duration;
        _comments = new List<Comment>();
    }

    //Methods
    public void AddComment(string commentAuthor, string commentText)
    {
        Comment newComment = new Comment(commentAuthor,commentText);
        _comments.Add(newComment);
    }
    
    public void DisplayComments()
    {
        foreach(Comment C in _comments)
        {
            C.DisplayComment();
        }
    }

    public int CommentQuantity()
    {
        int quantity = _comments.Count();
        
        return quantity;
    }


}