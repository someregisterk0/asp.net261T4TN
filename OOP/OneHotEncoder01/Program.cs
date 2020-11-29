using System;
using System.Collections.Generic;

namespace OneHotEncoder01
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = { "Blue", "Red", "Red", "Blue", "Red", "Yellow", "Red", "Violet", "Green" };

            Dictionary<string, int> dict = new Dictionary<string, int>();

            int c = 0;
            foreach(string item in arr)
            {
                if(!dict.ContainsKey(item))
                {
                    dict.Add(item, c++);
                }
            }

            int[,] brr = new int[arr.Length, dict.Count];
            for(int i = 0; i < arr.Length; ++i)
            {
                brr[i, dict[arr[i]]] = 1;
            }

            for (int i = 0; i < brr.GetLength(0); i++)
            {
                for (int j = 0; j < brr.GetLength(1); j++)
                {
                    Console.Write($"{brr[i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
