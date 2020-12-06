using System;

namespace AppInput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap ten: ");
            string name = Console.ReadLine();

            Console.WriteLine($"Xin chao {name}");
        }
    }
}
