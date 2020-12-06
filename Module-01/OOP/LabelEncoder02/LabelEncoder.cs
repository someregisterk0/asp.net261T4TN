using System;
using System.Collections.Generic;
using System.Text;

namespace LabelEncoder02
{
    class LabelEncoder
    {
        Dictionary<string, int> dict;
        Dictionary<int, string> reverse;

        public void Fit(string[] arr)
        {
            dict = new Dictionary<string, int>();
            reverse = new Dictionary<int, string>();

            int v = 0;
            foreach(string item in arr)
            {
                if(!dict.ContainsKey(item))
                {
                    dict.Add(item, v);
                    reverse.Add(v++, item);
                }
            }
        }

        public int[] Transform(string[] arr)
        {
            int[] brr = new int[arr.Length];
            for(int i = 0; i < arr.Length; ++i)
            {
                brr[i] = dict[arr[i]];
            }
            return brr;
        }

        public string[] Inverse(int[] arr)
        {
            string[] crr = new string[arr.Length];
            for(int i = 0; i < arr.Length; ++i)
            {
                crr[i] = reverse[arr[i]];
            }
            return crr;
        }

    }
}
