using System;
using System.IO;
class ImageManager
{
    public ImageManager()
    {
    }
    public void GetReadableImage() { }
    public void SetDesktopBackground(){}

    public Image LoadImage(string filePath)
    {
        return new Image(filePath);
    }

    public Pixel[,] ParseToPixels(Image image)
    {
        return image.GetPixels();
    }

    public PixelRow[] CreatePixelRows(Pixel[,] pixels)
    {
        int height = pixels.GetLength(0);
        PixelRow[] rows = new PixelRow[height];
        for (int i = 0; i < height; i++)
            rows[i] = new PixelRow(pixels, i);
        return rows;
    }

    public PixelColumn[] CreatePixelColumns(Pixel[,] pixels)
    {
        int width = pixels.GetLength(1);
        PixelColumn[] columns = new PixelColumn[width];
        for (int i = 0; i < width; i++)
            columns[i] = new PixelColumn(pixels, i);
        return columns;
    }

    public PixelCluster[,] CreatePixelClusters(PixelRow[] rows, PixelColumn[] columns)
    {
        int clusterHeight = rows.Length / 10;
        int clusterWidth = columns.Length / 10;
        PixelCluster[,] clusters = new PixelCluster[clusterHeight, clusterWidth];
        for (int y = 0; y < clusterHeight; y++)
            for (int x = 0; x < clusterWidth; x++)
                clusters[y, x] = new PixelCluster(rows, columns, y, x);
        return clusters;
    }

    public Character[,] GenerateCharacters(PixelCluster[,] clusters, bool color)
    {
        int height = clusters.GetLength(0);
        int width = clusters.GetLength(1);
        Character[,] chars = new Character[height, width];
        for (int y = 0; y < height; y++)
            for (int x = 0; x < width; x++)
                chars[y, x] = color
                    ? new CharacterColor(clusters[y, x])
                    : new CharacterBW(clusters[y, x]);
        return chars;
    }

    public string ConvertCharactersToAscii(Character[,] characters)
    {
        int height = characters.GetLength(0);
        int width = characters.GetLength(1);
        System.Text.StringBuilder sb = new System.Text.StringBuilder();
        for (int y = 0; y < height; y++)
        {
            for (int x = 0; x < width; x++)
                sb.Append(characters[y, x].ToAscii());
            sb.AppendLine();
        }
        return sb.ToString();
    }
}