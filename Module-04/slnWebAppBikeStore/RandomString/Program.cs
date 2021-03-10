using System;
using System.Collections.Generic;

namespace RandomFileName
{
    class Program
    {
        public static string RandomString(int n)
        {
            string str = "abcdefghijklmnopqrstwxyz1234567890";

            List<char> list = new List<char>(n);
            Random random = new Random();

            for (int i = 0; i < n; i++)
            {
                int index = random.Next(str.Length);
                //Console.WriteLine(str[index]);
                list.Add(str[index]);
            }

            return string.Join("", list);
        }
        static void Main(string[] args)
        {
            string fileName = "abc.jpg";

            Console.WriteLine(fileName.LastIndexOf("."));
            Console.WriteLine(fileName.Substring(fileName.LastIndexOf(".")));

            Console.WriteLine(RandomString(16) + fileName.Substring(fileName.LastIndexOf(".")));
        }
    }
}
