using System;
using Spectre.Console;


namespace LevelTwo
{
    public static class Program
    {
        private static void Main(string[] args)
        {

            string imagePath;
            int width;
            
            if (args.Length < 2)
            {
                imagePath = "tux.jpg";
                width = 24;
            }
            else
            {
                imagePath = args[0];
                width = Convert.ToInt32(args[1]);
            }

            CanvasImage image = new CanvasImage(imagePath);
            image.MaxWidth(width);

            AnsiConsole.Write(image);
        }
    }
}
