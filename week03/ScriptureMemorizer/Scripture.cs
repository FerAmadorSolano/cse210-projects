using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    // Generates random numbers to select words to hide.
    private Random _random = new Random();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        // Split the scripture text into individual words.
        string[] words = text.Split(' ');

        // Create a Word object for each word and add it to the list.
        foreach (string word in words)
        {
            _words.Add(new Word(word));
        }
    }

    // Randomly hides the specified number of visible words.
    public void HideRandomWords(int numberToHide)
    {
        int hidden = 0;

        while (hidden < numberToHide && !IsCompletelyHidden())
        {
            int index = _random.Next(_words.Count);

            // Hide the word only if it is still visible.
            if (!_words[index].IsHidden())
            {
                _words[index].Hide();
                hidden++;
            }
        }
    }

    // Returns the scripture reference and the current state of its words.
    public string GetDisplayText()
    {
        string text = "";
        foreach (Word word in _words)
        {
            text += word.GetDisplayText() + " ";
        }

        return $"{_reference.GetDisplayText()}\n\n{text}";
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }

        return true;
    }
}