using System;

namespace Compare
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 8;
            int b = 7;

            bool z;
            z = a == b;
            Console.WriteLine(z);
            z = a > b;
            Console.WriteLine(z);
            z = a < b;
            Console.WriteLine(z);

            int x = 9;
            z = x > 5 && x < 7;
            Console.WriteLine($"And: {z}");

            z = x > 5 || x < 7;
            Console.WriteLine($"Or: {z}");

            z = !(x > 5);
            Console.WriteLine($"Not: {z}");
        }
    }
}
