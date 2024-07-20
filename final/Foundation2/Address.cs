public class Address {
    private string _streetAddress;
    private string _city;
    private string _stateProvince;
    private string _country;



    public Address(string streetAddress, string city, string state, string country) {
        _streetAddress = streetAddress;
        _city = city;
        _stateProvince = state;
        _country = country;

    }




    public bool IsInUsa() {
        string country = _country.ToLower();

        if (country == "us" || country == "usa" || country == "united states" || country == "united states of america") {
            return true;
        }
        else{
            return false;
        }
    }

    public string FullAddress() {
        return $"{_streetAddress} \n{_city}, {_stateProvince} {_country}";
    }




}