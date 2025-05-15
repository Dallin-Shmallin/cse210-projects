using System;
using System.Security.Cryptography.X509Certificates;

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
    public string _choice;
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
        _choice = DisplayChoices();
        if (_choice == "1")
        {
            Console.WriteLine("Here is a prompt for you:");
            Random random = new Random();
            int index = random.Next(_prompts.Count);
            Console.WriteLine(_prompts[index]);
            Console.WriteLine("Please enter your journal entry:");
            string entry = Console.ReadLine();
        }
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

}
