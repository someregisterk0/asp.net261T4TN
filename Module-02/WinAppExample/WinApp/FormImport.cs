using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

namespace WinApp
{
    public partial class FormImport : Form
    {
        public FormImport()
        {
            InitializeComponent();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string path = dialog.FileName;
                MessageBox.Show(path);

                string[] arr = File.ReadAllLines(path);
                List<Rating> ratings = new List<Rating>();

                for (int i = 1 ; i < arr.Length; i++) // dòng đầu tiên là tên cột
                {
                    string[] a = arr[i].Split(',');

                    Rating obj = new Rating
                    {
                        UserId = int.Parse(a[0]),
                        MovieId = int.Parse(a[1]),
                        Ratings = (byte)decimal.Parse(a[2]),
                        Timestamp = int.Parse(a[3])
                    };
                    ratings.Add(obj);
                }
                RatingRepository repository = new RatingRepository();
                int s = repository.Add(ratings);
                if (s > 0)
                {
                    MessageBox.Show("Success");
                }
                gvImport.DataSource = ratings;
            }
        }

        private void btnImport2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string path = dialog.FileName;

                string[] arr = File.ReadAllLines(path);

                DataTable table = new DataTable();
                table.Columns.AddRange(new DataColumn[] {
                    new DataColumn("UserId"),
                    new DataColumn("MovieId"),
                    new DataColumn("Rating"),
                    new DataColumn("Timestamp")
                });

                for (int i = 1; i < arr.Length; i++)
                {
                    string[] a = arr[i].Split(',');
                    DataRow row = table.NewRow();
                    row["UserId"] = int.Parse(a[0]);
                    row["MovieId"] = int.Parse(a[1]);
                    row["Rating"] = (byte)decimal.Parse(a[2]);
                    row["Timestamp"] = int.Parse(a[3]);
                    table.Rows.Add(row);
                }
                RatingRepository repository = new RatingRepository();
                repository.Add(table);
                MessageBox.Show("Success");
                gvImport.DataSource = table;
            }
        }

        private void btnImportMovie_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string path = dialog.FileName;

                string[] arr = File.ReadAllLines(path);

                DataTable table = new DataTable();
                table.Columns.AddRange(new DataColumn[] {
                    new DataColumn("MovieId"),
                    new DataColumn("Title"),
                    new DataColumn("Genres")
                });

                for (int i = 1; i < arr.Length; i++)
                {
                    string[] a = arr[i].Split(',');
                    DataRow row = table.NewRow();
                    row["MovieId"] = int.Parse(a[0]);
                    row["Title"] = a[1];
                    row["Genres"] = a[2];
                    table.Rows.Add(row);
                }
                MovieRepository repository = new MovieRepository();
                repository.Add(table);
                MessageBox.Show("Success");
                gvMovie.DataSource = table;
            }
        }
    }
}
