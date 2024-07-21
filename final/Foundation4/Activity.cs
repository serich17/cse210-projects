using System.Security.Cryptography.X509Certificates;

public class Activity {

    private string _date;
    private string _activityType;
    private double _lengthMin;
    

    public Activity(double length, string activityType) {
        _date = DateTime.Now.ToString("M/d/yy");
        _lengthMin = length;
        _activityType = activityType;
    
    }


    public double GetLength() {
        return _lengthMin;
    }

    public string DisplaySummery() {
        return $"{_date} {_activityType} ({_lengthMin} min)-\nDistance {Math.Round(CalculateDistance(), 2)} miles, Speed {Math.Round(CalculateSpeed(), 2)} mph,\nPace: {Math.Round(CalculatePace(), 2)} min per mile\n";
    }


    public virtual double CalculateDistance() {

        return CalculatePace() * CalculateSpeed();
    }

    public virtual double CalculateSpeed() {
        return CalculateDistance() / _lengthMin * 60;
    }

    public virtual double CalculatePace() {
        return _lengthMin / CalculateDistance();
    }





}