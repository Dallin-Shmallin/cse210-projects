using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is the magic number?");
        int magic_number = Convert.ToInt32(Console.ReadLine());

        int guess;
        do
        {
            Console.WriteLine("What is your guess?");
            guess = Convert.ToInt32(Console.ReadLine());

            if (guess > magic_number)
            {
                Console.WriteLine("Higher");
            }
            else if (guess < magic_number)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
        while (guess != magic_number);
    }
}