/* 
Author: Luisa Fernanda Amador Solano

Description: A personal journal application that allows users to write, save, and review entries while tracking their mood for a more personalized experience.

*/
class Program
{
    static void Main(string[] args)
    {
        Journal theJournal = new Journal();
        PromptGenerator generatePrompt = new PromptGenerator();
        int option = 0;

        //Ask the user for the option

        do
        {
            Console.WriteLine("");
            Console.WriteLine("Journal Menu");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");

            Console.Write("What would you like to do? ");
            option = int.Parse(Console.ReadLine());

            if (option == 1)
            {
                // Create a new Entry
                Entry anEntry = new Entry();

                // Show the user the prompt
                string prompt = generatePrompt.GetRandomPrompt();
                Console.WriteLine(prompt);

                // Read the answer
                string response = Console.ReadLine();

                // Ask for the mood of the user
                Console.WriteLine();
                Console.WriteLine("How are you feeling today? (Enter just the number)");
                Console.WriteLine("1 - 😊 Great");
                Console.WriteLine("2 - 🙂 Good");
                Console.WriteLine("3 - 😐 Okay");
                Console.WriteLine("4 - 😔 Bad");
                Console.WriteLine("5 - 😢 Terrible");

                Console.Write("Choose an option: ");
                int moodOption = int.Parse(Console.ReadLine());

                // Change the mood
                string mood = "";

                switch (moodOption)
                {
                    case 1:
                        mood = "😊 Great";
                        break;

                    case 2:
                        mood = "🙂 Good";
                        break;

                    case 3:
                        mood = "😐 Okay";
                        break;

                    case 4:
                        mood = "😔 Bad";
                        break;

                    case 5:
                        mood = "😢 Terrible";
                        break;

                    default:
                        mood = "Unknown";
                        break;
                }

                // Get the date
                string date = DateOnly.FromDateTime(DateTime.Today).ToString();

                // Save the prompt and the response
                anEntry._promptText = prompt;
                anEntry._entryText = response;
                anEntry._date = date;
                anEntry._mood = mood;

                // Add the response to the Journal
                theJournal.AddEntry(anEntry);
            }
            else if (option == 2)
            {
                // Display the Entries
                theJournal.DisplayJournal();
            }
            else if (option == 3)
            {
                // Ask for the filename
                Console.WriteLine("What is the filename?");

                // Read the answer
                string filename = Console.ReadLine();
                theJournal.LoadFromFile(filename);

                Console.WriteLine("------------ The entries have been loaded ------------");
            }
            else if (option == 4)
            {
                // Ask for the filename
                Console.WriteLine("What is the filename?");

                // Read the answer
                string filename = Console.ReadLine();
                theJournal.SaveToFile(filename);

                Console.WriteLine("------------ The entries have been saved ------------");

            }
            else if (option == 5)
            {
                Console.WriteLine("Have a nice day! :)");
            }
            else
            {
                Console.WriteLine("Sorry, that's not an option :( ");
            }
        } while (option != 5);
    }
}