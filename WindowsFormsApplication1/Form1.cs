using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using ClassLibrary2;
using Rectangle = ClassLibrary2.Rectangle;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private static List<Point> _points;
        private static List<Shape> _openedProject;
        private readonly ShapeList _shapeList = new ShapeList();
        // private IDrawable _drawable;

        //private List<Panel> _panels = new List<Panel>();
        public Form1()
        {
            InitializeComponent();
            _points = new List<Point>(5);
            var x = 20;
            var y = 20;
            // _openedProject = new List<L>()
            foreach (var shape in _shapeList)
            {
                var p = new Panel()
                {
                    Size = new Size(60, 60),
                    Location = new Point(x, y),
                   // BorderStyle = BorderStyle.FixedSingle,
                    
                };
                y += 55;
                p.Paint += (sender, args) =>
                {
                    shape.Draw(new GraphicsDrawable( args.Graphics));
                };
                Controls.Add(p);
            }
        }


        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //Graphics Space = e.Graphics;
            // var globalGraphics = e.Graphics;
            // _drawable = new GraphicsDrawable( e.Graphics);
            // foreach (var shape in _shapeList)
            // {
            //     shape.Draw(_drawable);
            // }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            //var p = new Dot(_points.Last().X, _points.Last().Y);
            // p.Draw(this.CreateGraphics(), new Pen(Color.Black));
            // _openedProject.Add(p);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var p = new Line(_points.Last().X, _points.Last().Y, _points[_points.Count - 2].X,
                 _points[_points.Count - 2].Y);
            // p.Draw(this.CreateGraphics(), new Pen(Color.Black));
            // _openedProject.Add(p);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var p = new Ellipse(_points[_points.Count - 2].X, _points[_points.Count - 2].Y,
                Math.Abs(_points.Last().X - _points[_points.Count - 2].X),
                Math.Abs(_points.Last().Y - _points[_points.Count - 2].Y));

            // p.Draw(this.CreateGraphics(), new Pen(Color.Black));
            // _openedProject.Add(p);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var p = new Triangle(_points.Last().X, _points.Last().Y,
                _points[_points.Count - 2].X, _points[_points.Count - 2].Y,
                _points[_points.Count - 3].X, _points[_points.Count - 3].Y);
            // p.Draw(this.CreateGraphics(), new Pen(Color.Black));
            // _openedProject.Add(p);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var p = new Rectangle(_points[_points.Count - 2].X, _points[_points.Count - 2].Y,
                Math.Abs(_points.Last().X - _points[_points.Count - 2].X),
                Math.Abs(_points.Last().Y - _points[_points.Count - 2].Y));
            // p.Draw(this.CreateGraphics(), new Pen(Color.Black));
            // _openedProject.Add(p);
        }

        private void drawPolygon_Click(object sender, EventArgs e)
        {
            var p = new Polygon(_points.Last().X, _points.Last().Y,
                 _points[_points.Count - 2].X, _points[_points.Count - 2].Y,
                 _points[_points.Count - 3].X, _points[_points.Count - 3].Y,
                 _points[_points.Count - 4].X, _points[_points.Count - 4].Y,
                 _points[_points.Count - 5].X, _points[_points.Count - 5].Y);
            // p.Draw(this.CreateGraphics(), new Pen(Color.Black));
            // _openedProject.Add(p);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (Stream stream = File.Open("data.bin", FileMode.Create))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    bin.Serialize(stream, _openedProject);
                }
            }
            catch (IOException)
            {
                MessageBox.Show("Error while writing to file");
            }
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (Stream stream = File.Open("data.bin", FileMode.Open))
                {
                    BinaryFormatter bin = new BinaryFormatter();

                    _openedProject = (List<Shape>)bin.Deserialize(stream);
                }
            }
            catch (IOException)
            {
                MessageBox.Show("Error while reading file");
            }
            foreach (var item in _openedProject)
            {
                //item.Draw(CreateGraphics(), new Pen(Color.Black));
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try {
                
                var types = typeof(ClassLibrary2.Trapezium).Assembly.GetTypes();
                foreach (var item in types)
                {
                    if (item.BaseType == typeof(Shape)) 
                        comboBox1.Items.Add(item);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error while loading assembly");
            }
        }

        private void btnDrawCombo_Click(object sender, EventArgs e)
        {
            var g = Activator.CreateInstance((Type) comboBox1.SelectedItem, new object[]
            {
                _points.Last().X, _points.Last().Y,
                _points[_points.Count - 2].X, _points[_points.Count - 2].Y
            }) as Shape;
            _openedProject.Add(g);
            // if (g != null)
            //     g.Draw(CreateGraphics(), new Pen(Color.Black));
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            var click = new Point(PointToClient(MousePosition).X, PointToClient(MousePosition).Y);
            _points.Add(click);
            textBox1.Select(0, 0);
            textBox1.SelectedText += "X:" + click.X + " Y:" + click.Y + Environment.NewLine;
            switch (_points.Count)
            {
                case 1:
                    {
                        drawDot.Enabled = true;
                        break;
                    }
                case 2:
                    {
                        drawLine.Enabled = true;
                        drawEllipse.Enabled = true;
                        drawRectangle.Enabled = true;
                        break;
                    }
                case 3:
                    {
                        drawTriangle.Enabled = true;
                        break;
                    }
                case 5:
                    {
                        drawPolygon.Enabled = true;
                        break;
                    }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Invalidate();
            _points.Clear();
            drawDot.Enabled = false;
            drawEllipse.Enabled = false;
            drawLine.Enabled = false;
            drawRectangle.Enabled = false;
            drawTriangle.Enabled = false;
            drawPolygon.Enabled = false;
            textBox1.Clear();
        }
    }
}
