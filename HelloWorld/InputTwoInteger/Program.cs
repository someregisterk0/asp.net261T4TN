using System;

namespace InputTwoInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so thu nhat: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Nhap so thu hai: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine($"Tong: {a} + {b} = {a + b}");
        }
    }
}
