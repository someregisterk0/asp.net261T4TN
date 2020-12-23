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
    public partial class FormSignup : Form
    {
        public FormSignup()
        {
            InitializeComponent();
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            Member obj = new Member
            {
                Username = txtUserName.Text,
                Password = txtPassWord.Text,
                Email = txtEmail.Text
            };

            MemberRepository repository = new MemberRepository();
            string[] msg = { "Username exists", "Success" };

            int ret = repository.Add(obj);

            MessageBox.Show(msg[ret]);
        }

        private void btnSignUp2_Click(object sender, EventArgs e)
        {
            Member obj = new Member
            {
                Username = txtUserName.Text,
                Password = txtPassWord.Text,
                Email = txtEmail.Text
            };

            MemberRepository repository = new MemberRepository();
            string[] msg = { "Username exists", "Success" };

            int ret = repository.Add2(obj);

            MessageBox.Show(msg[ret]);
        }
    }
}
