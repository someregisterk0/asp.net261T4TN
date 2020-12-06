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
    public partial class FormCategory : Form
    {
        public FormCategory()
        {
            InitializeComponent();
        }

        private void FormCategory_Load(object sender, EventArgs e)
        {
            CategoryRepository repository = new CategoryRepository();
            gvCategory.DataSource = repository.GetCategories();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Category obj = new Category() {
                Name = txtName.Text
            };
            CategoryRepository repository = new CategoryRepository();
            if (repository.Add(obj) > 0)
            {
                MessageBox.Show("Add success");
            }
            //FormCategory_Load(sender, e);
            gvCategory.DataSource = repository.GetCategories();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure delete?", "Delete Row", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int rowIndex = gvCategory.CurrentCell.RowIndex;
                int id = (int)gvCategory["ColId", rowIndex].Value;
                CategoryRepository repository = new CategoryRepository();
                if (repository.Delete(id) > 0)
                {
                    MessageBox.Show("Delete Success");
                    gvCategory.DataSource = repository.GetCategories();
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int rowIndex = gvCategory.CurrentCell.RowIndex;
            int id = (int)gvCategory["ColId", rowIndex].Value;

            CategoryRepository repository = new CategoryRepository();

            Category obj = repository.GetCategoryById(id);

            txtId.Text = obj.Id.ToString();
            txtName.Text = obj.Name;
        }
    }
}
