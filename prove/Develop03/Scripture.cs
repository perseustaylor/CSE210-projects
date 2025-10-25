using System;
using System.Collections.Generic;

class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();  
        foreach (string word in text.Split(' '))
        {
            _words.Add(new Word(word));
        }
    }

    public string GetDisplayText()
    {
        string displayText = _reference.DisplayReference() + " ";
        foreach (Word word in _words)
        {
            displayText += word.GetDisplay() + " ";
        }
        return displayText;

    }

    public void Hidewords(int maxWordsToHide)
    {
        // Random random = new Random();
        // int wordsToHide = random.Next(1, _words.Count);
        // int hiddenCount = 0;
        // while (hiddenCount < wordsToHide)
        // {
        //     int index = random.Next(_words.Count);
        //     if (!_words[index].IsHidden())
        //     {
        //         _words[index].HideWord();
        //         hiddenCount++;
        //     }
        List<Word> visibleWords = new List<Word>();
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                visibleWords.Add(word);
            }
        }
        if (visibleWords.Count == 0)
            return;
        Random random = new Random();
        int wordsToHide = Math.Min(random.Next(1, maxWordsToHide + 1), visibleWords.Count);
        for (int i = 0; i < wordsToHide; i++)
        {
            int index = random.Next(visibleWords.Count);
            visibleWords[index].HideWord();
            visibleWords.RemoveAt(index);
        }
    }
    public void DisplayScripture()
    {
        Console.WriteLine(GetDisplayText());
    }
    public bool AllWordsHidden()
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



