using System;

namespace RandomNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            int i = rand.Next(0, 9);
            Console.WriteLine($"i = {i}");

            double d = rand.NextDouble();
            Console.WriteLine($"d = {d}");
        }
    }
}
