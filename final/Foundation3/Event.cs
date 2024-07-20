using System.ComponentModel.Design;
using System.Reflection.Metadata;

public abstract class Event {
    
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;
    private string _type;

    public Event(string title, string description, string date, string time, string type, Address address) {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _type = type;
        _address = address;
    }

    public string GetType() {
        return _type;
    }


    public string StandardDetails() {
        return $"Title: {_title}\nDescription: {_description}\nDate: {_date}\nTime: {_time}\nAddress:\n{_address.FullAddress()}";
    }
    
    public abstract string FullDetails();

    public string ShortDescription() {
        return $"Event Type: {_type}\nTitle: {_title}\nDate: {_date}";
    }
    

}