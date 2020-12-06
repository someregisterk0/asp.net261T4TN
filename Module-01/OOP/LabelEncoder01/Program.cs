using System;
using System.Collections.Generic;

namespace LabelEncoder01
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = { "Blue", "Red", "Red", "Blue", "Red", "Yellow", "Red", "Violet", "Green" };

            Dictionary<string, int> dict = new Dictionary<string, int>();
            //{
            //    {"Blue", 0 },
            //    {"Red", 1 },
            //    {"Yellow", 2 }
            //};

            int[] brr = new int[arr.Length];
            int c = 0;
            for(int i = 0; i < arr.Length; ++i)
            {
                if(!dict.ContainsKey(arr[i]))
                {
                    dict.Add(arr[i], c++);
                }
                brr[i] = dict[arr[i]];
            }

            for(int i = 0; i < brr.Length; ++i)
            {
                Console.WriteLine(brr[i]);
            }


            // Reverse dictionary

            Dictionary<int, string> reverseDict = new Dictionary<int, string>();
            foreach(KeyValuePair<string, int> item in dict)
            {
                reverseDict.Add(item.Value, item.Key);
            }

            string[] crr = new string[arr.Length];
            for(int i = 0; i < brr.Length; ++i)
            {
                crr[i] = reverseDict[brr[i]];
            }

            for (int i = 0; i < crr.Length; ++i)
            {
                Console.WriteLine(crr[i]);
            }

        }
    }
}
