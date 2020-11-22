using System;
using System.Collections.Generic;
using System.Text;

namespace Shape02
{
    class Triangle : Shape
    {
        double a, b, c;
        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public override double Perimeter()
        {
            return a + b + c;
        }

        public override double Area()
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt((p - a) * (p - b) * (p - c));
        }
    }
}
