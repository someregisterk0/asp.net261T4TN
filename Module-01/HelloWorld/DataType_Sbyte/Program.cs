using System;

namespace DataType_Sbyte
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Math.Pow(2, 32));
            int a = 2147483647;
            int b = 2147483648;
            int c = -2147483648;

            uint d = 4294967295;
            uint e = 4294967296;

            long f = 9223372036854775807;
            long g = 9223372036854775808;
            long h = -9223372036854775808;
            long i = -9223372036854775809;

            ulong j = 18446744073709551615;
            ulong k = 18446744073709551616;
            ulong l = 0;
        }
    }
}
