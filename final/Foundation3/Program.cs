using System;

class Program
{
    static void Main(string[] args)
    {
        List<Event> events = new List<Event>();
        Address lectureAddress = new Address("5687 Colombia rd.", "Kansas City", "MO", "USA");
        Address receptionAddress = new Address("123 S. 200 W.","Provo", "Utah", "USA");
        Address outdoorGatheringAddress = new Address("659875 City park", "Cincinnati", "Ohio", "USA");

        Lecture lecture = new Lecture("How to plant a garden", "Have you ever wanted to learn how to plant a garden? Learn the basic tips as well as things to avoid for beginners", "10/22/24", "12:00PM", lectureAddress, "John Carter", 70);
        Reception reception = new Reception("Come celebrate with Us! -- John and Mary", "We are so excited to be married and would love to have you celebrate with us!", "8/19/24", "7:00PM", receptionAddress, "emailus@rsvp.com");
        OutdoorGathering outdoorGathering = new OutdoorGathering("Summer BBQ", "Come have a relaxed evening with us, and enjoy the best barbeque", "7/29/24", "6:00PM", outdoorGatheringAddress, "Bring sports shoes to play some tenis afterward, and some sunscreen");

        events.Add(lecture);
        events.Add(reception);
        events.Add(outdoorGathering);


        foreach (Event i in events) {
            Console.WriteLine();
            Console.WriteLine(i.StandardDetails());
            Console.WriteLine();
            Console.WriteLine(i.FullDetails());
            Console.WriteLine();
            Console.WriteLine(i.ShortDescription());
            Console.WriteLine();
            Console.WriteLine();

        }


    }
}