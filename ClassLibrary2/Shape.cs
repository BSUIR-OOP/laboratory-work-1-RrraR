using System.Drawing;

namespace ClassLibrary2
{
    public abstract class Shape
    {
        public int BorderThickness { get; protected set; } = 1;
        public Color Color { get; } = Color.Black;

        public abstract void Draw(IDrawable drawable);

    }
}
