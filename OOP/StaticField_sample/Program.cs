using System;

namespace StaticField_sample
{
    class Program
    {
        static void Main(string[] args)
        {
            StaticField s1 = new StaticField();
            StaticField s2 = new StaticField();
            StaticField s3 = new StaticField();

            s1.a = 7;
            s2.a = 8;
            Console.WriteLine($"s1.a = {s1.a}");
            Console.WriteLine($"s2.a = {s2.a}");
            Console.WriteLine($"s3.a = {s3.a}");
        }
    }
}
