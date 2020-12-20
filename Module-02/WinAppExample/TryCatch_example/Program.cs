using System;

namespace TryCatch_example
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            try
            {
                Console.Write("Nhap a: ");
                a = int.Parse(Console.ReadLine());
                Console.WriteLine("Ket thuc Try");
            }
            catch ( Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Loi nhap so.");
            }
            finally
            {
                Console.WriteLine($"a = {a}");
                Console.WriteLine("Always call finally.");
            }
        }
    }
}
