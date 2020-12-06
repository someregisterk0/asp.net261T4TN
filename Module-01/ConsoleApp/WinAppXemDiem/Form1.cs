using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppXemDiem
{
    public partial class Form1 : Form
    {
        int[] array_Listening = { 5, 5, 5, 5, 5, 5, 5, 10, 15, 20, 25, 30, 35, 40, 45, 50, 55, 60, 65, 70, 75, 80, 85, 90, 95, 100, 110, 115, 120, 125, 130, 135, 140, 145, 150, 160, 165, 170, 175, 180, 185, 190, 195, 200, 210, 215, 220, 230, 240, 245, 250, 255, 260, 270, 275, 280, 290, 295, 300, 310, 315, 320, 325, 330, 340, 345, 350, 360, 365, 370, 380, 385, 390, 395, 400, 405, 410, 420, 425, 430, 440, 445, 450, 460, 465, 470, 475, 480, 485, 490, 495, 495, 495, 495, 495, 495, 495, 495, 495, 495, 495 };

        int[] array_Reading = { 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 10, 15, 20, 25, 30, 35, 40, 45, 50, 60, 65, 70, 80, 85, 90, 95, 100, 110, 115, 120, 125, 130, 140, 145, 150, 160, 165, 170, 175, 180, 190, 195, 200, 210, 215, 220, 225, 230, 235, 240, 250, 255, 260, 265, 270, 280, 285, 290, 300, 305, 310, 320, 325, 330, 335, 340, 350, 355, 360, 365, 370, 380, 385, 390, 395, 400, 405, 410, 415, 420, 425, 430, 435, 445, 450, 455, 465, 470, 480, 485, 490, 495, 495, 495, 495 };

        public Form1()
        {
            InitializeComponent();
        }

        private void btnXemDiem_Click(object sender, EventArgs e)
        {
            int l = int.Parse(txtListening.Text);
            int r = int.Parse(txtReading.Text);

            lblDiem.Text = $"{array_Listening[l] + array_Reading[r]}";
        }
    }
}
