using System;

namespace Class_Sample01
{
    class Program
    {
        static void Main(string[] args)
        {
            PhanSo p1 = new PhanSo();
            PhanSo p2 = new PhanSo();

            Console.WriteLine("Nhap phan so 1: ");
            p1.Nhap();
            p1.Xuat();

            Console.WriteLine("Nhap phan so 2: ");
            p2.Nhap();
            p2.Xuat();

            PhanSo p3 = p1;
            p3.Xuat();
            p3.Nhap();
            p3.Xuat();
            p1.Xuat();
        }
    }
}
