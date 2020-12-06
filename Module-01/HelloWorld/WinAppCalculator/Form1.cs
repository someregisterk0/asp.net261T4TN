using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtA.Text);
            int b = int.Parse(txtB.Text);

            lblResult.Text = $"{a} + {b} = {a + b}";
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtA.Text);
            int b = int.Parse(txtB.Text);

            lblResult.Text = $"{a} - {b} = {a - b}";
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtA.Text);
            int b = int.Parse(txtB.Text);

            lblResult.Text = $"{a} * {b} = {a * b}";
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtA.Text);
            int b = int.Parse(txtB.Text);

            lblResult.Text = $"{a} / {b} = {a / b}";
        }
    }
}
