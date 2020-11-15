using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Sample01
{
    class PhanSo
    {
        int tu;
        int mau;

        public void Nhap()
        {
            Console.Write("Nhap tu: ");
            tu = int.Parse(Console.ReadLine());
            Console.Write("Nhap mau: ");
            mau = int.Parse(Console.ReadLine());
        }

        public void Xuat()
        {
            Console.WriteLine($"{tu}/{mau}");
        }
    }
}
