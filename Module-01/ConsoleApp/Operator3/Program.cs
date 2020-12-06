using System;

namespace Operator3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 8;
            a = a + 1;
            Console.WriteLine($"a = {a}");

            int b = 8;
            b += 1;
            Console.WriteLine($"b = {b}");

            int c = 8;
            c++;
            Console.WriteLine($"c = {c}");

            int d = 8;
            ++d;
            Console.WriteLine($"d = {d}");

            int x = 8;
            int t = x++;
            Console.WriteLine($"t = {t}");

            int y = 8;
            int h = ++y;
            Console.WriteLine($"h = {h}");
        }
    }
}
