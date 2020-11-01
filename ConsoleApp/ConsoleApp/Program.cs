using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 2, 3, 4, 6, 7, 8 };
            string[] str = { "Hello", "world", "again"};

            Console.WriteLine($"a[0] + a[1] = {a[0] + a[1]}\n" +
                $"a[2] + a[3] = {a[2] + a[3]}");

            Console.WriteLine($"Length of a: {a.Length}");
            Console.WriteLine($"Length of str: {str.Length}");
        }
    }
}
