using System;

namespace Operator2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 98;
            a = a + 2;
            Console.WriteLine($"a = {a}");

            int b = 98;
            b += 2;
            Console.WriteLine($"b = {b}");

            int c = 87;
            c %= 5;
            Console.WriteLine($"c = {c}");

            int d = 87;
            d %= 5;
            Console.WriteLine($"d = {d}");

            int e = 55;
            e = e / 5;
            Console.WriteLine($"e = {e}");

            int f = 55;
            f /= 5;
            Console.WriteLine($"f = {f}");
        }
    }
}
