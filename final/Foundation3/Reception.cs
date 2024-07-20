public class Reception : Event {

    private string _emailRSVP;

    public Reception(string title, string description, string date, string time, Address address, string emailRSVP) : base(title, description, date, time, "Reception", address) {
        _emailRSVP = emailRSVP;
    
    }


    public override string FullDetails() {
        string fullDetails = StandardDetails();

        fullDetails += $"\nEvent type: {GetType()}\nRSVP email: {_emailRSVP}";


        return fullDetails;

    }




}