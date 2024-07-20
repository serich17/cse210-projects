public class OutdoorGathering : Event {
    private string _weather;


    public OutdoorGathering(string title, string description, string date, string time, Address address, string weather) : base(title, description, date, time, "Outdoor Gathering", address) {
        _weather = weather;
    }

    public override string FullDetails() {
        string fullDetails = StandardDetails();

        fullDetails += $"\nEvent type: {GetType()}\nWeather: {_weather}";


        return fullDetails;

    }


}