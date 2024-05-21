using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> listOfShapes = new List<Shape>();
        
        // Create a few shapes and print out their area
        Shape square = new Square("red", 10);
        listOfShapes.Add(square);
        // Console.WriteLine("This is a Square: ");
        // Console.WriteLine(square.GetColor());
        // Console.WriteLine(square.GetArea());

        Shape rectangle = new Rectangle("blue", 10, 20);
        listOfShapes.Add(rectangle);
        // Console.WriteLine("This is a Rectangle: ");
        // Console.WriteLine(rectangle.GetColor());
        // Console.WriteLine(rectangle.GetArea());

        Shape circle = new Circle("green", 10);
        listOfShapes.Add(circle);
        // Console.WriteLine("This is a Circle: ");
        // Console.WriteLine(circle.GetColor());
        // Console.WriteLine(circle.GetArea());


        foreach (Shape shape in listOfShapes)
        {
            Console.WriteLine($"This shape is {shape.GetColor()} and has {shape.GetArea()} of area.");
        }
    }

}