using System;
using Spectre.Console;


namespace LevelTwo
{
    public static class Program
    {
        private static void Main(string[] args)
        {
            string imagePath = args[0];

            CanvasImage image = new CanvasImage(imagePath);

            int width = Convert.ToInt32(args[1]);
            image.MaxWidth(width);

            AnsiConsole.Write(image);
        }
    }
}
