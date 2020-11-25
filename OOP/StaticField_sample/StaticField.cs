using System;
using System.Collections.Generic;
using System.Text;

namespace StaticField_sample
{
    class StaticField
    {
        public int a = 0;
        public static int b = 0;

        public StaticField()
        {
            a++;
            b++;
            Console.WriteLine($"a = {a}, b = {b}");
        }
    }
}
