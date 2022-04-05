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
    public class Line:Shape
    {
       private Point _start = new Point();
       private Point _finish = new Point();

        public Line(int StartX,int StartY, int FinishX, int FinishY)
        {
            _start.X = StartX;
            _start.Y = StartY;
            _finish.X = FinishX;
            _finish.Y = FinishY;
        }

        public override Graphics Draw(Graphics Space, Pen Color)
        {
            Space.DrawLine(Color, _start, _finish);
            return base.Draw(Space, Color);
        }
    }
}
