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
    public partial class Form1 : Form
    {
        BindingList<Category> list = new BindingList<Category>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            list.Add(new Category { Id = 1, Name = "Laptop" });
            list.Add(new Category { Id = 3, Name = "Mouse" });
            list.Add(new Category { Id = 4, Name = "HDD" });
            list.Add(new Category { Id = 9, Name = "Keyboard" });
            list.Add(new Category { Id = 11, Name = "Ram" });

            gvCategory.DataSource = list;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            string name = txtName.Text;

            Category obj = new Category { Id = id, Name = name };
            list.Add(obj);
        }
    }
}
