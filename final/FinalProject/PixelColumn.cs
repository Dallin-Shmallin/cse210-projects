class PixelColumn
{
    private Pixel[] _pixels;
    public PixelColumn(Pixel[,] pixels, int col)
    {
        int height = pixels.GetLength(0);
        _pixels = new Pixel[height];
        for (int i = 0; i < height; i++)
            _pixels[i] = pixels[i, col];
    }
    public Pixel[] GetPixels() => _pixels;
}