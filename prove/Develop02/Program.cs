using System;
using System.Security.Cryptography.X509Certificates;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        journal.InteractWithUser();
    }
}
class Journal
{
    public List<string> _prompts = new List<string>();
    public List<Entry> _entries = new List<Entry>();

    public Journal()
    {
        _prompts.Add("What was the best part of your day?");
        _prompts.Add("What was the worst part of your day?");
        _prompts.Add("What did you learn today?");
        _prompts.Add("What are you grateful for?");
    }

    public void InteractWithUser()
    {
        while (true)
        {
            string choice = DisplayChoices();
            switch (choice)
            {
                case "1":
                    Write();
                    break;
                case "2":
                    Display();
                    break;
                case "3":
                    Load();
                    break;
                case "4":
                    Save();
                    break;
                case "5":
                    Quit();
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.\n");
                    break;
            }
        }
    }

    public void Write()
    {
        Console.WriteLine("Here is a prompt for you:");
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        string prompt = _prompts[index];
        Console.WriteLine(prompt);
        Console.WriteLine("Please enter your journal entry:");
        string entryText = Console.ReadLine();
        string date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        Entry entry = new Entry
        {
            _date = date,
            _prompt = prompt,
            _entry = entryText
        };
        _entries.Add(entry);
        Console.WriteLine("Entry saved!\n");
    }

    public void Display()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No entries to display.\n");
            return;
        }
        foreach (Entry entry in _entries)
        {
            entry.DisplayEntry();
        }
    }

    public void Save()
    {
        Console.Write("Enter filename to save to: ");
        string filename = Console.ReadLine();
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                writer.WriteLine($"{entry._date}|{entry._prompt}|{entry._entry}");
            }
        }
        Console.WriteLine("Journal saved!\n");
    }

    public void Load()
    {
        Console.Write("Enter filename to load from: ");
        string filename = Console.ReadLine();
        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.\n");
            return;
        }
        _entries.Clear();
        foreach (string line in File.ReadAllLines(filename))
        {
            string[] parts = line.Split('|');
            if (parts.Length == 3)
            {
                Entry entry = new Entry
                {
                    _date = parts[0],
                    _prompt = parts[1],
                    _entry = parts[2]
                };
                _entries.Add(entry);
            }
        }
        Console.WriteLine("Journal loaded!\n");
    }

    public void Quit()
    {
        Console.WriteLine("Goodbye!");
        Environment.Exit(0);
    }

    public string DisplayChoices()
    {
        Console.WriteLine("Please select one of the following choices:");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        return Console.ReadLine();
    }
}

class Entry
{
    public string _entry;
    public string _date;
    public string _prompt;

    public void DisplayEntry()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_prompt}");
        Console.WriteLine($"Entry: {_entry}\n");
    }
}
