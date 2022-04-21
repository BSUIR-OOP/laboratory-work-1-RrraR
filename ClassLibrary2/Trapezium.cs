using System;
using System.Drawing;

namespace ClassLibrary2
{
    public class Trapezium:Shape
    {
        public Point _point1;
        public Point _point2;
        
        public Trapezium(int x1, int y1,int x2,int y2, int thickness)
        {
            _point1.X = x1;
            _point1.Y = y1;
            _point2.X = x2;
            _point2.Y = y2;
            BorderThickness = thickness;
        }

        public override void Draw(IDrawable drawable)
        {
            drawable.Draw(this);
        }

    }
}
