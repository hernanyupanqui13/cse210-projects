public class Video {
    private string _title;
    private string _author; 
    private int _lenght; // in seconds
    private List<Comment> _listOfComments = new List<Comment>();


    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _lenght = length;
    }

    public int GetNumberOfComments()
    {
        return _listOfComments.Count;
    }

    public void AddComment(Comment comment)
    {
        _listOfComments.Add(comment);
    }

    public void DisplayAllInformation() {
        Console.WriteLine("------------------------------------------------");
        Console.WriteLine($"\"{_title}\" by {_author} - {_lenght} seconds | With {this.GetNumberOfComments()} comments.");
        Console.WriteLine("------------------------------------------------");
        DisplayComments();
    }

    public void DisplayComments() {
        int i = 1;
        foreach (Comment comment in _listOfComments)
        {
            Console.WriteLine($"{i}. {comment.GetDisplayInformation()}");
            i++;
        }
    }
}