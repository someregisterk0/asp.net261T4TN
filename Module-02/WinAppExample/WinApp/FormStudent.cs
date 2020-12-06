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
    public partial class FormStudent : Form
    {
        public FormStudent()
        {
            InitializeComponent();
        }

        private void FormStudent_Load(object sender, EventArgs e)
        {
            StudentRepository repository = new StudentRepository();
            gvStudent.DataSource = repository.GetStudents();

            List<Gender> list = new List<Gender>()
            {
                new Gender{Id = true, Name = "Male" },
                new Gender{Id = false, Name = "Female" }
            };

            cbxGender.DataSource = list;
            cbxGender.DisplayMember = "Name";
            cbxGender.ValueMember = "Id";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(cbxGender.SelectedValue.ToString());

            StudentRepository repository = new StudentRepository();

            Student obj = new Student()
            {
                FullName = txtFullName.Text,
                Email = txtEmail.Text,
                DateOfBirth = dtpDateOfBirth.Value,
                PlaceOfBirth = txtPlaceOfBirth.Text,
                Address = txtAddress.Text,
                Phone = txtPhone.Text,
                Gender = (bool)cbxGender.SelectedValue
            };

            if(repository.AddStudent(obj) > 0)
            {
                MessageBox.Show("Add Success.");
                gvStudent.DataSource = repository.GetStudents();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int rowIndex = gvStudent.CurrentCell.RowIndex;
            int id = (int)gvStudent["ColId", rowIndex].Value;

            StudentRepository repository = new StudentRepository();
            if(repository.DeleteStudent(id) > 0)
            {
                MessageBox.Show("Delete Success.");
                gvStudent.DataSource = repository.GetStudents();
            }
        }
    }
}
