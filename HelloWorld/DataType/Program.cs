using System;

namespace DataType
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            byte b = 2;
            short sh = 3;
            long l = 9999;
            Console.WriteLine($"i = {i}, b = {b}, sh = {sh}, l = {l}");

            float f = 7.5f;
            double dou = 8.88;
            decimal dec = 8.33m;
            Console.WriteLine($"f = {f}, dou = {dou}, dec = {dec}");

            string str = "asfasd";
            char c = 'a';
            Console.WriteLine($"str = {str}, c = {c}");

            bool x = true;
            bool y = false;
            Console.WriteLine($"x = {x}, y = {y}");
        }
    }
}
