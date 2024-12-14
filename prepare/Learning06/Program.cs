using System;
using System.Drawing;

namespace area_of_shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            Square square = new Square("Red", 4);
            Rectangle rectangle = new Rectangle("White", 5, 2);
            Circle circle = new Circle("Blue", 2);
            
            List<Shape> shapes = new List<Shape>();
            shapes.Add(square);
            shapes.Add(rectangle);
            shapes.Add(circle);

            foreach (Shape shape in shapes)
            {
                string color = shape.GetColor();
                double area = shape.GetArea();

                Console.WriteLine($"The {color} shape has an area of {area}.");
            }
        }
    }
}