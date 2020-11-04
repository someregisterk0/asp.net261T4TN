using System;

namespace TimSoLonNhatTrong2So
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;

            Console.Write("nhap x: ");
            x = int.Parse(Console.ReadLine());

            Console.Write("nhap y: ");
            y = int.Parse(Console.ReadLine());

            if(x > y)
            {
                Console.WriteLine($"So lon nhat la: {x}");
            } else
            {
                Console.WriteLine($"So lon nhat la: {y}");
            }
        }
    }
}
