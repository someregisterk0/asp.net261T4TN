using System;
using System.Collections.Generic;
using System.Text;

namespace Sharp01
{
    class Square
    {
        double canh;
        public Square(double a)
        {
            canh = a;
        }

        public double Perimeter()
        {
            return canh * 4;
        }

        public double Area()
        {
            return canh * canh;
        }
    }
}
