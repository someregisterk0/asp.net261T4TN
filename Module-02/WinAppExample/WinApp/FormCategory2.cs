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
    public partial class FormCategory2 : Form
    {
        CategoryRepository repository = new CategoryRepository();
        public FormCategory2()
        {
            InitializeComponent();
        }

        private void FormCategory2_Load(object sender, EventArgs e)
        {
            gvCategory.DataSource = repository.GetCategories2();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Category obj = new Category { Name = txtName.Text };
            if (repository.Add2(obj) > 0)
            {
                MessageBox.Show("Success");
                gvCategory.DataSource = repository.GetCategories2();
            }
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int rowIndex = gvCategory.CurrentCell.RowIndex;
            int id = (int)gvCategory["ColId", rowIndex].Value;
            if (repository.Delete2(id) > 0)
            {
                MessageBox.Show("Success");
                gvCategory.DataSource = repository.GetCategories2();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            Category obj = repository.GetCategoryById(id);
            obj.Name = txtName.Text;

            if (repository.Edit2(obj) > 0)
            {
                MessageBox.Show("Success");
                gvCategory.DataSource = repository.GetCategories2();
            }
            
        }

        private void gvCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = gvCategory.CurrentCell.RowIndex;
            int id = (int)gvCategory["ColId", rowIndex].Value;

            Category obj = repository.GetCategoryById(id);

            txtId.Text = obj.Id.ToString();
            txtName.Text = obj.Name;
        }
    }
}
