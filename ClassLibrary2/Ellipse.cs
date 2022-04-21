using System;
using System.Drawing;

namespace ClassLibrary2
{
    [Serializable()]
    public class Ellipse : Shape
    {
        public RectangleF _rect;
        public Ellipse(int StartX, int StartY, int Width, int Height)
        {
            _rect.X = StartX;
            _rect.Y = StartY;
            _rect.Width = Width;
            _rect.Height = Height;
        }
        
        public override void Draw(IDrawable drawable)
        {
            drawable.Draw(this);
        }

    }
}