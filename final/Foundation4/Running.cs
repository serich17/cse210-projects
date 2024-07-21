public class Running : Activity {
    private double _distance;

    public Running(double length, double distance) : base(length, "Running") {
        _distance = distance;
    }

    public override double CalculateDistance()
    {
        return _distance;
    }

    public override double CalculateSpeed() {
        return _distance/GetLength() * 60;
    }


}