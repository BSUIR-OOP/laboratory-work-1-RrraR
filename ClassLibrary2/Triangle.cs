using System;
using System.Drawing;

namespace ClassLibrary2
{
    [Serializable()]
    public class Triangle:Shape
    {
       public Point _frstPoint;
       public Point _scndPoint;
       public Point _thrdPoint;

        public Triangle(int FrstX,int FrstY, int ScndX, int ScndY, int ThrdX, int ThrdY)
        {

            _frstPoint.X = FrstX;
            _frstPoint.Y = FrstY;
            _scndPoint.X = ScndX;
            _scndPoint.Y = ScndY;
            _thrdPoint.X = ThrdX;
            _thrdPoint.Y = ThrdY;

        }

        public override void Draw(IDrawable drawable)
        {
            drawable.Draw(this);
        }

    }
}
