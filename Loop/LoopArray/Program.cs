using System;

namespace LoopArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 7, 8, 14, 9, 2 };

            // chiều dài mảng
            Console.WriteLine(a.Length);

            int s = 0;
            for(int i = 0; i < a.Length; ++i)
            {
                Console.WriteLine($"a[{i}] = {a[i]}");
                s += a[i];
            }
            Console.WriteLine($"Sum: {s}");
        }
    }
}
