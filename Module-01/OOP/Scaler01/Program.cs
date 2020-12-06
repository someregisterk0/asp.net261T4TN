using System;

namespace Scaler01
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] a1 = { 2, 7, 9, 13, 15, 4 };

            Console.WriteLine("Min max scaler: ");
            MinMaxScaler minMaxScaler = new MinMaxScaler();
            double[] b1 = minMaxScaler.FitTransform(a1);
            foreach (double item in b1)
            {
                Console.Write($"{item}  ");
            }
            Console.WriteLine("\nInverse: ");
            double[] c1 = minMaxScaler.Inverse(b1);
            foreach (double item in c1)
            {
                Console.Write($"{item}  ");
            }

            Console.WriteLine("\n------------------------------\n");

            double[] a2 = { 2, 7, 9, 13, -15, 4 };
            Console.WriteLine("MaxAbsScaler");
            MaxAbsScaler maxAbsScaler = new MaxAbsScaler();
            double[] b2 = maxAbsScaler.FitTransform(a2);
            foreach (double item in b2)
            {
                Console.Write($"{item}  ");
            }
            Console.WriteLine("\nInverse: ");
            double[] c2 = maxAbsScaler.Inverse(b2);
            foreach (double item in c2)
            {
                Console.Write($"{item}  ");
            }

            Console.WriteLine("\n------------------------------\n");
            Console.WriteLine("StandardScaler");
        }
    }
}
