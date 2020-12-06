using System;

namespace Shape03_Abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rec1 = new Rectangle(3, 9);

            Console.WriteLine("Rectangle: ");
            Console.WriteLine($"Area: {rec1.Area()}\nPerimeter: {rec1.Perimeter()}");
        }
    }
}
