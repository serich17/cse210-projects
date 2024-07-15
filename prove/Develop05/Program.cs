using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        goalManager.Start();
    }
}

// to exceed the requirements, I added a "point summery" option to show the goals that have been completed at least once and show how many points were gained.