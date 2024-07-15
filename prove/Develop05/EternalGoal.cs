public class EternalGoal : Goal {
    

    public EternalGoal(string name, string description, int points) : base(name, description, points) {

    }


    public override int RecordEvent() {
        SetPointsGained(GetPointsGained() + GetPoints());
        return GetPoints();

    }

    public override bool IsComplete()
    {
        return false;
    }


    public override string GetStringRepresentation()
    {
        return $"EternalGoal|{GetName()}|{GetDescription()}|{GetPoints()}|{GetPointsGained()}";;
    }



}