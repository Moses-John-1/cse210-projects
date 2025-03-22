using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    /* Here I displays the scripture with hidden words as underscores*/
    public void Display()
    {
        Console.WriteLine($"{_reference.GetDisplayText()} -");
        Console.WriteLine(string.Join(" ", _words.Select(word => word.GetDisplayText())));
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        List<Word> visibleWords = _words.Where(word => !word.IsHidden()).ToList();

        if (visibleWords.Count == 0) return;

        for (int i = 0; i < numberToHide && visibleWords.Count > 0; i++)
        {
            int index = random.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index); 
        }
    }

    /* Here I checks if all words are hidden */
    public bool AllWordsHidden()
    {
        return _words.All(word => word.IsHidden());
    }
}
