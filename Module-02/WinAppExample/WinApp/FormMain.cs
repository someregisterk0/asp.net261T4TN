using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinApp
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void LoginMenuItem_Click(object sender, EventArgs e)
        {
            FormLogin form = new FormLogin();
            form.ShowDialog();
            if(Helper.account != null)
            {
                OnOff(false);
            }

        }

        private void registerMenuItem_Click(object sender, EventArgs e)
        {
            FormAccount form = new FormAccount();
            form.MdiParent = this;
            form.Show();
        }

        private void productMenuItem_Click(object sender, EventArgs e)
        {
            FormProduct form = new FormProduct();
            form.MdiParent = this;
            form.Show();
        }

        private void categoryMenuItem_Click(object sender, EventArgs e)
        {
            FormCategory form = new FormCategory();
            form.MdiParent = this;
            form.Show();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            OnOff(true);
        }

        public void OnOff(bool enable)
        {
            categoryMenuItem.Enabled = !enable;
            productMenuItem.Enabled = !enable;
            logoutMenuItem.Enabled = !enable;
            changePasswordMenuItem.Enabled = !enable;

            LoginMenuItem.Enabled = enable;
            registerMenuItem.Enabled = enable;
        }

        private void logoutMenuItem_Click(object sender, EventArgs e)
        {
            Helper.account = null;
            OnOff(true);
        }

        private void changePasswordMenuItem_Click(object sender, EventArgs e)
        {
            FormChangePassword form = new FormChangePassword();
            form.ShowDialog();
            if(Helper.account == null)
            {
                OnOff(true);
            }
        }
    }
}
