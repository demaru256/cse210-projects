using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private Random _random = new Random();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] splitWords = text.Split(" ");
        foreach (string word in splitWords)
        {
            _words.Add(new Word(word));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        for (int i = 0; i < numberToHide; i++)
        {
            // Only hide words not yet hidden (creative improvement)
            List<Word> visibleWords = _words.FindAll(w => !w.IsHidden());
            if (visibleWords.Count == 0) return;

            Word wordToHide = visibleWords[_random.Next(visibleWords.Count)];
            wordToHide.Hide();
        }
    }

    public string GetDisplayText()
    {
        string result = _reference.GetDisplayText() + " ";

        foreach (Word word in _words)
        {
            result += word.GetDisplayText() + " ";
        }

        return result.Trim();
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden()) return false;
        }
        return true;
    }

    // Creative enhancement: progress percentage
    public int GetHiddenPercentage()
    {
        int hiddenCount = 0;

        foreach (Word word in _words)
        {
            if (word.IsHidden()) hiddenCount++;
        }

        return (_words.Count == 0) ? 100 : (hiddenCount * 100) / _words.Count;
    }
}