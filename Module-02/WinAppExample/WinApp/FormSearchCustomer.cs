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
    public partial class FormSearchCustomer : Form
    {
        CustomerRepository repository = new CustomerRepository();
        public FormSearchCustomer()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //gvCustomer.DataSource = repository.SearchCustomer(txtQ.Text);
            string city = (string)cbxCity.SelectedValue;
            gvCustomer.DataSource = repository.SearchCustomer2(txtQ.Text, city);
        }

        private void txtQ_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //gvCustomer.DataSource = repository.SearchCustomer(txtQ.Text);
                string city = (string)cbxCity.SelectedValue;
                gvCustomer.DataSource = repository.SearchCustomer2(txtQ.Text, city);
            }
        }

        private void FormSearchCustomer_Load(object sender, EventArgs e)
        {
            List<string> state = repository.GetState();
            state.Insert(0, "All");
            cbxState.DataSource = state;
        }

        private void cbxState_SelectedIndexChanged(object sender, EventArgs e)
        {
            string state = (string)cbxState.SelectedValue;

            cbxCity.DataSource = repository.GetCities(state.Equals("All") ? null : state);

            /*
            if (state.Equals("All"))
            {
                cbxCity.DataSource = repository.GetCities();
            }
            else
            {
                cbxCity.DataSource = repository.GetCities(state);
            }
            */
        }
    }
}
