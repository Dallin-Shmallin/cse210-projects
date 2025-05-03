using System;

class Program
{

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }
    static string PromptUserName()
    {
        Console.WriteLine("Please enter your name:");
        string userName = Console.ReadLine();
        return userName;
    }
    static int PromptUserNumber()
    {
        Console.WriteLine("Please enter your favorite number:");
        int Number = Convert.ToInt32(Console.ReadLine());
        return Number;
    }
    static int SquareNumber(int Number)
    {
        return Number * Number;
    }
    static void DisplayResult(string userName, int Number, int squaredNumber)
    {
        Console.WriteLine($"Well then {userName}, your favorite number is {Number}, and its square is unsurprisingly {squaredNumber}.");
    }
    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName = PromptUserName();
        int Number = PromptUserNumber();
        int squaredNumber = SquareNumber(Number);
        DisplayResult(userName, Number, squaredNumber);
    }
}