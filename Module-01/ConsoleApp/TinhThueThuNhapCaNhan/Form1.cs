using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TinhThueThuNhapCaNhan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            decimal income = nudIncome.Value;
            decimal tmpIncome = income;
            decimal tax = 0;

            // 0 - 5
            if ((tmpIncome - 5) > 0)
            {
                tmpIncome -= 5;
                tax += 5 * 0.05m;
            }
            else
            {
                tax += tmpIncome * 0.05m;
                lblResult.Text = tax.ToString();
                return;
            }

            // 5 - 10\
            if ((tmpIncome - 5) > 0)
            {
                tmpIncome -= 5;
                tax += 5 * 0.1m;
            }
            else
            {
                tax += tmpIncome * 0.1m;
                lblResult.Text = tax.ToString();
                return;
            }

            // 10 - 18
            if ((tmpIncome - 8) > 0)
            {
                tmpIncome -= 8;
                tax += 8 * 0.15m;
            }
            else
            {
                tax += tmpIncome * 0.15m;
                lblResult.Text = tax.ToString();
                return;
            }

            // 18 - 32
            if ((tmpIncome - 14) > 0)
            {
                tmpIncome -= 14;
                tax += 14 * 0.2m;
            }
            else
            {
                tax += tmpIncome * 0.2m;
                lblResult.Text = tax.ToString();
                return;
            }

            // 32 - 52
            if ((tmpIncome - 20) > 0)
            {
                tmpIncome -= 20;
                tax += 20 * 0.25m;
            }
            else
            {
                tax += tmpIncome * 0.25m;
                lblResult.Text = tax.ToString();
                return;
            }

            // 52 - 80
            if ((tmpIncome - 28) > 0)
            {
                tmpIncome -= 28;
                tax += 28 * 0.3m;
            }
            else
            {
                tax += tmpIncome * 0.3m;
                lblResult.Text = tax.ToString();
                return;
            }

            // > 80
            if ((tmpIncome) > 80)
            {
                tax += tmpIncome * 0.35m;
                lblResult.Text = tax.ToString();
                return;
            }
        }
    }
}
