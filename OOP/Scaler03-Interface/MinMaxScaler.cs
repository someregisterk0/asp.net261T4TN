using System;
using System.Collections.Generic;
using System.Text;

namespace Scaler03_Interface
{
    class MinMaxScaler : IScaler
    {
        double min, max;
        public void Fit(double[] a)
        {
            min = max = a[0];
            for (int i = 1; i < a.Length; ++i)
            {
                if (min > a[i])
                {
                    min = a[i];
                }
                if (max < a[i])
                {
                    max = a[i];
                }
            }
        }

        public double[] FitTransform(double[] a)
        {
            Fit(a);
            return Transform(a);
        }

        public double[] Inverse(double[] a)
        {
            double[] b = new double[a.Length];

            for (int i = 0; i < b.Length; ++i)
            {
                b[i] = a[i] * (max - min) + min;
            }

            return b;
        }

        public double[] Transform(double[] a)
        {
            double[] b = new double[a.Length];

            for (int i = 0; i < b.Length; ++i)
            {
                b[i] = (a[i] - min) / (max - min);
            }

            return b;
        }
    }
}
