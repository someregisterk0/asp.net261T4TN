using System;
using System.Collections.Generic;
using System.Text;

namespace Sharp01
{
    class Circle
    {
        double radius;

        public Circle(double r)
        {
            radius = r;
        }

        public double Perimeter()
        {
            return Math.PI * 2 * radius;
        }

        public double Area()
        {
            return Math.PI * radius * radius;
        }
    }
}
