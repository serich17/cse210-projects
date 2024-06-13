using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomgenerator = new Random();
        string play = "yes";

        while (play == "yes") {
        
        int magic = randomgenerator.Next(1,100);
        int numGuesses = 1;

        Console.Write("What is your guess? ");
        int guess = int.Parse(Console.ReadLine());


        while (guess != magic) {
            if (guess > magic) {
                Console.WriteLine("Lower");
            }
            else if (guess < magic) {
                Console.WriteLine("Higher");
            }

            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());
            numGuesses += 1;

        } 

        Console.WriteLine($"You guessed it! You used {numGuesses} guesses.");


        Console.Write("Do you want to play again?('yes' to continue) ");
        play = Console.ReadLine();
        }
    }
}