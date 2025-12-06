public class UserVideo : Video 
{
    private List <Comment> _comments = new List<Comment>();

    public UserVideo(string title, string author, int length) 
    : base(title, author, length)
    {
    }
    
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public int GetCommentCount()
    {
        return _comments.Count;
    }

    public  List<Comment> GetComments()
    {   
        return _comments;
    }
    
}