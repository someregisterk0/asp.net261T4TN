using System;

namespace ConStructor_sample
{
    class Program
    {
        static void Main(string[] args)
        {
            PhanSo p1 = new PhanSo(3, 7);

            // Không thể gọi
            // p1.PhanSo();

            Console.WriteLine(p1);
        }
    }
}
