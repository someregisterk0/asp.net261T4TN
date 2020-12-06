using System;

namespace SoSanh2PhanSo
{
    class Program
    {
        static void Main(string[] args)
        {
            int t1, t2, m1, m2, x, y;
            double value1, value2;

            Console.WriteLine("Nhap so thu nhat.");
            Console.Write("Nhap tu: ");
            t1 = int.Parse(Console.ReadLine());
            Console.Write("Nhap mau: ");
            m1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Nhap so thu hai.");
            Console.Write("Nhap tu: ");
            t2 = int.Parse(Console.ReadLine());
            Console.Write("Nhap mau: ");
            m2 = int.Parse(Console.ReadLine());

            value1 = (double)t1 / (double)m1;
            value2 = (double)t2 / (double)m2;

            //if (value1 > value2)
            //{
            //    Console.WriteLine($"{value1} LON hon {value2}");
            //}
            //else if (value1 < value2)
            //{
            //    Console.WriteLine($"{value1} NHO hon {value2}");
            //} else
            //{
            //    Console.WriteLine($"{value1} BANG {value2}");
            //}   

            x = t1 * m2;
            y = m1 * t2;

            if (x > y)
            {
                Console.WriteLine($"{t1}/{m1} LON hon {t2}/{m2}");
            } else if(x < y)
            {
                Console.WriteLine($"{t1}/{m1} NHO hon {t2}/{m2}");
            } else
            {
                Console.WriteLine($"{t1}/{m1} BANG {t2}/{m2}");
            }
        }
    }
}
