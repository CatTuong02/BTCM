using MovieManagementApplication.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MovieManagementApplication
{
    public partial class UCDirectorManagement : UserControl
    {
        private static MovieEntities db = new MovieEntities();
        public UCDirectorManagement()
        {
            InitializeComponent();
        }

        private void UCDirectorManagement_Load(object sender, EventArgs e)
        {
            List<director> directors = db.directors.ToList();
            dataGridViewDirector.DataSource = directors;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txbDirectorFirstName.Text == ""
                || txbDirectorLastName.Text == "")
            {
                MessageBox.Show("Thông tin chưa đủ");
            }

            try
            {
                director director = new director();
                director.dir_fname = txbDirectorFirstName.Text;
                director.dir_lname = txbDirectorLastName.Text;

                db.directors.Add(director);
                db.SaveChanges();

                MessageBox.Show("Thêm actor thành công");

                ReloadDataGird();
            }
            catch (Exception)
            {
                MessageBox.Show("Thêm actor thất bại");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int directorId = Convert.ToInt32(txbDirectorId.Text);

            if (txbDirectorFirstName.Text == ""
                || txbDirectorLastName.Text == "")
            {
                MessageBox.Show("Thông tin chưa đủ");
            }
            else
            {
                director director = db.directors.FirstOrDefault(x => x.dir_id == directorId);
                if (director == null)
                {
                    MessageBox.Show("Director không tồn tại, sửa không thành công");
                }
                else
                {
                    try
                    {
                        director.dir_fname = txbDirectorFirstName.Text;
                        director.dir_lname = txbDirectorLastName.Text;

                        db.SaveChanges();
                        MessageBox.Show("Sửa thành công");

                        ReloadDataGird();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Sửa không thành công");
                    }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int directorId = Convert.ToInt32(txbDirectorId.Text);

            director director = db.directors.FirstOrDefault(x => x.dir_id == directorId);
            if (director == null)
            {
                MessageBox.Show("Director không tồn tại, xoá không thành công");
            }
            else
            {
                try
                {
                    db.directors.Remove(director);
                    db.SaveChanges();

                    MessageBox.Show("Xoá thành công");

                    ReloadDataGird();
                }
                catch (Exception)
                {
                    MessageBox.Show("Xoá không thành công");
                }
            }
        }

        private void ReloadDataGird()
        {
            dataGridViewDirector.Columns.Clear();
            List<director> directors = db.directors.ToList();
            dataGridViewDirector.DataSource = directors;
        }

        private void dataGridViewDirector_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewDirector.Rows[e.RowIndex];
                txbDirectorId.Text = row.Cells[0].Value.ToString();
                txbDirectorFirstName.Text = row.Cells[1].Value.ToString();
                txbDirectorLastName.Text = row.Cells[2].Value.ToString();
            }
        }
    }
}
