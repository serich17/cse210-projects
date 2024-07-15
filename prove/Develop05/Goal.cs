public abstract class Goal {
    private string _shortName;
    private string _description;
    private int _points;

    public Goal(string name, string description, int points) {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public string GetName() {
        return _shortName;
    }
    public string GetDescription() {
        return _description;
    }
    public void SetPoints(string points) {

    }
    public int GetPoints() {
        return _points;
    }


    public abstract int RecordEvent();

    public abstract bool IsComplete();

    public virtual string GetDetailsString() {
        string x = " ";
        if (IsComplete()) {
            x = "X";
        }
        return $"[{x}] {_shortName} ({_description})";
    }

    public abstract string GetStringRepresentation();



}