class PixelCluster
{
    private Pixel[] _pixels;
    public PixelCluster(PixelRow[] rows, PixelColumn[] columns, int rowIdx, int colIdx)
    {
        // Gather pixels for this cluster from rows/columns
        // (Stub: implement logic for cluster size and pixel selection)
        _pixels = new Pixel[1]; // placeholder
    }
    public Pixel[] GetPixels() => _pixels;
}