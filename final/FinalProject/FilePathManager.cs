using System.IO;
static class FilePathManager
{
    public static string GetAsciiFilePath(string imagePath)
    {
        string dir = Path.GetDirectoryName(imagePath);
        string fileName = Path.GetFileNameWithoutExtension(imagePath) + "_ascii.txt";
        return Path.Combine(dir, fileName);
    }

    public static void SaveAsciiArtToFile(string asciiArt, string savePath)
    {
        File.WriteAllText(savePath, asciiArt);
    }
}