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
        string imageUrl = "";

        public FormProduct()
        {
            InitializeComponent();
        }

        private void FormProduct_Load(object sender, EventArgs e)
        {
            ProductRepository repository = new ProductRepository();
            gvProduct.DataSource = repository.GetProduct();

            CategoryRepository categoryRepository = new CategoryRepository();
            cbxCategory.DataSource = categoryRepository.GetCategories2();
            cbxCategory.DisplayMember = "Name";
            cbxCategory.ValueMember = "Id";
        }

        private void ptbImageUrl_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                int index = dialog.FileName.LastIndexOf('\\') + 1;
                imageUrl = dialog.FileName.Substring(index);
                MessageBox.Show(imageUrl);

                ptbImageUrl.Image = Image.FromFile(dialog.FileName);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (imageUrl != "")
            {
                ptbImageUrl.Image.Save($"./images/{imageUrl}");
            }

            ImageConverter imgConverter = new ImageConverter();
            Product obj = new Product()
            {
                CategoryId = (int)cbxCategory.SelectedValue,
                Name = txtName.Text,
                Price = int.Parse(txtPrice.Text),
                Quantity = short.Parse(txtQuantity.Text),
                ImageUrl = imageUrl,
                Description = txtDescription.Text,

                ImageFile = (byte[])imgConverter.ConvertTo(ptbImageUrl.Image, typeof(byte[]))
            };

            ProductRepository repository = new ProductRepository();
            if (repository.Add(obj) > 0)
            {
                MessageBox.Show("Success");
                gvProduct.DataSource = repository.GetProduct();
            }    
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            ProductRepository repository = new ProductRepository();
            int rowIndex = gvProduct.CurrentCell.RowIndex;
            int id = (int)gvProduct[0, rowIndex].Value;

            DataTable table = repository.GetProductById(id);

            DataRow row = table.Rows[0];
            txtId.Text = row["ProductId"].ToString();
            cbxCategory.SelectedValue = row["CategoryId"];
            txtName.Text = row["ProductName"].ToString();
            txtPrice.Text = row["Price"].ToString();
            txtQuantity.Text = row["Quantity"].ToString();
            txtDescription.Text = row["Description"].ToString();
            imageUrl = row["ImageUrl"].ToString();

            // Load image file từ database
            ImageConverter imgConverter = new ImageConverter();
            ptbImageFile.Image = (Image)imgConverter.ConvertFrom(row["ImageFile"]);

            if (!String.IsNullOrEmpty(row["ImageUrl"].ToString()))
            {
                ptbImageUrl.Image = Image.FromFile($"./images/{imageUrl}");
            }
            else
            {
                ptbImageUrl.Image = null;
            }
        }
    }
}
