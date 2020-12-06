using System;
using System.Collections.Generic;
using System.Text;

namespace Scaler02_Abstract
{
    abstract class Scaler
    {
        public abstract void Fit(double[] a);

        public double[] Transform(double[] a)
        {
            double[] b = new double[a.Length];

            for (int i = 0; i < b.Length; ++i)
            {
                b[i] = CalculateTransform(a[i]);
            }

            return b;
        }

        protected abstract double CalculateTransform(double v);

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
                b[i] = CalculateInverse(a[i]);
            }

            return b;
        }
        protected abstract double CalculateInverse(double v);
    }
}
