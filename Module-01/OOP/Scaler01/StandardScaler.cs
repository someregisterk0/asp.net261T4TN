using System;
using System.Collections.Generic;
using System.Text;

namespace Scaler01
{
    class StandardScaler
    {
        double standard, mean;

        public void Fit(double[] a)
        {
            for(int i = 0; i < a.Length; ++i)
            {
                mean += a[i];
            }
            mean /= a.Length;
        }

        public double[] Transform(double[] a)
        {
            for(int i = 0; i < a.Length; ++i)
            {
                standard += Math.Pow(a[i] - mean, 2);
            }
            return null;
        }

        public double[] FitTransform(double[] a)
        {
            Fit(a);
            return Transform(a);
        }

        public double[] Inverse(double[] a)
        {
            return null;
        }
    }
}
