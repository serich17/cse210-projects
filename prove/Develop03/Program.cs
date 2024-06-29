using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        

        Random rnd = new Random();
        string [] lines = System.IO.File.ReadAllLines("scriptures.txt");
        int randomScripture = rnd.Next(0, lines.Count());
        string[] line = lines[randomScripture].Split("|");

        string text = line[0];
        string reference1 = line[1];
        int chap = int.Parse(line[2]);
        int fVerse = int.Parse(line[3]);
        int sVerse = int.Parse(line[4]);

        Reference reference = new Reference(reference1, chap, fVerse, sVerse);

        
        Scripture scripture = new Scripture(reference, text);
        string run;


        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine("Press enter to continue or type 'quit' to finish:");
        run = Console.ReadLine();

        do {
            

            if (run == "quit") {
                break;
            }
            else {
                scripture.HideRandomWords(3);
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine("\nPress enter to continue or type 'quit' to finish:");
                run = Console.ReadLine();

            }
        } while (!scripture.IsCompletelyHidden());



    }
}

// to exceed the requirements, I added a file with multiple scriptures, and the program opens the file and randomly chooses a scripture to use