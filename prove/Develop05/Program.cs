using System;
using System.Runtime.CompilerServices;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        bool done = false;
        var goals = new List<Goal>();
        var totalpoints = 0;
        while (!done)
        {
            Console.WriteLine($"You have {totalpoints} points.");
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
                        Console.Write(goals.IndexOf(goal) + 1 + ". ");
                        Console.WriteLine(goal.DisplayToUser());
                    }
                    break;
                case 3:
                    Console.WriteLine("Saving goals...");
                    string filename = "myFile.txt";
                        using (StreamWriter outputFile = new StreamWriter(filename))
                        {
                        foreach (var goal in goals)
                        {
                            outputFile.WriteLine(goal.Display());
                            }
                        }
                    break;
                case 4:
                    Console.WriteLine("Loading goals...");
                    
                    string savename = "myFile.txt";
                    string[] lines = File.ReadAllLines(savename);

                    foreach (string line in lines)
                    {
                        string[] parts = line.Split(" - ");
                        string gname = parts[0];
                        string gdescription = parts[1];
                        string gpoints = parts[2];
                        string grequirements = parts[3];
                        string gtype = parts[4];
                        switch (gtype)
                        {
                            case "Simple":
                                goals.Add(new SimpleGoal(gname, gdescription, int.Parse(gpoints), grequirements, gtype));
                                break;
                            case "Eternal":
                                goals.Add(new EternalGoal(gname, gdescription, int.Parse(gpoints), grequirements, gtype));
                                break;
                            case "Checklist":
                                string[] checklistParts = line.Split("-");
                                int timesCompleted = int.Parse(checklistParts[5]);
                                int timesUntilCompleted = int.Parse(checklistParts[6]);
                                goals.Add(new ChecklistGoal(gname, gdescription, int.Parse(gpoints), grequirements, timesUntilCompleted, gtype));
                                break;
                            default:
                                break;
                        }
                    }
                    break;
                case 5:
                    Console.WriteLine("Recording an event...");
                    Console.WriteLine("Enter the name of the goal to record an event for:");
                    string goalName = Console.ReadLine();
                    foreach (var goal in goals)
                    {
                        if (goal.GetName() == goalName)
                        {
                            goal.Complete();
                            if (goal.Gettype() == "Checklist")
                            {
                                var checklistGoal = goal as ChecklistGoal;
                                if (checklistGoal != null)
                                {
                                    if (checklistGoal.GetTimesCompleted() == checklistGoal.GetTimesUntilCompleted())
                                    {
                                        Console.WriteLine("Checklist goal completed!");
                                        totalpoints += goal.Complete();
                                    }
                                    else
                                    {
                                        goal.Complete();
                                        break;
                                    }
                                }
                            }
                            else
                            {
                                totalpoints += goal.Complete();
                            }
                        }
                    }
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