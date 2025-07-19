using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the filepath of the image to convert to ASCII art:");
        string imagePath = Console.ReadLine();

        Console.WriteLine("Do you want this image to be in color or black and white? (c/b)");
        string choice = Console.ReadLine();

        ImageManager imageManager = new ImageManager();
        Image image = imageManager.LoadImage(imagePath);

        Pixel[] pixels = imageManager.ParseToPixels(image);
        // make sure the image is 1080 by 1920
        PixelRow[] pixelRows = imageManager.CreatePixelRows(pixels,1080, 1920);
        PixelColumn[] pixelColumns = imageManager.CreatePixelColumns(pixels,1080,1920);

        PixelCluster[,] clusters = imageManager.CreatePixelClusters(pixelRows, pixelColumns);

        Character[,] characters;
        if (choice.ToLower() == "b")
        {
            characters = imageManager.GenerateCharacters(clusters, false);
        }
        else if (choice.ToLower() == "c")
        {
            characters = imageManager.GenerateCharacters(clusters, true);
        }
        else
        {
            Console.WriteLine("uhh not sure what you entered so ima do black and white");
            characters = imageManager.GenerateCharacters(clusters, false);
        }

        string asciiArt = imageManager.ConvertCharactersToAscii(characters);

        string savePath = FilePathManager.GetAsciiFilePath(imagePath);
        FilePathManager.SaveAsciiArtToFile(asciiArt, savePath);

        Console.WriteLine($"ASCII text art saved to {savePath}");
    }
}
