using System;

class Program
{
    static void Main()
    {
        List<Shape> shapes = new List<Shape>();

        shapes.Add(new Square("Red", 5));
        shapes.Add(new Rectangle("Blue", 4, 6));
        shapes.Add(new Circle("Green", 3));

        foreach (var shape in shapes)
        {
            Console.WriteLine($"Shape: {shape.GetColor()}, Area: {shape.GetArea()}");
        }
    }
}
