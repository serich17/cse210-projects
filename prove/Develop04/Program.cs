using System;
using System.ComponentModel.Design;

class Program
{
    static void Main(string[] args)
    {
        string menu = "";
        int breathing = 0;
        int reflecting = 0;
        int listing = 0;

        while (menu != "4") {
            Console.Clear();
            Console.WriteLine("Menu Options:" +
            "\n1. Start breathing activity" +
            "\n2. Start reflecting activity" +
            "\n3. Start listing activity" +
            "\n4. Quit");

            Console.Write("Select a choice from the screen: ");
            menu = Console.ReadLine();

            if (menu == "1") {
                BreathingActivity breathingActivity = new BreathingActivity();
                breathingActivity.Run();
                breathing ++;
            }
            else if (menu == "2") {
                ReflectingActivity reflectingActivity = new ReflectingActivity();
                reflectingActivity.Run();
                reflecting ++;
            }
            else if (menu == "3") {
                ListingActivity listingActivity = new ListingActivity();
                listingActivity.Run();
                listing ++;
            }
            else if (menu == "4") {
                break;
            }
            else {
                Console.WriteLine("Please enter a valid option");
            }

        }

        //Display how many times activities were done.
        Console.WriteLine($"\nYou did {breathing + reflecting + listing} activities today!");
        Console.WriteLine($"-Breathing Activity: {breathing}\n-Reflecting Activity: {reflecting}\n-Listing Activity: {listing}");

    }
}

//to exceed the requirements, I added variables to keep track of every time I used an activity and displayed the results at the end