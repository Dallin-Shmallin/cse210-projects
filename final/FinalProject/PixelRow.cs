class PixelRow
{
    private Pixel[] _pixels;
    public PixelRow(Pixel[,] pixels, int row)
    {
        int width = pixels.GetLength(1);
        _pixels = new Pixel[width];
        for (int i = 0; i < width; i++)
            _pixels[i] = pixels[row, i];
    }
    public Pixel[] GetPixels() => _pixels;
}
