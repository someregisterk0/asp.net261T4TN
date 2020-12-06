using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XemDiem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        float[] scores = { 3, 5, 7, 8.1f, 9, 10 };
        string[] rank = { "Yếu", "Kém", "Trung Bình", "Khá", "Giỏi", "Xuất Sắc" };
        private void btnView_Click(object sender, EventArgs e)
        {
            float d = float.Parse(txtDiem.Text);

            for(int i = 0; i < scores.Length; ++i)
            {
                if(d < scores[i])
                {
                    lblResult.Text = rank[i];
                    break;
                }
            }
        }
    }
}
