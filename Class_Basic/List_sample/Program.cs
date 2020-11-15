using System;
using System.Collections.Generic;

namespace List_sample
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            list.Add(3); // 0
            list.Add(4); // 1
            list.Add(5); // 2

            foreach(int item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nAfter edit");
            list[0] = 9999;
            foreach (int item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nAfter inset");
            list.Insert(1, 5555);
            foreach (int item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nAfter remove");
            list.RemoveAt(3);
            foreach (int item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
