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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            AccountRepository repository = new AccountRepository();
            Helper.account = repository.Login(txtUserName.Text, txtPassWord.Text);
            if (Helper.account != null)
            {
                MessageBox.Show("Login Success");
                this.Close();
            }
            else
            {
                MessageBox.Show("Fail");
            }
        }
    }
}
