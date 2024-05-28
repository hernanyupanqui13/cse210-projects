public class Comment {
    private string _author;
    private string _textOfComment;

    public Comment(string author, string text)
    {
        _author = author;
        _textOfComment = text;
    }

    public string GetDisplayInformation() {
        return $"{_author}: {_textOfComment}";
    }
    
}

