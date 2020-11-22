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

        }

        public double[] Transform(double[] a)
        {
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
