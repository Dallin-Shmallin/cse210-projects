using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
class Program
{
    static void Main(string[] args)
    {
        ImageManager imageManager = new ImageManager();
        string imagePath = imageManager.GetDesktopBackground();
        Console.WriteLine($"Desktop background image path found at {imagePath}");
        Console.WriteLine("Would you like this image to be in color or black and white? (c/b)");
        string choice = Console.ReadLine();
        if (choice == "c")
        {
            Console.WriteLine("It will be in color");
        }
        else {
            Console.WriteLine("It will be in black and white");
        }
        Console.WriteLine("Converting image to ASCII");
        Console.WriteLine("what image path would you like to save the ASCII image to?");
        string savePath = Console.ReadLine();
        Console.WriteLine("saving ASCII image to file");
        Console.WriteLine($"ASCII image saved to {savePath}");
    }
}
