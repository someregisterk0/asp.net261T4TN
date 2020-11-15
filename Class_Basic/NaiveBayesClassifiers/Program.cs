using System;
using System.Collections.Generic;
using System.IO;

namespace NaiveBayesClassifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines(@"D:\261T4TN\data\dataset.txt");
            int[] classify = new int[2];
            Dictionary<string, int[]> color = new Dictionary<string, int[]>();
            foreach (string line in lines)
            {
                //Console.WriteLine(line);
                string[] a = line.Split(",");

                // classify
                int c = int.Parse(a[3]);
                classify[c]++;

                // color
                if (!color.ContainsKey(a[0]))
                {
                    color.Add(a[0], new int[] { 0, 0 });
                }
                color[a[0]][c]++;
            }

            for(int i = 0; i < classify.Length; ++i)
            {
                Console.WriteLine($"{i} --> {classify[i]}");
            }
            foreach(KeyValuePair<string, int[]> item in color)
            {
                Console.WriteLine($"{item.Key} --> {item.Value[0]} - {item.Value[1]}");
            }
        }
    }
}
