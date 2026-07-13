using System;

public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;
    public string _mood;

    public Entry()
    {

    }

    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine("Prompt:");
        Console.WriteLine($"{_promptText}");
        Console.WriteLine("Answer:");
        Console.WriteLine($"{_entryText}");
        Console.WriteLine("Mood:");
        Console.WriteLine($"{_mood}");
        Console.WriteLine("");
    }
}