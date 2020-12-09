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
    public partial class FormProduct : Form
    {
        public FormProduct()
        {
            InitializeComponent();
        }

        private void FormProduct_Load(object sender, EventArgs e)
        {
            ProductRepository repository = new ProductRepository();
            gvProduct.DataSource = repository.GetProduct();

            CategoryRepository categoryRepository = new CategoryRepository();
            cbxCategory.DataSource = categoryRepository.GetCategories();
            cbxCategory.DisplayMember = "Name";
            cbxCategory.ValueMember = "Id";
        }
    }
}
