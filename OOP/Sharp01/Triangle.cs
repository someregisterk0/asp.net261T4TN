using System;
using System.Collections.Generic;
using System.Text;

namespace Sharp01
{
    class Triangle
    {
        double a, b, c;

        public Triangle(double x, double y, double z)
        {
            a = x;
            b = y;
            c = z;
        }

        public double Perimeter()
        {
            return a + b + c;
        }

        public double Area()
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt((p - a) * (p - b) * (p - c));
        }
    }
}
