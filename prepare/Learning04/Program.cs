using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        int number;
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when you're finished:");
        do{
            Console.WriteLine("Enter a number:");
            number = Convert.ToInt32(Console.ReadLine());
            if (number != 0)
            {
                numbers.Add(number);
            }
        }
        while (number != 0);
        Console.WriteLine("The sum is: " + numbers.Sum());
        Console.WriteLine("The average is: " + numbers.Average());
        Console.WriteLine("The largest number is: " + numbers.Max());
    }
}