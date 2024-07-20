using System.Net.Sockets;

public class Customer {

    private string _name;
    private Address _address;

    public Customer(string name, string streetAddress, string city, string state, string country) {
        _address = new Address(streetAddress, city, state, country);
        _name = name;
    }


    public bool LivesInUsa() {
        if (_address.IsInUsa() == true) {
            return true;
        }
        else {
            return false;
        }
    }

    public string GetName() {
        return _name;
    }

    public string GetAddress() {
        return _address.FullAddress();
    }


}