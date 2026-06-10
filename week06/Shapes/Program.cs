using System;

class Program
{
    static void Main(string[] args)
    {
        Square square1 = new Square("Saquare","Green",4.5);
        Rectangle rectangle1 = new Rectangle("Rectangle","Yellow",4,5.9);
        Circle circle1 = new Circle("Circle","Red",7.8);

        List <Shape> shapes = new List<Shape>();
        shapes.Add(square1);
        shapes.Add(rectangle1);
        shapes.Add(circle1);

        foreach (Shape S in shapes)
        {
            string name = S.GetName();
            string color = S.GetColor();
            double area = S.GetArea();

            Console.WriteLine($"{name}, {color}, {area}");

        }
    }
}