using System;

class Program
{
    static void Main(string[] args)
    {
        Running running = new Running(30, 3);
        Console.WriteLine(running.DisplaySummery());

        Swimming swimming = new Swimming(22, 4);
        Console.WriteLine(swimming.DisplaySummery());

        Cycling cycling = new Cycling(27, 5);
        Console.WriteLine(cycling.DisplaySummery());


    }
}