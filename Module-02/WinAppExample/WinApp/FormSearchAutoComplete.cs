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
    public partial class FormSearchAutoComplete : Form
    {
        CustomerRepository repository = new CustomerRepository();
        public FormSearchAutoComplete()
        {
            InitializeComponent();
        }

        private void FormSearchAutoComplete_Load(object sender, EventArgs e)
        {
            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
            List<string> list = repository.GetFirstName();
            collection.AddRange(list.ToArray());

            txtQ.AutoCompleteCustomSource = collection;
            txtQ.AutoCompleteMode = AutoCompleteMode.Suggest;

            txtQ.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void txtQ_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                gvCustomer.DataSource = repository.SearchCustomer(txtQ.Text);
            }
        }
    }
}
