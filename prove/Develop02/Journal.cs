using System.IO;
public class Journal {
    public List<Entry> _entries = new List<Entry>();


    public void AddEntry(Entry newEntry) {
        Console.Write($"{newEntry._promptText}\n> ");
        newEntry._entryText = Console.ReadLine();
        //add passed entry parameter to the _entries list 
        _entries.Add(newEntry);
    }

    public void DisplayAll(){
        //display each entry
        foreach (Entry entry in _entries) {
            Console.WriteLine();
            entry.Display();
        }
        Console.WriteLine();
    }

    public void SaveToFile(string file) {
        using (StreamWriter outputFile = new StreamWriter(file)) {
            //started, but needs to figure out the format to write the date and prompt text
            foreach (Entry entry in _entries) {
            outputFile.WriteLine($"{entry._date}|{entry._promptText}|{entry._entryText}");
            }
        }

    }

    public void LoadFromFile(string file) {
        //get string of all the lines in file
        string [] lines = System.IO.File.ReadAllLines(file);
        // replace current journal
        _entries = [];

        foreach (string line in lines) {
            //create a new entry to put in the loaded journal
            Entry entry = new Entry();
            string[] partes = line.Split("|");

            //figure out in what order the items are stored.
            entry._date = partes[0];
            entry._promptText = partes[1];
            entry._entryText = partes[2];

            //add read items to current journal
            _entries.Add(entry);


        }
        
    }


}