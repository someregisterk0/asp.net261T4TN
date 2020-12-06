using System;

namespace Array2Dimention
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] a =
            {
                {7,5,1,4 },
                {8, 13, 34, 23 },
                {9, 0, 7, 8 }
            };

            Console.WriteLine($"a[0,1] + a[1,2] = {a[0, 1] + a[1, 2]}");

            string[,] str =
            {
                {"hello", "world" },
                {"demention", "2d" },
                {"array", "zero"}
            };

            Console.WriteLine($"{str[0, 1]}"); 
        }
    }
}
