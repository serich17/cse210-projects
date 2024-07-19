public class Comment {
    public string _name;
    public string _commentText;


    public Comment(string name, string commentText) {
        _name = name;
        _commentText = commentText;
    }


    public string Display() {
        return $"{_name}:  {_commentText}";
    }
    
}