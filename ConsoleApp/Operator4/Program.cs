using System;

namespace Operator4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 7, b = 15;
            int x = ++a + b++;
            Console.WriteLine($"x = {x}");
            Console.WriteLine($"a = {a}, b = {b}");

            int c = 7, d = 15;
            int y = ++c + ++d;
            Console.WriteLine($"y = {y}");
            Console.WriteLine($"c = {c}, d = {d}");

            int e = 7, f = 15;
            int z = e++ + f++;
            Console.WriteLine($"z = {z}");
            Console.WriteLine($"e = {e}, f = {f}");
        }
    }
}
