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
    public partial class FormChangePassword : Form
    {
        public FormChangePassword()
        {
            InitializeComponent();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            AccountRepository repository = new AccountRepository();
            int ret = repository.ChangePassword(Helper.account.Username, txtOldPassword.Text, txtNewPassword.Text);
            if (ret > 0)
            {
                MessageBox.Show("Change Password Success.");
                Helper.account = null;
                this.Close();
            }
            else
            {
                MessageBox.Show("Old Password Fail.");
            }
        }
    }
}
