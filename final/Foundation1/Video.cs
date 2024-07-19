public class Video {
    public string _title;
    public string _author;
    public int _length;
    public List<Comment> _comments;

    public Video(string title, string author, int length) {
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comment>();
    }



    public void Display() {
        Console.WriteLine($"\n{_title} ({GetTime()}) -- by {_author}");
        Console.WriteLine($"({NumberComments()}) Comments:");

        foreach (Comment comment in _comments) {
            Console.WriteLine($"- {comment.Display()}");
        }



    }

    public int NumberComments() {
        return _comments.Count();
    }

    public void AddComent(string name, string commentText) {
        Comment comment = new Comment(name, commentText);
        _comments.Add(comment);
    }

    public string GetTime() {
        int quotient, remainder;
        quotient = Math.DivRem(_length, 60, out remainder);
        


        return $"{quotient}.{remainder}";
    }


}