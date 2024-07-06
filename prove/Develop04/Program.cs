using System;
using System.ComponentModel.Design;

class Program
{
    static void Main(string[] args)
    {
        string menu = "";

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
            }
            else if (menu == "2") {
                ReflectingActivity reflectingActivity = new ReflectingActivity();
                reflectingActivity.Run();
            }
            else if (menu == "3") {
                ListingActivity listingActivity = new ListingActivity();
                listingActivity.Run();
            }
            else if (menu == "4") {
                break;
            }
            else {
                Console.WriteLine("Please enter a valid option");
            }

        }

    }
}