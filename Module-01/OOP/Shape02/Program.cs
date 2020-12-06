using System;

namespace Shape02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rectangle");
            Shape rec1 = new Rectangle(3, 8);
            Console.WriteLine($"Perimeter: {rec1.Perimeter()}\n" +
                $"Area: {rec1.Area()}");

            Console.WriteLine("\n----------------------------");

            Console.WriteLine("Square");
            Shape sq1 = new Square(6);
            Console.WriteLine($"Perimeter: {sq1.Perimeter()}\n" +
                $"Area: {sq1.Area()}");

            Console.WriteLine("\n----------------------------");

            Console.WriteLine("Triangle");
            Shape tri1 = new Triangle(6, 5, 4);
            Console.WriteLine($"Perimeter: {tri1.Perimeter()}\n" +
                $"Area: {tri1.Area()}");

            Console.WriteLine("\n----------------------------");

            Console.WriteLine("Ellipe");
            Shape el1 = new Ellipse(7, 9);
            Console.WriteLine($"Perimeter: {el1.Perimeter()}\n" +
                $"Area: {el1.Area()}");

            Console.WriteLine("\n----------------------------");

            Console.WriteLine("Circle");
            Shape c1 = new Circle(7);
            Console.WriteLine($"Perimeter: {c1.Perimeter()}\n" +
                $"Area: {c1.Area()}");

            Console.WriteLine("\n----------------------------");
        }
    }
}
