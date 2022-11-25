using System;
using TikTakConsole.Properties;

namespace TikTakConsole
{
    public class Renderer
    {
        private Pixel[,] _pixelArray;
        private char padding = ' ';
        
        private readonly int _width;
        private readonly int _height;

        public Renderer(int width, int height)
        {
            _width = width;
            _height = height;
            Init();
        }
        void Init()
        {
            _pixelArray = new Pixel[_width,_height];
            for (int i = 0; i < _width; i++)
            {
                for (int j = 0; j < _height; j++)
                {
                    _pixelArray[i, j] = new Pixel(Pixel.PixelState.CrossLine);
                }
            }
        }
        public void SetPixel(Vec2 coord, Pixel.PixelState state)
        {
            _pixelArray[coord.x, coord.y].SetState(state);
        }
        public void SetPixel(Vec2 coord, char character)
        {
            _pixelArray[coord.x, coord.y].SetState(character);
        }
        public void Display()
        {
            Console.Clear();
            Console.SetCursorPosition(0,0);
            for (int i = 0; i < _width; i++)
            {
                string line = "";
                for (int j = 0; j < _height; j++)
                {
                    var glyph = _pixelArray[j, i].ToString();
                    line += $"{padding}{glyph}{padding}";
                }
                Console.WriteLine(line);
            }
        }
    }
}