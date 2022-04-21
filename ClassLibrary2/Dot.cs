using System.Drawing;

namespace ClassLibrary2
{
    public class Dot: Shape
    {
        public int _pointX;
        public int _pointY;
        public int _height = 1;
        public int _weidth = 1;

        public Dot(int x,int y)
        {
            _pointX = x;
            _pointY = y;
        }      
     
        public override void Draw(IDrawable drawable)
        {
            drawable.Draw(this);
        }
 
    }
}
