using System;
using System.Collections.Generic;
using System.Text;

namespace Sharp01
{
    class Rectangle
    {
        double dai, rong;

        public Rectangle(double d, double r)
        {
            dai = d;
            rong = r;
        }

        public double Perimeter()
        {
            return (dai + rong) * 2;
        }

        public double Area()
        {
            return dai * rong;
        }
    }
}
