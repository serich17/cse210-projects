using System;

class Program
{
    static void Main(string[] args)
    {

        List<Shape> shapes = new List<Shape>();

        Square square = new Square("Blue", 7.5);
        Rectangle rectangle = new Rectangle("Yellow", 5, 1.5);
        Circle circle = new Circle("Green", 5);

        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach (Shape shape in shapes) {
            Console.WriteLine($"\nColor: {shape.GetColor()}");
            Console.WriteLine($"Area: {shape.GetArea()}");
        }
    }
}