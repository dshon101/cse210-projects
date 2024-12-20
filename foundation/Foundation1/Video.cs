public class Video  
{  
    public string Title { get; set; }  
    public string Author { get; set; }  
    public int Length { get; set; } // Length in seconds  
    private List<Comment> comments;  

    public Video(string title, string author, int length)  
    {  
        Title = title;  
        Author = author;  
        Length = length;  
        comments = new List<Comment>();  
    }  

    public void AddComment(Comment comment)  
    {  
        comments.Add(comment);  
    }  

    public int GetNumberOfComments()  
    {  
        return comments.Count;  
    }  

    public List<Comment> GetComments()  
    {  
        return comments;  
    }  

    public string GetVideoDetails()  
    {  
        return $"{Title} by {Author} ({Length} seconds)";  
    }  
}  