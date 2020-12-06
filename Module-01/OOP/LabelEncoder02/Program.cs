using System;

namespace LabelEncoder02
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = { "Blue", "Red", "Red", "Blue", "Red", "Yellow", "Red", "Violet", "Green" };

            LabelEncoder labelEncoder = new LabelEncoder();

            labelEncoder.Fit(arr);

            int[] brr = labelEncoder.Transform(arr);
            foreach(int item in brr)
            {
                Console.WriteLine(item);
            }

            // reverse dict

            string[] crr = labelEncoder.Inverse(brr);
            foreach(string item in crr)
            {
                Console.WriteLine(item);
            }

        }
    }
}
