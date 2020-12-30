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
    public partial class FormSearchAndPaginationCustomer : Form
    {
        CustomerRepository repository = new CustomerRepository();
        int page = 1;
        const int size = 100;
        int totalPage = 0;
        public FormSearchAndPaginationCustomer()
        {
            InitializeComponent();
        }

        private void txtQ_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int total = 0;
                gvCustomer.DataSource = repository.SearchCustomer(txtQ.Text, page, size, out total);
                totalPage = ((total - 1) / size) + 1;
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (page > 1)
            {
                page--;
                int total = 0;
                gvCustomer.DataSource = repository.SearchCustomer(txtQ.Text, page, size, out total);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (page < totalPage)
            {
                page++;
                int total = 0;
                gvCustomer.DataSource = repository.SearchCustomer(txtQ.Text, page, size, out total);
            }
        }
    }
}
