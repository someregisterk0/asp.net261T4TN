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
    public partial class FormAccount : Form
    {
        public FormAccount()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            AccountRepository repository = new AccountRepository();

            Account obj = new Account()
            {
                Username = txtUserName.Text,
                Password = txtPassWord.Text,
                Email = txtEmail.Text
            };

            if (repository.Add(obj) > 0)
            {
                MessageBox.Show("Success");
            }
        }
    }
}
