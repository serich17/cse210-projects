using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished");
        int end=1;
        List<int> number = new List<int>();

        while (end != 0) {
            Console.Write("Enter number: ");
            int inputNum = int.Parse(Console.ReadLine());

            if (inputNum == 0) {
                end = 0;
            }
            else {
                number.Add(inputNum);
            }
        }

        int sum = number.Sum();
        double avr = number.Average();
        int large = number.Max();

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {avr}");
        Console.WriteLine($"The largest number is: {large}");


    }
}