using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        string text = "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.";
        Scripture scripture = new Scripture(reference, text);

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.Write("Press Enter to hide words or type 'quit' to exit: ");
            string input = Console.ReadLine().Trim().ToLower();

            if (input == "quit")
                break;

            if (scripture.AllWordsHidden())
                break;

            scripture.HideRandomWords(3);
        }

        Console.WriteLine("\nAll memorized! Press Enter to exit.");
    }
}

class Reference
{
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int _endVerse;

    public Reference(string book, int chapter, int startVerse, int endVerse = -1)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse == -1 ? startVerse : endVerse;
    }

    public override string ToString()
    {
        if (_startVerse == _endVerse)
            return $"{_book} {_chapter}:{_startVerse}";
        else
            return $"{_book} {_chapter}:{_startVerse}-{_endVerse}";
    }
}

class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public string GetDisplayText()
    {
        if (_isHidden && _text.Trim().Length > 0)
            return new string('_', _text.Length);
        else
            return _text;
    }
}

class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private Random _random = new Random();

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
        string scriptureText = "";
        foreach (Word word in _words)
        {
            scriptureText += word.GetDisplayText() + " ";
        }
        return $"{_reference}\n{scriptureText.Trim()}";
    }

    public void HideRandomWords(int count)
    {
        List<int> visibleIndexes = new List<int>();
        for (int i = 0; i < _words.Count; i++)
        {
            if (!_words[i].IsHidden() && _words[i].GetDisplayText().Trim().Length > 0)
                visibleIndexes.Add(i);
        }

        int wordsToHide = Math.Min(count, visibleIndexes.Count);
        for (int i = 0; i < wordsToHide; i++)
        {
            int idx = _random.Next(visibleIndexes.Count);
            _words[visibleIndexes[idx]].Hide();
            visibleIndexes.RemoveAt(idx);
        }
    }

    public bool AllWordsHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden() && word.GetDisplayText().Trim().Length > 0)
                return false;
        }
        return true;
    }
}