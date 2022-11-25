using System;
using System.ComponentModel;
using TikTakConsole.Properties;

namespace TikTakConsole
{
    internal class Program
    {
        private Renderer _renderer;

        public static void Main(string[] args)
        {
            Renderer renderer;

            Init();
            renderer.Display();

            while (true)
            {
                var c = Console.ReadLine();
                renderer.SetPixel(new Vec2(0,0), '1');
                renderer.SetPixel(new Vec2(2,0), '2');
                renderer.SetPixel(new Vec2(2,2), '3');
                renderer.Display();
            }
            // renderer.SetPixel(new Vec2(0,0), '1');
            // renderer.SetPixel(new Vec2(2,0), '2');
            // renderer.SetPixel(new Vec2(2,2), '3');
            // renderer.Display();

            void Init()
            {
                renderer = new Renderer(3, 3);
                // Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Cyan;
            }
        }
    }
}