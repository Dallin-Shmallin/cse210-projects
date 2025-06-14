using System;
class ListingExercise : Exercise
{
    private List<string> _prompts = new List<string> {};
    private List<string> _responses = new List<string> {};
    public ListingExercise(string title, string description) 
    : base(title, description)
    {
        _title = title;
        _description = description;
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are some personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");
    }
    public void StartListingExercise()
    {
        StartActivity();
        Console.WriteLine("List as many responses as you can to the following prompt:");
        Random random = new Random();
        int randomIndex = random.Next(_prompts.Count);
        Console.WriteLine(_prompts[randomIndex]);
        Thread.Sleep(2000);
        DisplayGetReady(3000);
        DateTime startTime = DateTime.Now;
        while ((DateTime.Now - startTime).TotalSeconds < _waitTime / 1000)
        {
            Console.Write($"\n>");
            string response = Console.ReadLine();
            _responses.Add(response);

        }
        Console.WriteLine($"\nYou listed {_responses.Count} items!");
        EndActivity();
    }
}