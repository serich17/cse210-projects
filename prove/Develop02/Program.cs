using System;

class Program
{
    static void Main(string[] args)
    {   string choice;
        PromptGenerator prompt = new PromptGenerator();
        Journal journal = new Journal();

        do {
            //display menu
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write\n2. Display\n3. Save\n4. Load\n5. Quit");

            Console.Write("What would you like to do? ");
            choice = Console.ReadLine();
            
            //write new entry
            if (choice == "1"){
                //make new entry and get prompt
                Entry entry = new Entry
                {
                    _promptText = prompt.GetRandomPrompt()
                };
                journal.AddEntry(entry);

            }
            //Display the journal
            else if (choice == "2") {
                journal.DisplayAll();

            }
            //Save the journal to file
            else if (choice == "3") {
                Console.WriteLine("What is the filename?");
                string file = Console.ReadLine();
                journal.SaveToFile(file);

            }
            //Load the journal from a file
            else if (choice == "4") {
                Console.WriteLine("What is the filename?");
                string file = Console.ReadLine().ToString();
                journal.LoadFromFile(file);
            }
            //quit
            else if (choice == "5") {
                break;
            }
            //make sure they type a number 1-5
            else {
                Console.WriteLine("Please enter a valid option.");
            }

        } while (choice != "5");

    }
}


//Extra Credit: I added a entry number to save in the Entry class, and on display, it displays the current entry number with the total amount of entries.