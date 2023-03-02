using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapesList = new List<Shape>();

        Square square = new Square("red", 5.0);
        Rectangle rectangle = new Rectangle("blue", 10.0, 5.0);
        Circle circle = new Circle("green", 7.0);

        shapesList.Add(square);
        shapesList.Add(rectangle);
        shapesList.Add(circle);

        foreach (Shape shape in shapesList)
        {
            System.Console.WriteLine(shape.GetColor());
            System.Console.WriteLine(shape.GetArea());
        }
    }
}