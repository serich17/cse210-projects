public class BreathingActivity : Activity {


    public BreathingActivity() : base("This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing","Breathing Activity")  {
    }

    public void Run() {
        DisplayStartingMessage();
        Console.Write("Getting ready...");
        ShowSpinner(4);
        int seconds = GetDuration();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());
        Console.WriteLine("\n");
        while (DateTime.Now < endTime) {
            Console.Write("\nBreathe in...");
            ShowCountDown(4);

            Console.Write("Now breathe out...");
            ShowCountDown(6);

            seconds = seconds - 10;
        }

        DisplayEndingMessage();

    }
}