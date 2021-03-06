using System;
using System.Drawing;

namespace ClassLibrary2
{
    public class Rectangle:Shape
    {
        public int _startX;
        public int _startY;
        public int _width,_height;


        public Rectangle(int StartX,int StartY,int Width, int Height)
        {
            _startX = StartX;
            _startY = StartY;
            _width = Width;
            _height = Height;
            BorderThickness = 1;
        }
        
        public override void Draw(IDrawable drawable)
        {
            drawable.Draw(this);
        }

    }
}
