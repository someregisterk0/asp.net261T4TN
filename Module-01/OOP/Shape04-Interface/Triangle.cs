using System;
using System.Collections.Generic;
using System.Text;

namespace Shape04_Interface
{
    class Triangle : IShape
    {
        double a, b, c;

        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public double Area()
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt((p - a) * (p - b) * (p - c));
        }

        public double Perimeter()
        {
            return a + b + c;
        }
    }
}
