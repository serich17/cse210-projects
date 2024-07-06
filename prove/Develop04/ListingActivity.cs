using System.Security.Cryptography.X509Certificates;

public class ListingActivity : Activity {
    private int _count;
    private List<string> _prompts;


    public ListingActivity() : base("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", "Listing Activity") {
        _count = 0;
        _prompts = ["Who are people that you appreciate?",
                    "What are personal strengths of yours?",
                    "Who are people that you have helped this week?",
                    "When have you felt the Holy Ghost this month?",
                    "Who are some of your personal heroes?"];
    }

    public void Run() {
        DisplayStartingMessage();
        Console.Clear();
        Console.Write("Get ready...");
        ShowSpinner(4);

        GetRandomPrompt();



        Console.Write("You may begin in: ");
        ShowCountDown(4);

        GetListFromUser();

        Console.WriteLine($"You listed {_count} items!");

        DisplayEndingMessage();

    }

    public void GetRandomPrompt() {
        Random r = new Random();
        Console.WriteLine("\n\nList as many responses you can to the following prompt:");
        Console.WriteLine($" --- {_prompts[r.Next(_prompts.Count)]} ---");
    }

    public List<string> GetListFromUser() {
        List<string> userItems = new List<string>();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());
        Console.WriteLine();
        while (DateTime.Now < endTime) {
            Console.Write("> ");
            userItems.Add(Console.ReadLine());

            _count ++;

        }

        return userItems;
    }

    

}