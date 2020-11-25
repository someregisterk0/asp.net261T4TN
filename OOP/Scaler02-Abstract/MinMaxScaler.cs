using System;
using System.Collections.Generic;
using System.Text;

namespace Scaler02_Abstract
{
    class MinMaxScaler : Scaler
    {
        double min, max;
        public override void Fit(double[] a)
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

        protected override double CalculateInverse(double v)
        {
            return v * (max - min) + min;
        }

        protected override double CalculateTransform(double v)
        {
            return (v - min) / (max - min);
        }

        //public override double[] Inverse(double[] a)
        //{
        //    double[] b = new double[a.Length];

        //    for (int i = 0; i < b.Length; ++i)
        //    {
        //        b[i] = a[i] * (max - min) + min;
        //    }

        //    return b;
        //}

        //public override double[] Transform(double[] a)
        //{
        //    double[] b = new double[a.Length];

        //    for (int i = 0; i < b.Length; ++i)
        //    {
        //        b[i] = (a[i] - min) / (max - min);
        //    }

        //    return b;
        //}
    }
}
