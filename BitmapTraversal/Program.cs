using System.Drawing;

try
{
    Bitmap image1;
    string bitmapPath;
    int x, y;
    List<string> centerCoordinates = new List<string>();
    Console.WriteLine("Please enter the path for the bitmap file...");
    bitmapPath = Console.ReadLine();
    image1 = new Bitmap(@$"{bitmapPath}");

    Boolean CheckAllNeighbors(Bitmap matrix, int x, int y, int value)
    {
        List<bool> neighbors = new List<bool>();
        if (matrix.GetPixel(x, y + 1).B == value && matrix.GetPixel(x, y - 1).B == value)
        {
            neighbors.Add(true);
        }
        if (matrix.GetPixel(x + 1, y).B == value && matrix.GetPixel(x - 1, y).B == value)
        {
            neighbors.Add(true);
        }
        if (matrix.GetPixel(x + 1, y + 1).B == value && matrix.GetPixel(x + 1, y - 1).B == value)
        {
            neighbors.Add(true);
        }
        if (matrix.GetPixel(x - 1, y - 1).B == value && matrix.GetPixel(x - 1, y + 1).B == value)
        {
            neighbors.Add(true);
        }

        if (neighbors.Count == 4)
        {
            return true;
        }
        return false;
    }
    for (x = 0; x < image1.Width; x++)
    {
        for (y = 0; y < image1.Height; y++)
        {
            if (image1.GetPixel(x, y).B == 64)
            {
                if (CheckAllNeighbors(image1, x, y, 64))
                {
                    centerCoordinates.Add($"center coordinate found at {x},{y}");
                }
            }

        }
    }
    int i;
    for (i = 0;i<centerCoordinates.Count;i++)
    {
        Console.WriteLine($"{centerCoordinates[i]}");
    }
    Console.WriteLine("Please press enter to quit");
    Console.ReadLine();
    
}
catch
{
    throw new Exception("This is exceptionally poor error handling");
}
