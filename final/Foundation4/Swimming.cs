public class Swimming : Activity {
    private double _numberLaps;

    public Swimming(double length, double numberLaps) : base(length, "Swimming") {
        _numberLaps = numberLaps;
    }


    public override double CalculateDistance()
    {
        return _numberLaps * 50 / 1000 * .62;
    }


}