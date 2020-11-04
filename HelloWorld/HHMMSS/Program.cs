using System;

namespace HHMMSS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap gio: ");
            int h = int.Parse(Console.ReadLine());

            Console.Write("Nhap phut: ");
            int m = int.Parse(Console.ReadLine());

            Console.Write("Nhap giay: ");
            int s = int.Parse(Console.ReadLine());

            Console.Write("Nhap so giay can them: ");
            int k = int.Parse(Console.ReadLine());

            s = s + k;
            m = m + (s / 60);
            h = h + (m / 60);
            s = s % 60;
            m = m % 60;
            h = h % 24;

            Console.WriteLine($"{h}h  {m}m  {s}s");
        }
    }
}
