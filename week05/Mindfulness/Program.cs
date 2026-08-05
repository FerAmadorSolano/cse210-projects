/* 
Author: Luisa Fernanda Amador Solano

Description: Program that helps users complete three activities:
Breathing, Reflection, and Listing. Each activity guides the user
through a mindfulness exercise using countdowns and animations. I added an Activity Log that keeps track of how many times each
activity is completed during the session. Users can view this log
from the main menu.
*/


using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        int option = 0;
        int breathingCount = 0;
        int reflectingCount = 0;
        int listingCount = 0;

        do
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("     1. Start Breathing Activity");
            Console.WriteLine("     2. Start Reflecting Activity");
            Console.WriteLine("     3. Start Listing Activity");
            Console.WriteLine("     4. View Activity Log");
            Console.WriteLine("     5. Quit");
            Console.Write("Select a choice from the menu: ");
            option = int.Parse(Console.ReadLine());

            if (option == 1)
            {
                BreathingActivity breath = new BreathingActivity();
                breath.Run();
                breathingCount++;

            }
            else if (option == 2)
            {
                ReflectingActivity reflect = new ReflectingActivity();
                reflect.Run();
                reflectingCount++;

            }
            else if (option == 3)
            {
                ListingActivity list = new ListingActivity();
                list.Run();
                listingCount++;

            }
            else if (option == 4)
            {
                Console.Clear();

                Console.WriteLine("Activity Log");
                Console.WriteLine("-----------------------");
                Console.WriteLine($"Breathing Activities: {breathingCount}");
                Console.WriteLine($"Reflection Activities: {reflectingCount}");
                Console.WriteLine($"Listing Activities: {listingCount}");

                Console.WriteLine();
                Console.WriteLine($"Total Activities: {breathingCount + reflectingCount + listingCount}");

                Console.WriteLine();
                Console.Write("Press Enter to continue...");
                Console.ReadLine();
            }
            else if (option == 5)
            {
                Console.WriteLine("I hope you enjoyed :) Goodbye!");
            }
            else
            {
                Console.WriteLine("That's not a valid option, try again :)");
                Console.WriteLine("Press Enter to continue...");
                Console.ReadLine();
            }

        } while (option != 5);
    }
}