using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        bool done = false;
        while (!done)
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Mindfulness App!");
            Console.WriteLine("Please select an activity:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Listing Activity");
            Console.WriteLine("3. Reflection Activity");
            Console.WriteLine("4. Quit");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    BreathExercise breathExercise = new BreathExercise("Breath", "This exercise helps you take time to take deep breaths");
                    breathExercise.StartBreathExercise();
                    break;
                case "2":
                    ListingExercise listingExercise = new ListingExercise("Listing", "This exercise features listing things to help you process your life");
                    listingExercise.StartListingExercise();
                    break;
                case "3":
                    ReflectionExercise reflectionExercise = new ReflectionExercise("Reflection", "This exercise features reflecting and pondering deeply about different happenings");
                    reflectionExercise.StartReflectionExercise();
                    break;
                case "4":
                    done = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice, please try again.");
                    break;
            }
        }
    }
}
class Exercise
{
    protected int _waitTime;
    protected string _title;
    protected string _description;
    public Exercise(string title, string description)
    {
        _title = title;
        _description = description;
    }
    public void EndActivity()
    {
        Console.WriteLine($"Good job!\n\nYou have completed the {_title} activity for {_waitTime / 1000} seconds.");
        Thread.Sleep(4000);
    }
    public void StartActivity()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_title} Activity");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.WriteLine("How long, in seconds, would you like for your session? ");
        string input = Console.ReadLine();
        bool isValid = int.TryParse(input, out _waitTime);
        while (!isValid || _waitTime <= 0)
        {
            Console.WriteLine("Please enter a valid number greater than 0.");
            input = Console.ReadLine();
            isValid = int.TryParse(input, out _waitTime);
        }
        Console.WriteLine($"Your session will last for {_waitTime} seconds.");
        _waitTime = int.Parse(input) * 1000;
        DisplayGetReady(2000);

    }
    public void DisplayGetReady(int waitTime)
    {
        Console.WriteLine("Get Ready...");
        DisplayLoadingAnimation(waitTime);
    }
    public void DisplayLoadingAnimation(double duration)
    {
        duration /= 2000;
        for (int i = 0; i < duration; i++)
        {
            Console.Write("\b|");
            Thread.Sleep(500);
            Console.Write("\b/");
            Thread.Sleep(500);
            Console.Write("\b-");
            Thread.Sleep(500);
            Console.Write("\b\\");
            Thread.Sleep(500);
        }
        Console.WriteLine("\b ");
    }

}