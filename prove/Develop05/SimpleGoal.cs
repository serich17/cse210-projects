public class SimpleGoal : Goal {

    private bool _isComplete;



    public SimpleGoal(string name, string description, int points) : base(name, description, points) {
        _isComplete = false;
    }

    public override int RecordEvent() {
        _isComplete = true;
        return GetPoints();
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }
    public void SetBool(bool complete) {
        _isComplete = complete;
    }


    public override string GetStringRepresentation()
    {
        return $"SimpleGoal|{GetName()}|{GetDescription()}|{GetPoints()}|{IsComplete()}";
    }


}