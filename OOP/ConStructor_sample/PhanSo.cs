using System;
using System.Collections.Generic;
using System.Text;

namespace ConStructor_sample
{
    class PhanSo
    {
        int tu, mau;

        // Constructor
        public PhanSo()
        {

        }
        public PhanSo(int t, int m)
        {
            tu = t;
            mau = m;
            Console.WriteLine("Constructor call");
        }

        public override string ToString()
        {
            return $"{tu}/{mau}";
        }
    }
}
