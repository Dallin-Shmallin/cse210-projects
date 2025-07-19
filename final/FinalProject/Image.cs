using System.Drawing;

class Image
{
    private string _filePath;
    public Image(string filePath) { _filePath = filePath; }
    public Pixel[,] GetPixels()
    {
        using (Bitmap bitmap = new Bitmap(_filePath))
        {
            int width = bitmap.Width;
            int height = bitmap.Height;
            Pixel[,] pixels = new Pixel[width, height];
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    Color color = bitmap.GetPixel(x, y);
                    pixels[x, y] = new Pixel(new Rgb(color.R, color.G, color.B));
                }
            }
            return pixels;
        }
    }
}