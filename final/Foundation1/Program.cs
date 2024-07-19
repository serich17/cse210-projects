using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();
        
        
        
        Video video1 = new Video("Mountain", "Joe Rock", 128);
        video1.AddComent("MaryP","Great video");
        video1.AddComent("Wendy","Number 1 Fan!");
        video1.AddComent("Tom","Thanks for the info, well made");
        videos.Add(video1);

        Video video2 = new Video("Volcano", "Mary Jane", 500);
        video2.AddComent("Bob","I hiked that mountain before.");
        video2.AddComent("Larry","Beautiful pictures!");
        video2.AddComent("Ann","What year was this done in?");
        videos.Add(video2);

        Video video3 = new Video("River", "Hank Reems", 600);
        video3.AddComent("Barbara", "I LOVE that river");
        video3.AddComent("Jane","I have some family that live close by");
        video3.AddComent("Mario","That is soo cool!");
        videos.Add(video3);


        foreach (Video video in videos) {
            video.Display();
        }



    }
}