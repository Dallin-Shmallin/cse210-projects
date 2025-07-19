using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the filepath of the image to convert to ASCII art:");
        string imagePath = Console.ReadLine();

        Console.WriteLine("Would you like this image to be in color or black and white? (c/b)");
        string choice = Console.ReadLine();

        ImageManager imageManager = new ImageManager();
        Image image = imageManager.LoadImage(imagePath);

        Pixel[,] pixels = imageManager.ParseToPixels(image);
        PixelRow[] pixelRows = imageManager.CreatePixelRows(pixels);
        PixelColumn[] pixelColumns = imageManager.CreatePixelColumns(pixels);

        PixelCluster[,] clusters = imageManager.CreatePixelClusters(pixelRows, pixelColumns);

        Character[,] characters = imageManager.GenerateCharacters(clusters, choice == "c");

        string asciiArt = imageManager.ConvertCharactersToAscii(characters);

        string savePath = FilePathManager.GetAsciiFilePath(imagePath);
        FilePathManager.SaveAsciiArtToFile(asciiArt, savePath);

        Console.WriteLine($"ASCII text art saved to {savePath}");
    }
}
