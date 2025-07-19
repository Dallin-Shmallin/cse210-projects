using System;
using System.IO;
class ImageManager
{
    public Image LoadImage(string filePath)
    {
        return new Image(filePath);
    }

    public Pixel[] ParseToPixels(Image image)
    {
        Pixel[] pixelarray = image.GetPixels();
        return pixelarray;
    }

    public PixelRow[] CreatePixelRows(Pixel[] pixels, int width, int height)
    {
        PixelRow[] rows = new PixelRow[height];
        for (int i = 0; i < height; i++)
        {
            Pixel[] rowPixels = new Pixel[width];
            Array.Copy(pixels, i * width, rowPixels, 0, width);
        }
        return rows;
    }

    public PixelColumn[] CreatePixelColumns(Pixel[] pixels, int width, int height)
    {
        PixelColumn[] columns = new PixelColumn[width];
        for (int i = 0; i < width; i++)
        {
            Pixel[] colPixels = new Pixel[height];
            for (int j = 0; j < height; j++)
            {
                colPixels[j] = pixels[j * width + i];
            }
        }
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
                sb.Append(characters[y, x].Display());
            sb.AppendLine();
        }
        return sb.ToString();
    }
}