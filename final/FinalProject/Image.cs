class Image
{
    private string _filePath;
    public Image(string filePath) { _filePath = filePath; }
    public Pixel[,] GetPixels()
    {
        // Load image and return 2D array of Pixels
        // (Stub: implement with System.Drawing or ImageSharp)
        return new Pixel[100, 100];
    }
}