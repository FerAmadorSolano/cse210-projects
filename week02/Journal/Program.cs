using System;
using System.Numerics;
using System.Reflection.Emit;

class Program
{
    static void Main(string[] args)
    {
        Journal theJournal = new Journal();
        Entry anEntry = new Entry();
        anEntry.Display();
        int option = 0;

        //Ask the user for the option

        do
        {
            Console.WriteLine("Journal Menu");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit");

            Console.Write("What would you like to do?");
            option = int.Parse(Console.ReadLine());
        } while (option != 5);
    }
}