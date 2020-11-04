using System;

namespace Angle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap goc bat ky: ");
            int angle = int.Parse(Console.ReadLine());

            int i = ((angle % 360) / 90) + 1;
            Console.WriteLine($"Goc thu: {i}");
        }
    }
}
