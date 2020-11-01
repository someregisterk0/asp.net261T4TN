using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormBaoBuaKeo
{
    public partial class Form1 : Form
    {
        Random rand = new Random();
        string[] chon = { "Bao", "Búa", "Kéo" };

        string[,] array_KetQua =
            {
                {"Hòa", "Thắng", "Thua" },
                {"Thua", "Hòa", "Thắng" },
                {"Thắng", "Thua", "Hòa" }
            };
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBao_Click(object sender, EventArgs e)
        {
            KetQua(0);
        }

        private void btnBua_Click(object sender, EventArgs e)
        {
            KetQua(1);
        }

        private void btnKeo_Click(object sender, EventArgs e)
        {
            KetQua(2);
        }

        private void KetQua(int i)
        {
            // máy nhập
            Random rand = new Random();
            int com = rand.Next(0, 3);

            // người nhập
            int hum = i;

            // kiểm tra kết quả
            lblMayChon.Text = chon[com];
            lblNguoiChon.Text = chon[hum];
            lblResult.Text = $"Nguoi: {array_KetQua[hum, com]}";
        }
    }
}
