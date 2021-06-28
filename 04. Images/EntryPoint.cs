using System;
using System.Drawing;
using System.Drawing.Imaging;

class EntryPoint
{
    static void Main()
    {
        Random rng = new Random();

        byte[,,] colors = new byte[3, 1080, 1920];

        for (int color = 0; color < colors.GetLength(0); color++)
        {
            for (int row = 0; row < colors.GetLength(1); row++)
            {
                for (int col = 0; col < colors.GetLength(2); col++)
                {
                    colors[color, row, col] = (byte)rng.Next(0, 255);
                }
            }
        }

        Bitmap bitmapImage = new Bitmap(colors.GetLength(2), colors.GetLength(1), PixelFormat.Format24bppRgb);

        for (int row = 0; row < bitmapImage.Height; row++)
        {
            for (int col = 0; col < bitmapImage.Width; col++)
            {
                bitmapImage.SetPixel(col, row, Color.FromArgb(colors[0, row, col], colors[1, row, col], colors[2, row, col]));
            }
        }

        bitmapImage.Save("test.png");

        Bitmap readImage = new Bitmap(Image.FromFile("test.png"));

        Color[,] readColors = new Color[readImage.Height, readImage.Width];

        for (int row = 0; row < readColors.GetLength(0); row++)
        {
            for (int col = 0; col < readColors.GetLength(1); col++)
            {
                readColors[row, col] = readImage.GetPixel(col, row);
            }
        }

        colors[0, 100, 150] = 0;

        bool equal = true;

        for (int row = 0; row < readColors.GetLength(0); row++)
        {
            for (int col = 0; col < readColors.GetLength(1); col++)
            {
                if ((readColors[row, col].R != colors[0, row, col]) ||
                    (readColors[row, col].G != colors[1, row, col]) ||
                    (readColors[row, col].B != colors[2, row, col]))
                {
                    Console.WriteLine($"Difference found at pixel row = {row}, col = {col}");
                    equal = false;
                    break;
                }
            }
        }

        Console.WriteLine($"Is the image the same as the original array: {equal}");
    }
}