using System.IO.Compression;

public class ReflectingActivity : Activity {
    private List<string> _prompts;
    private List<string> _questions;


    public ReflectingActivity() : base("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.","Reflecting Activity") {
        _prompts = ["Think of a time when you stood up for someone else.",
                    "Think of a time when you did something really difficult.",
                    "Think of a time when you helped someone in need.",
                    "Think of a time when you did something truly selfless."];

        _questions = ["Why was this experience meaningful to you?",
                        "Have you ever done anything like this before?",
                        "How did you get started?",
                        "How did you feel when it was complete?",
                        "What made this time different than other times when you were not as successful?",
                        "What is your favorite thing about this experience?",
                        "What could you learn from this experience that applies to other situations?",
                        "What did you learn about yourself through this experience?",
                        "How can you keep this experience in mind in the future?"];
    }


    public void Run() {
        DisplayStartingMessage();
        Console.Clear();
        Console.Write("Get ready...");
        ShowSpinner(4);

        DisplayPrompt();

        Console.WriteLine("\n\nNow ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        ShowCountDown(5);

        Console.Clear();



        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());
        while (DateTime.Now < endTime) {
            DisplayQuestions();

        }

        DisplayEndingMessage();


    }

    public string GetRandomPrompt() {
        Random r = new Random();
        return _prompts[r.Next(_prompts.Count)];
    }

    public string GetRandomQuestion() {
        Random r = new Random();
        return _questions[r.Next(_questions.Count)];    }

    public void DisplayPrompt() {
        Console.WriteLine("\n\nConsider the following prompt: ");
        Console.WriteLine($"\n --- {GetRandomPrompt()} --- ");
        Console.Write("\nWhen you have something in mind, press enter to continue.");
        Console.ReadKey();

    }

    public void DisplayQuestions() {
        Console.Write($"> {GetRandomQuestion()} ");
        ShowSpinner(12);
        Console.WriteLine();
    }




}