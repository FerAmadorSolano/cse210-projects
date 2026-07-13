using System;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public Journal()
    {

    }

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayJournal()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}|{entry._promptText}|{entry._entryText}|{entry._mood}");
            }
        }
    }

    public void LoadFromFile(string file)
    {
        //Clean the list so we don't have duplicates
        _entries.Clear();

        // We read the lines in the file
        string[] lines = File.ReadAllLines(file);

        // Separate each line in their correct form
        foreach (string line in lines)
        {
            string[] parts = line.Split('|');

            Entry entry = new Entry();
            entry._date = parts[0];
            entry._promptText = parts[1];
            entry._entryText = parts[2];
            entry._mood = parts[3];

            AddEntry(entry);
        }

    }
}