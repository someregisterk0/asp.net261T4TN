using System;

namespace XemDiemTrungBinh
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal d;

            Console.Write("Nhap diem: ");
            d = decimal.Parse(Console.ReadLine());

            if (d < 3)
            {
                Console.WriteLine("KEM");
            } else if (d < 5)
            {
                Console.WriteLine("YEU");
            } else if(d < 7)
            {
                Console.WriteLine("TB");
            } else if(d < 8.5m)
            {
                Console.WriteLine("KHA");
            } else if (d < 9)
            {
                Console.WriteLine("GIOI");
            } else
            {
                Console.WriteLine("XUAT SAC");
            }
        }
    }
}
