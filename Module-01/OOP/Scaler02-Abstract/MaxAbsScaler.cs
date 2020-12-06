using System;
using System.Collections.Generic;
using System.Text;

namespace Scaler02_Abstract
{
    class MaxAbsScaler : Scaler
    {
        double maxAbs;
        public override void Fit(double[] a)
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

        protected override double CalculateInverse(double v)
        {
            return v * maxAbs;
        }

        protected override double CalculateTransform(double v)
        {
            return v / maxAbs;
        }

        //public override double[] Inverse(double[] a)
        //{
        //    double[] b = new double[a.Length];

        //    for (int i = 0; i < b.Length; ++i)
        //    {
        //        b[i] = a[i] * maxAbs;
        //    }

        //    return b;
        //}

        //public override double[] Transform(double[] a)
        //{
        //    double[] b = new double[a.Length];

        //    for (int i = 0; i < b.Length; ++i)
        //    {
        //        b[i] = a[i] / maxAbs;
        //    }

        //    return b;
        //}
    }
}
