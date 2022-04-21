using System.Drawing;

namespace ClassLibrary2
{
    public class Line:Shape
    {
       public Point Start;
       public Point Finish;

        public Line(int StartX,int StartY, int FinishX, int FinishY)
        {
            Start.X = StartX;
            Start.Y = StartY;
            Finish.X = FinishX;
            Finish.Y = FinishY;
        }

        public override void Draw(IDrawable drawable)
        {
            drawable.Draw(this);
        }

    }
}
