using System;

namespace StringPlus
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "";

            for(int i = 0; i < 500000; ++i)
            {
                str += "A";
            }
            Console.WriteLine("Finished");
        }
    }
}
