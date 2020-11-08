using System;
using System.Text;

namespace StringBuilders
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            for(int i = 0; i < 5000000; ++i)
            {
                sb.Append("A");
            }
            Console.WriteLine("Finished");
        }
    }
}
