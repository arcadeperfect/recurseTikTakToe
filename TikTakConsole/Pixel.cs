using System;
using System.Runtime.Remoting.Messaging;

namespace TikTakConsole
{
    public class Pixel
    {
        private char _pix;
        public char Pix { get => _pix;}
        private readonly string _glyphs = " -|+xo";

        public Pixel(PixelState pixelState)
        {
            SetState(pixelState);
        }
        public Pixel(char character)
        {
            SetState(character);
        }
        public void SetState(PixelState pixelState)
        {
            if (pixelState == PixelState.Blank)
            {
                _pix = _glyphs[0];
            }
            else if (pixelState == PixelState.HLine)
            {
                _pix = _glyphs[1];
            }
            else if (pixelState == PixelState.VLine)
            {
                _pix = _glyphs[2];
            }
            else if (pixelState == PixelState.CrossLine)
            {
                _pix = _glyphs[3];
            }
            else if (pixelState == PixelState.X)
            {
                _pix = _glyphs[4];
            }
            else if(pixelState == PixelState.O)
            {
                _pix = _glyphs[5];
            }
        }
        public void SetState(char character)
        {
            _pix = character;
        }
        public enum PixelState
        {
            Character,
            Blank,
            HLine,
            VLine,
            CrossLine,
            X,
            O,
        }

        public override string ToString()
        {
            return _pix.ToString();
        }
    }
}