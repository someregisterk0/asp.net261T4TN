using System;

namespace DayOfMonth
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so thang: ");
            byte m = byte.Parse(Console.ReadLine());

            byte[] month = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            Console.WriteLine($"So ngay cua thang {m}: {month[m - 1]}");
        }
    }
}
