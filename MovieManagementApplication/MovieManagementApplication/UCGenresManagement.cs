using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MovieManagementApplication.Database;

namespace MovieManagementApplication
{
    public partial class UCGenresManagement : UserControl
    {
        private readonly MovieEntities db = new MovieEntities();

        public UCGenresManagement()
        {
            InitializeComponent();
        }

        private void UCGenresManagement_Load(object sender, EventArgs e)
        {
            List<genre> genres = db.genres.ToList();
            dataGridViewGenres.DataSource = genres;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txbGenresTitle.Text == "")
            {
                MessageBox.Show("Thông tin chưa đủ");
            }

            try
            {
                genre genre = new genre();
                genre.gen_title = txbGenresTitle.Text;
                db.genres.Add(genre);
                db.SaveChanges();

                MessageBox.Show("Thêm genres thành công");

                ReloadDataGird();
            }
            catch (Exception)
            {
                MessageBox.Show("Thêm genres thất bại");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int genrerId = Convert.ToInt32(txbGenresId.Text);

            if (txbGenresTitle.Text == "")
            {
                MessageBox.Show("Thông tin chưa đủ");
            }
            else
            {
                genre genre = db.genres.FirstOrDefault(x => x.gen_id == genrerId);
                if (genre == null)
                {
                    MessageBox.Show("Genres không tồn tại, sửa không thành công");
                }
                else
                {
                    try
                    {
                        genre.gen_title= txbGenresTitle.Text;

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
            int genresId = Convert.ToInt32(txbGenresId.Text);

            genre genre = db.genres.FirstOrDefault(x => x.gen_id == genresId);
            if (genre == null)
            {
                MessageBox.Show("Genres không tồn tại, xoá không thành công");
            }
            else
            {
                try
                {
                    db.genres.Remove(genre);
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
            dataGridViewGenres.Columns.Clear();
            List<genre> genres = db.genres.ToList();
            dataGridViewGenres.DataSource = genres;
        }

        private void dataGridViewGenres_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dataGridViewGenres.CurrentCell.RowIndex;
            txbGenresId.Text = dataGridViewGenres.Rows[index].Cells[0].Value.ToString();
            txbGenresTitle.Text = dataGridViewGenres.Rows[index].Cells[1].Value.ToString();



            //if (e.RowIndex >= 0)
            //{
            //    DataGridViewRow row = dataGridViewGenres.Rows[e.RowIndex];
            //}
        }
    }
}
