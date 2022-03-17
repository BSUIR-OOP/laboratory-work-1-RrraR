using ClassLibrary2;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    [Serializable()]
    public class Rectangle:Shape
    {
        private Point _start = new Point();
        private int _width,_height;


        public Rectangle(int StartX,int StartY,int Width, int Heigth)
        {
            _start.X = StartX;
            _start.Y = StartY;
            _width = Width;
            _height = Heigth;
        }

        public override Graphics Draw(Graphics Space, Pen Color)
        {
            Space.DrawRectangle(Color, _start.X, _start.Y, _width, _height);
            return base.Draw(Space, Color);
        }
    }
}
