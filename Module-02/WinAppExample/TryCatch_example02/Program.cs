using System;

namespace TryCatch_example02
{
    class Program
    {
        static int Calculate()
        {
            try
            {
                Console.Write("Nhap a: ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Nhap b: ");
                int b = int.Parse(Console.ReadLine());
                return a + b;
            }
            catch (Exception e) 
            {
                Console.WriteLine("Error " + e.Message);
                return 0;
            }
            finally
            {
                Console.WriteLine("Always call Finally.");
            }
        }

        static void Main(string[] args)
        {
            int a = Calculate();
            Console.WriteLine($"a = {a}");
        }
    }
}
