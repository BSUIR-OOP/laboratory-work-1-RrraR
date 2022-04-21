using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private readonly ShapeList _shapeList = new ShapeList();
        public Form1()
        {
            InitializeComponent();
            var x = 20;
            var y = 20;
            var i = 0;
            foreach (var shape in _shapeList)
            {
                var p = new Panel()
                {
                    Size = new Size(100, 100),
                    Location = new Point(x, y),
                   // BorderStyle = BorderStyle.FixedSingle,
                };
                x += 100;
                p.Paint += (sender, args) =>
                {
                    shape.Draw(new GraphicsDrawable(args.Graphics));
                };
                Controls.Add(p);
                i++;
                if (i % 3 == 0)
                {
                    y += 100;
                    x = 20;
                }
            }
        }

    }
}
