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

        private void btnView_Click(object sender, EventArgs e)
        {
            char kv = Convert.ToChar(cbxKhuVuc.SelectedItem);
            int dt = Convert.ToInt16(cbxDoiTuong.SelectedItem);
            decimal total = nudMon1.Value + nudMon2.Value + nudMon3.Value;

            decimal[] akv = { 2, 1, 0.5m };
            decimal[] adt = { 2.5m, 1.5m, 1 };

            total += akv[kv - 'A'];
            total += adt[dt - 1];

            if(total >= nudDiemChuan.Value)
            {
                lblResult.Text = $"Khu vực {kv}, Đối tượng {dt}, Tổng điểm: {total}\nYou Pass";
            } else
            {
                lblResult.Text = $"Khu vực {kv}, Đối tượng {dt}, Tổng điểm: {total}\nYou NOT Pass";
            }
        }
    }
}
