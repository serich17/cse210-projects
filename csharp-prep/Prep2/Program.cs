using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        int grade = int.Parse(Console.ReadLine());
        
        string letter;
        string sign = "";

        if (grade >= 90) {
            letter = "A";
        }
        else if (grade >= 80) {
            letter = "B";
        }
        else if (grade >= 70) {
            letter = "C";
        }
        else if (grade >= 60) {
            letter = "D";
        }
        else {
            letter = "F";
        }

        int remainder = grade%10;
        if ((letter == "A" && remainder >=7) || letter == "F") {
            sign = "";
        }
        else if (remainder >= 7) {
            sign = "+";
        }
        else if (remainder <= 3) {
            sign = "-";
        }


        Console.WriteLine($"Your grade is {letter}{sign}");

        
        if (grade >= 70) {
            Console.WriteLine("Congratulations!! You've passed the class");
        }
        else {
            Console.WriteLine("You didn't pass the class. Keep working hard, maybe next time.");
        }

    }
}