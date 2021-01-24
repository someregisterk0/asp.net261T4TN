using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp
{
    public static class Helper
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
    }
}
