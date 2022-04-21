using System;
using System.Drawing;

namespace ClassLibrary2
{
    [Serializable()]
    public class Polygon:Shape
    {
        public Point[] _curvePoints = new Point[5];
        public Point _point1;
        public Point _point2;
        public Point _point3;
        public Point _point4;
        public Point _point5;

        public Polygon(int frstX,int frstY,int scndX, int scndY,int thrdX,int thrdY,int frthX,int frthY,int ffthX,int ffthY)
        {
            _point1.X = frstX;
            _point1.Y = frstY;

            _point2.X = scndX;
            _point2.Y = scndY;

            _point3.X = thrdX;
            _point3.Y = thrdY;

            _point4.X = frthX;
            _point4.Y = frthY;

            _point5.X = ffthX;
            _point5.Y = ffthY;    
            
            _curvePoints = new []
            {_point1, _point2, _point3, _point4, _point5};
        }

        public override void Draw(IDrawable drawable)
        {
            drawable.Draw(this);
        }

    }
}
