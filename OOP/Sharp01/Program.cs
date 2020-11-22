using System;

namespace Sharp01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Square");
            Square sq1 = new Square(18);
            Console.WriteLine($"Perimeter: {sq1.Perimeter()}\n" +
                $"Area: {sq1.Area()}");

            Console.WriteLine("\n-------------------------------");

            Console.WriteLine("Rectangle");
            Rectangle rec1 = new Rectangle(5, 9);
            Console.WriteLine($"Perimeter: {rec1.Perimeter()}\n" +
                $"Area: {rec1.Area()}");

            Console.WriteLine("\n-------------------------------");

            Console.WriteLine("Trianle");
            Triangle tri1 = new Triangle(8, 5, 4);
            Console.WriteLine($"Perimeter: {tri1.Perimeter()}\n" +
                $"Area: {tri1.Area()}");

            Console.WriteLine("\n-------------------------------");

            Console.WriteLine("Ellipe");
            Ellipe el1 = new Ellipe(7, 18);
            Console.WriteLine($"Perimeter: {el1.Perimeter()}\n" +
                $"Area: {el1.Area()}");

            Console.WriteLine("\n-------------------------------");

            Console.WriteLine("Circle");
            Circle c1 = new Circle(20);
            Console.WriteLine($"Perimeter: {c1.Perimeter()}\n" +
                $"Area: {c1.Area()}");

            Console.WriteLine("\n-------------------------------\n");
        }
    }
}
