using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        bool done = false;
        var goals = new List<Goal>();
        while (!done)
        {
            Console.WriteLine("Menu Options:\n 1. Create New Goal\n 2. List Goals\n 3. Save Goals\n 4. Load Goals\n 5. Record Event\n 6. Quit");
            switch (int.Parse(Console.ReadLine()))
            {
                case 1:
                    Console.WriteLine("The types of Goals are: \n 1. Simple Goal\n 2. Eternal Goal\n 3. Checklist Goal");
                    Console.WriteLine("Which type of goal would you like to create?");
                    int choice = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the name of the goal:");
                    string name = Console.ReadLine();
                    Console.WriteLine("Enter a description for the goal:");
                    string description = Console.ReadLine();
                    Console.WriteLine("Enter the points for the goal:");
                    int points = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the requirements for the goal:");
                    string requirements = Console.ReadLine();
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine();
                            var simple = new SimpleGoal(name, description, points, requirements, "Simple");
                            goals.Add(simple);
                            break;
                        case 2:
                            Console.WriteLine("Creating an Eternal Goal...");
                            var EternalGoal = new EternalGoal(name, description, points, requirements, "Eternal");
                            goals.Add(EternalGoal);
                            break;
                        case 3:
                            Console.WriteLine("Creating a Checklist Goal...");
                            Console.WriteLine("How many times does this goal need to be completed?");
                            int timesUntilCompleted = int.Parse(Console.ReadLine());
                            goals.Add(new ChecklistGoal(name, description, points, requirements, timesUntilCompleted, "Checklist"));
                            break;
                        default:
                            Console.WriteLine("Invalid choice. Please try again.");
                            break;
                    }
                    break;
                case 2:
                    Console.WriteLine("Listing goals...");
                    foreach (var goal in goals)
                    {
                        Console.WriteLine(goal.Display());
                    }
                    break;
                case 3:
                    Console.WriteLine("Saving goals...");
                    // Logic to save goals
                    break;
                case 4:
                    Console.WriteLine("Loading goals...");
                    // Logic to load goals
                    break;
                case 5:
                    Console.WriteLine("Recording an event...");
                    // Logic to record an event
                    break;
                case 6:
                    Console.WriteLine("Quitting the program.");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}