using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName = PromptUserName();
        int userNum = PromptUserNumber();
        int squared = SquareNumber(userNum);
        DisplayResult(userName, squared);
    }


    static void DisplayWelcome() {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName() {
        Console.Write("Please enter your name? ");
        return Console.ReadLine();
    }

    static int PromptUserNumber() {
        Console.Write("Please enter your favorite number? ");
        return int.Parse(Console.ReadLine());
    }

    static int SquareNumber(int num) {
        return num * num;
    }

    static void DisplayResult(string name, int square) {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
}