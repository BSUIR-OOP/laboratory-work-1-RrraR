using System.Collections.Generic;
using ClassLibrary2;


namespace WindowsFormsApplication1
{
    public class ShapeList: List<Shape>
    {
        
        public ShapeList()
        {
            Add(new Dot(20, 20));
            Add(new Line(5, 5, 45, 20));
            Add(new Ellipse(20, 20, 20, 30));
            Add(new Polygon(30, 18, 45, 30, 37, 50, 22, 50, 15, 30));
            Add(new Rectangle(10, 10, 40, 30));
            Add(new ClassLibrary2.Trapezium(10, 50, 40, 50, 1));
            Add(new Triangle(10, 10, 37, 30, 15, 50));
        }
    }
}