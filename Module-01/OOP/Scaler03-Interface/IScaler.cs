using System;
using System.Collections.Generic;
using System.Text;

namespace Scaler03_Interface
{
    interface IScaler
    {
        void Fit(double[] a);
        double[] Transform(double[] a);
        double[] FitTransform(double[] a);
        double[] Inverse(double[] a);
    }
}
