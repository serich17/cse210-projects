

public class Entry {
    //add current date and save to variable
    static DateTime theCurrentTime = DateTime.Now;
    public string _date = theCurrentTime.ToShortDateString();

    //declare variables for other important journal information 
    public string _promptText;
    public string _entryText;

    // add entry number
    public int _entryNumber;



    public void Display(int count) {
        // display the journal
        Console.WriteLine($"Entry: {_entryNumber}/{count}\nDate: {_date} - Prompt: {_promptText}");
        Console.WriteLine(_entryText);
        
    }


}