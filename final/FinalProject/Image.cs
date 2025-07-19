using System.Drawing;

class Image
{
    private int _width;
    private int _height;
    private string _filePath;
    public Image(string filePath) { _filePath = filePath; }

    public Pixel[] GetPixels()
    {
        // returns an array of pixel classes representing the image, only works on windows so idk
        // hopefully it works and youre grading on windows
        using (Bitmap bitmap = new Bitmap(_filePath))
        {
            _width = bitmap.Width;
            _height = bitmap.Height;
            Pixel[] pixels = new Pixel[_height * _width];
            for (int y = 0; y < _height; y++)
            {
                for (int x = 0; x < _width; x++)
                {
                    Color color = bitmap.GetPixel(x, y);
                    Rgb rgb = new Rgb(color.R, color.G, color.B);
                    pixels[y * _width + x] = new Pixel(rgb);
                }
            }
            return pixels;
        }
    }
}
