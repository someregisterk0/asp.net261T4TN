using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoneyChange
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            int m = int.Parse(txtMoney.Text);
            string r = "";

            // array loại tờ
            int[] to = { 50, 20, 10, 5, 1 };

            // array số tờ mỗi loại
            int[] to_count = { 2, 5, 2, 10, 20 };

            for (int i = 0; i < to.Length; ++i)
            {
                if (m >= to[i])
                {
                    int t = m / to[i];
                    if(t > to_count[i])
                    {
                        t = to_count[i];
                    }
                    r += $"{t}  tờ  {to[i]} \n\n";
                    m -= to[i] * t;
                    //if (to_count[i] < (m / to[i]))
                    //{
                    //    r += $"{to_count[i]}  tờ  {to[i]}\n\n";
                    //    m -= (to[i] * to_count[i]);
                    //}
                    //else
                    //{
                    //    r += $"{m / to[i]}  tờ  {to[i]}\n\n";
                    //    m %= to[i];
                    //}
                }
            }

            if(m > 0)
            {
                lblResult.Text = "Không đủ tờ tiền";
            }
             else
            {
                lblResult.Text = r;
            }
        }
    }
}
