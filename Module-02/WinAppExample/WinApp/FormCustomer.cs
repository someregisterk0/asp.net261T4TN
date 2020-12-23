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
    public partial class FormCustomer : Form
    {
        int page = 1;
        const int size = 100;
        int n;
        CustomerRepository repository = new CustomerRepository();

        public FormCustomer()
        {
            InitializeComponent();
        }

        private void FormCustomer_Load(object sender, EventArgs e)
        {
            repository.GetCustomers(page, size);

            int total = repository.CountCustomer();

            //n = total / size;
            //if (n != 0)
            //{
            //    n++;
            //}

            //n = (int)Math.Ceiling(total / (decimal)size);

            n = (total - 1) / size + 1;

            gvCustomer.DataSource = repository.GetCustomers(page, size);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if(page < n)
            {
                page++;
                gvCustomer.DataSource = repository.GetCustomers(page, size);
            }
        }

        private void btnPre_Click(object sender, EventArgs e)
        {
            if(page > 1)
            {
                page--;
                gvCustomer.DataSource = repository.GetCustomers(page, size);
            }
        }
    }
}
