using System;
using System.Collections.Generic;

namespace Dictonary_sample
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict.Add("One", "Mot");
            dict.Add("Tow", "Hai");
            dict.Add("Three", "Ba");

            Console.Write("Nhap key: ");
            string key = Console.ReadLine();
            if(dict.ContainsKey(key))
            {
                Console.WriteLine($"value: {dict[key]}");
            }else
            {
                Console.WriteLine($"Not found key: {key}");
            }
        }
    }
}
