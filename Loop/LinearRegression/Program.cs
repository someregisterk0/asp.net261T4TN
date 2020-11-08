using System;

namespace LinearRegression
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] x = { 2, 6, 8, 8, 12, 16, 20, 20, 22, 26 };
            int[] y = { 58, 105, 88, 118, 117, 137, 157, 169, 149, 202 };
            int total = 10;
            float xAvg, yAvg, xSum = 0, ySum = 0;
            float a = 0, b = 0;

            // Tổng x, x trung bình
            // Tổng y, y trung bình
            for (int i = 0; i < total; ++i)
            {
                xSum += x[i];
                ySum += y[i];
            }
            xAvg = xSum / total;
            yAvg = ySum / total;
            Console.WriteLine($"xAvg = {xAvg}, yAvg = {yAvg}");

            //b
            float t = 0, m = 0;
            for (int i = 0; i < total; ++i)
            {
                t += (x[i] - xAvg) * (y[i] - yAvg);
                m += (x[i] - xAvg) * (x[i] - xAvg);
            }
            b = t / m;

            //a
            a = yAvg - (b * xAvg);

            Console.WriteLine($"a = {a}\nb = {b}");
            Console.WriteLine($"y = {a}x + {b}");
        }
    }
}
