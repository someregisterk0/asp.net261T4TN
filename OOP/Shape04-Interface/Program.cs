using System;

namespace Shape04_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rec1 = new Rectangle(3, 9);
            Console.WriteLine("Rectangle: 3, 9");
            Console.WriteLine($"Area: {rec1.Area()}\nPerimeter: {rec1.Perimeter()}");

            Console.WriteLine("--------------------------------------------");

            Square sq1 = new Square(8);
            Console.WriteLine("Square: 8");
            Console.WriteLine($"Area: {sq1.Area()}\nPerimeter: {sq1.Perimeter()}");

            Console.WriteLine("--------------------------------------------");

            Triangle tri1 = new Triangle(8, 5, 4);
            Console.WriteLine("Square: 8, 5, 4");
            Console.WriteLine($"Area: {tri1.Area()}\nPerimeter: {tri1.Perimeter()}");

            Console.WriteLine("--------------------------------------------");

            Ellipe ell1 = new Ellipe(8, 5);
            Console.WriteLine("Ellipe: 8, 5");
            Console.WriteLine($"Area: {ell1.Area()}\nPerimeter: {ell1.Perimeter()}");

            Console.WriteLine("--------------------------------------------");

            Circle c1 = new Circle(5);
            Console.WriteLine("Circle: 5");
            Console.WriteLine($"Area: {c1.Area()}\nPerimeter: {c1.Perimeter()}");

            Console.WriteLine("--------------------------------------------");

            double sdt = 0;
            double scv = 0;
            IShape[] shapes = { rec1, sq1, tri1, ell1, c1 };

            foreach(IShape shape in shapes)
            {
                sdt += shape.Area();
                scv += shape.Perimeter();
            }

            Console.WriteLine($"Tong dien tich: {sdt}");
            Console.WriteLine($"Tong chu vi: {scv}");
        }
    }
}
