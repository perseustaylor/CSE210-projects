using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Shape circle = new Circle("Red", 5.0);
        shapes.Add(circle);

        Shape square = new Square("Blue", 4.0);
        shapes.Add(square);

        Shape rectangle = new Rectangle("Green", 3.0, 6.0);
        shapes.Add(rectangle);

        // Console.WriteLine($"A circle of color {circle.GetColor()}, has an area of{circle.GetArea()}");
        // Console.WriteLine($"A Square of color {square.GetColor()}, has an area of {square.GetArea()}");

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"A shape of color {shape.GetColor()}, has an area of {shape.GetArea()}");
        }
    }
}