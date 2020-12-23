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
    public partial class FormSignIn : Form
    {
        public FormSignIn()
        {
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            MemberRepository repository = new MemberRepository();
            string usr = txtUserName.Text;
            string pwd = txtPassWord.Text;
            int ret;

            Member obj = repository.SignIn(usr, pwd, out ret);

            if (obj != null)
            {
                MessageBox.Show("Sign in Success");
            }
            else
            {
                string[] msg = { "Username not exists.", "Input passwrod fail." };
                MessageBox.Show(msg[ret]);
            }
        }

        private void btnSignIn2_Click(object sender, EventArgs e)
        {
            MemberRepository repository = new MemberRepository();
            string usr = txtUserName.Text;
            string pwd = txtPassWord.Text;
            int ret;

            Member obj = repository.SignIn2(usr, pwd, out ret);

            if (obj != null)
            {
                MessageBox.Show("Sign in Success");
            }
            else
            {
                string[] msg = { "Username not exists.", "Input passwrod fail." };
                MessageBox.Show(msg[ret]);
            }
        }
    }
}
