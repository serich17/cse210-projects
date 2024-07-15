using System.Drawing;

public class ChecklistGoal : Goal {

    private int _amountCompleted;
    private int _target;
    private int _bonus;


    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points) {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }


    public void SetAmountCompleted(int amountCompleted) {
        _amountCompleted = amountCompleted;
    }

    public override int RecordEvent() {
        _amountCompleted += 1;
        if (_amountCompleted >= _target) {
            return _bonus + GetPoints();
        }
        else {
            return GetPoints();
        }
    }

    public override bool IsComplete()
    {
        if (_amountCompleted >= _target) {
            return true;
        }
        else {
            return false;
        }
    }


    public override string GetDetailsString() {
        string x = " ";
        if (IsComplete()) {
            x = "X";
        }
        return $"[{x}] {GetName()} ({GetDescription()}) -- Currently completed: {_amountCompleted}/{_target}";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal|{GetName()}|{GetDescription()}|{GetPoints()}|{_target}|{_bonus}|{_amountCompleted}";;
    }




}