using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
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
                switch (choice)
                {
                    case 1:
                        Console.WriteLine();
                        // Logic to create a Simple Goal
                        break;
                    case 2:
                        Console.WriteLine("Creating an Eternal Goal...");
                        // Logic to create an Eternal Goal
                        break;
                    case 3:
                        Console.WriteLine("Creating a Checklist Goal...");
                        // Logic to create a Checklist Goal
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
                break;
            case 2:
                Console.WriteLine("Listing goals...");
                // Logic to list goals
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