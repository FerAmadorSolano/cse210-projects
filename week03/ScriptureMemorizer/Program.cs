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

        // Create a library of scriptures and select one at random.
        ScriptureLibrary library = new ScriptureLibrary();
        Scripture scripture = library.GetRandomScripture();

        // Continue displaying the scripture until all words are hidden.
        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();

            // Display the current scripture.
            Console.WriteLine(scripture.GetDisplayText());

            // Ask the user to continue or quit.
            Console.WriteLine("Press Enter to continue or type 'quit':");

            string input = Console.ReadLine();

            // End the program if the user types "quit".
            if (input.ToLower() == "quit")
            {
                Console.WriteLine("Have an excellent day!");
                break;
            }

            // Hide three random visible words.
            scripture.HideRandomWords(3);
        }

        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());

        Console.WriteLine("");
        Console.WriteLine("All words are now hidden!");
        Console.WriteLine("Have an excellent day!");


    }
}