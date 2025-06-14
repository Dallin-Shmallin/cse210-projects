class ReflectionExercise : Exercise
{
    private List<string> _prompts = new List<string> { };
    private List<string> _questions = new List<string> { };
    public ReflectionExercise(string title, string description)
        : base(title, description)
    {
        _title = title;
        _description = description;
        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you helped someone in need.");
    }
    public void StartReflectionExercise()
    {
        StartActivity();
        Console.WriteLine("Reflect on the following prompt:");
        Random random = new Random();
        int randomIndex = random.Next(_prompts.Count);
        Console.WriteLine(_prompts[randomIndex]);
        Console.WriteLine("How did you feel when it was complete?");
        DisplayLoadingAnimation(_waitTime / 2);
        Console.WriteLine("What is your favorite thing about this experience?");
        DisplayLoadingAnimation(_waitTime / 2);
        EndActivity();
    }
}