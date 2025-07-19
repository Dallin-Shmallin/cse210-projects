class PixelCluster
{
    private Pixel[] _pixels;
    private int _clusterHeight = 10;
    private int _clusterWidth = 10;

    public PixelCluster(PixelRow[] rows, PixelColumn[] columns, int rowIdx, int colIdx)
    {
        int startRow = rowIdx * _clusterHeight;
        int startCol = colIdx * _clusterWidth;

        var pixelList = new System.Collections.Generic.List<Pixel>();
        for (int r = startRow; r < startRow + _clusterHeight && r < rows.Length; r++)
        {
            Pixel[] rowPixels = rows[r].GetPixels();
            for (int c = startCol; c < startCol + _clusterWidth && c < rowPixels.Length; c++)
            {
                pixelList.Add(rowPixels[c]);
            }
        }
        _pixels = pixelList.ToArray();
    }

    public Pixel[] GetPixels() => _pixels;

    public string ToAsciiChar()
    {
        if (_pixels.Length == 0) return " ";

        // ASCII gradient from dark to light
        string asciiChars = "@%#*+=-:. ";
        double totalBrightness = 0;

        foreach (var pixel in _pixels)
        {
            Rgb color = pixel.GetColor();
            // weird formula to calculate brightness
            double brightness = 0.299 * color.R + 0.587 * color.G + 0.114 * color.B;
            totalBrightness += brightness;
        }

        double avgBrightness = totalBrightness / _pixels.Length;
        int index = (int)(avgBrightness / 255.0 * (asciiChars.Length - 1));
        index = asciiChars.Length - 1 - index;

        return asciiChars[index].ToString();
    }
}