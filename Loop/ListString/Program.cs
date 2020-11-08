using System;
using System.Collections.Generic;

namespace ListString
{
    class Program
    {
        static void Main(string[] args)
        {
            List<String> l = new List<String>();

            for(int i = 0; i < 5000000; ++i)
            {
                l.Add("A");
            }
            Console.WriteLine("Finished");
        }
    }
}
