using System;
using System.Collections.Generic;
using System.Text;

namespace Scaler01
{
    class MaxAbsScaler
    {
        double maxAbs;
        public void Fit(double[] a)
        {
            maxAbs = a[0];
            for (int i = 1; i < a.Length; ++i)
            {
                double t = Math.Abs(a[i]);
                if (maxAbs > t)
                {
                    maxAbs = t;
                }
            }
        }

        public double[] Transform(double[] a)
        {
            double[] b = new double[a.Length];

            for (int i = 0; i < b.Length; ++i)
            {
                b[i] = a[i] / maxAbs;
            }

            return b;
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
                b[i] = a[i] * maxAbs;
            }

            return b;
        }
    }
}
