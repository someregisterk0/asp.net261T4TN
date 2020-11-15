using System;

namespace Class_private_public
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();

            s1.address = "asdklfj";
            Console.WriteLine(s1.address);

            Student s2 = new Student();
            s2.Nhap();
            s2.Xuat();
        }
    }
}
