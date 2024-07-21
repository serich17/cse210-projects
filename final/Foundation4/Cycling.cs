public class Cycling : Activity {
    private double _speed;

    public Cycling(double length, double speed) : base(length, "Cycling") {
        _speed = speed;
    }


    public override double CalculateDistance()
    {
        return _speed * (GetLength()/ 60);
    }

}