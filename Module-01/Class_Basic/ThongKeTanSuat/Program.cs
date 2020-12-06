using System;
using System.Collections.Generic;

namespace ThongKeTanSuat
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 3, 7, 3, 3, 6, 7, 8, 1, 2, 2, 2, 3 };
            Dictionary<int, int> dict = new Dictionary<int, int>();

            // 1
            //for (int i = 0; i < a.Length; ++i)
            //{
            //    if (dict.ContainsKey(a[i]))
            //    {
            //        dict[a[i]] += 1;
            //    }
            //    else
            //    {
            //        dict.Add(a[i], 1);
            //    }
            //}

            // 2
            foreach(int v in a)
            {
                if(dict.ContainsKey(v))
                {
                    dict[v]++;
                }
                else
                {
                    dict.Add(v, 1);
                }
            }

            Console.WriteLine("Result: ");
            foreach (KeyValuePair<int, int> item in dict)
            {
                Console.WriteLine($"{item.Key} --> {item.Value}");
            }
        }
    }
}
