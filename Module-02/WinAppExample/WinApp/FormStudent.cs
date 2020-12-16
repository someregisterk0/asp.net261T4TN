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
            gvStudent.Columns[3].DefaultCellStyle.Format = "dd/MM/yyyy";

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

            int ret = 0;
            if(string.IsNullOrEmpty(txtId.Text)) // Thêm mới
            {
                ret = repository.AddStudent(obj);
            }
            else // Edit
            {
                obj.Id = int.Parse(txtId.Text);
                ret = repository.EditStudent(obj);
                btnEdit.Text = "Edit";
            }

            if(ret > 0)
            {
                Clear();
                MessageBox.Show("Success.");
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (btnEdit.Text.Equals("Edit"))
            {
                btnEdit.Text = "Cancel";

                StudentRepository repository = new StudentRepository();

                int rowIndex = gvStudent.CurrentCell.RowIndex;
                int id = (int)gvStudent["ColId", rowIndex].Value;

                Student obj = repository.GetStudentById(id);

                txtId.Text = obj.Id.ToString();
                txtFullName.Text = obj.FullName;
                txtEmail.Text = obj.Email;
                dtpDateOfBirth.Value = obj.DateOfBirth;
                txtPlaceOfBirth.Text = obj.PlaceOfBirth;
                cbxGender.SelectedValue = obj.Gender;
                txtPhone.Text = obj.Phone;
                txtAddress.Text = obj.Address;
            }
            else
            {
                btnEdit.Text = "Edit";
                Clear();
            }
        }

        public void Clear()
        {
            txtId.Clear();
            txtFullName.Clear();
            txtEmail.Clear();
            dtpDateOfBirth.Value = DateTime.Now;
            txtPlaceOfBirth.Clear();
            txtPhone.Clear();
            txtAddress.Clear();
        }
    }
}
