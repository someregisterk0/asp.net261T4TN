using System;

namespace ChanLe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap vao mot so: ");
            int i = int.Parse(Console.ReadLine());

            string[] a = { "So chan", "So le" };

            Console.WriteLine(a[i % 2]);
        }
    }
}
