using System;
using System.Collections.Generic;

namespace ThongKeNhanhLa
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 102, 101, 15, 16, 23, 24, 18, 25, 39, 37, 28 };
            Dictionary<int, List<int>> dict = new Dictionary<int, List<int>>();

            foreach(int v in a)
            {
                int branch = v / 10;
                int leaf = v % 10;
                if(dict.ContainsKey(branch))
                {
                    dict[branch].Add(leaf);
                }
                else
                {
                    dict.Add(branch, new List<int> { leaf });
                }
            }

            Console.WriteLine("Ke qua thong ke: ");
            foreach(KeyValuePair<int,List<int>> item in dict)
            {
                Console.Write($"{item.Key} --> {string.Join(",", item.Value)}\n");
            }
        }
    }
}
