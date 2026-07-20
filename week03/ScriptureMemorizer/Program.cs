/* 
Author: Luisa Fernanda Amador Solano

Description: Program that helps users memorize scriptures by hiding random words each time they press Enter until the entire scripture is hidden. It uses separate classes for the reference, scripture, and words to keep the code organized. As an extra feature, I added a ScriptureLibrary class that stores several scriptures and randomly selects one each time the program starts. I also made sure that only visible words are hidden, so the same word is not selected twice.
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("John", 3, 16);
        ScriptureLibrary library = new ScriptureLibrary();

        Scripture scripture = library.GetRandomScripture();

        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());

            Console.WriteLine("Press Enter to continue or type 'quit':");

            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                Console.WriteLine("Have an excellent day!");
                break;
            }

            scripture.HideRandomWords(3);
        }

        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());

        Console.WriteLine("\nAll words are now hidden!");
        Console.WriteLine("Have an excellent day!");


    }
}