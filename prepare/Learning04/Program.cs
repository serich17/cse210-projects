using System;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment mathAssignment = new MathAssignment("Samuel Bennett", "Multiplication", "7.3", "8-19");
        WritingAssignment writingAssignment = new WritingAssignment("Mary Waters", "European History", "The Causes of World WarII");

        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());


        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingInformation());





    }
}