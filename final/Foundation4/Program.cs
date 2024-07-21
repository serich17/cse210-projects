using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        Running running = new Running(30, 3);
        Swimming swimming = new Swimming(22, 4);
        Cycling cycling = new Cycling(27, 5);
        activities.Add(running);
        activities.Add(swimming);
        activities.Add(cycling);


        foreach (Activity activity in activities) {
            Console.WriteLine(activity.DisplaySummery());
        }

    }
}