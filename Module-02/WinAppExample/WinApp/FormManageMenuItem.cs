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
    public partial class FormManageMenuItem : Form
    {
        MenuItemRepository repository = new MenuItemRepository();
        public FormManageMenuItem()
        {
            InitializeComponent();
        }

        private void FormManageMenuItem_Load(object sender, EventArgs e)
        {
            LoadCbxParent();

            gvMenuItem.DataSource = repository.GetAllMenuItem();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MenuItem obj = new MenuItem
            {
                Id = txtId.Text,
                Name = txtName.Text,
                FormName = string.IsNullOrEmpty(txtFormName.Text) ? null : txtFormName.Text
            };
            if (cbxParent.SelectedValue != null)
            {
                obj.ParentId = cbxParent.SelectedValue.ToString();
            }
            if (repository.AddMenuItem(obj) > 0)
            {
                MessageBox.Show("Success");
                LoadCbxParent();
                gvMenuItem.DataSource = repository.GetAllMenuItem();
            }
        }

        private void LoadCbxParent()
        {
            List<MenuItem> list = repository.GetParents();
            list.Insert(0, new MenuItem { Id = null, Name = "Non Parent" });
            cbxParent.DataSource = list;
            cbxParent.DisplayMember = "Name";
            cbxParent.ValueMember = "Id";
        }
    }
}
