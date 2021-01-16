using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MovieManagementApplication.Database;

namespace MovieManagementApplication
{
    public partial class UCMovieManagement : UserControl
    {
        private readonly MovieEntities db = new MovieEntities();
        public UCMovieManagement()
        {
            InitializeComponent();
        }

        private void UCMovieManagement_Load(object sender, EventArgs e)
        {
            List<movie> movies = db.movies.ToList();
            dataGridViewMovie.DataSource = movies;
        }

        public bool CheckUserRoleForMoviePage()
        {
            UserType userType = Constants.GetUserType();
            switch (userType)
            {
                case UserType.Admin:
                    return true;

                case UserType.Reviewer:
                case UserType.Actor:
                case UserType.Director:
                default:
                    return false;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (CheckUserRoleForMoviePage())
            {
                AddMovie();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền được thêm movie mới");
            }
        }

        private void AddMovie()
        {
            if (txbMovieTitle.Text == ""
                || txbMovieYear.Text == ""
                || txbMovieReleaseCountry.Text == ""            
                || txbMovieTime.Text == ""
                || txbMovieLanguage.Text == "")
            {
                MessageBox.Show("Thông tin chưa đủ");
            }

            try
            {
                movie movie = new movie();
                movie.mov_title = txbMovieTitle.Text;
                movie.mov_year = Convert.ToInt32(txbMovieYear.Text);
                movie.mov_rel_country = txbMovieReleaseCountry.Text;
                movie.mov_time = Convert.ToInt32(txbMovieTime.Text);
                movie.mov_lang = txbMovieLanguage.Text;
                movie.mov_dt_rel = dpMovieReleaseDate.Value;
                movie.mov_image = txbMovieImage.Text;

                db.movies.Add(movie);
                db.SaveChanges();

                MessageBox.Show("Thêm movie thành công");

                ReloadDataGird();
            }
            catch (Exception)
            {
                MessageBox.Show("Thêm movie thất bại");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (CheckUserRoleForMoviePage())
            {
                UpdateMovie();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền được sửa movie mới");
            }
        }

        private void UpdateMovie()
        {
            int movieId = Convert.ToInt32(txbMovieId.Text);

            if (txbMovieTitle.Text == ""
                || txbMovieYear.Text == ""
                || txbMovieReleaseCountry.Text == ""
                || txbMovieTime.Text == ""
                || txbMovieLanguage.Text == "")
            {
                MessageBox.Show("Thông tin chưa đủ");
            }
            else
            {
                movie movie = db.movies.FirstOrDefault(x => x.mov_id == movieId);
                if (movie == null)
                {
                    MessageBox.Show("Phim không tồn tại, sửa không thành công");
                }
                else
                {
                    try
                    {
                        movie.mov_title = txbMovieTitle.Text;
                        movie.mov_year = Convert.ToInt32(txbMovieYear.Text);
                        movie.mov_rel_country = txbMovieReleaseCountry.Text;
                        movie.mov_time = Convert.ToInt32(txbMovieTime.Text);
                        movie.mov_lang = txbMovieLanguage.Text;
                        movie.mov_dt_rel = dpMovieReleaseDate.Value;
                        movie.mov_image = txbMovieImage.Text;

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
            if (CheckUserRoleForMoviePage())
            {
                DeleteMovie();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền được xoá movie");
            }
        }

        private void DeleteMovie()
        {
            int movieId = Convert.ToInt32(txbMovieId.Text);

            movie movie = db.movies.FirstOrDefault(x => x.mov_id == movieId);
            if (movie == null)
            {
                MessageBox.Show("Phim không tồn tại, xoá không thành công");
            }
            else
            {
                try
                {
                    db.movies.Remove(movie);
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
            dataGridViewMovie.Columns.Clear();
            List<movie> movies = db.movies.ToList();
            dataGridViewMovie.DataSource = movies;
        }

        private void dataGridViewMovie_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewMovie.Rows[e.RowIndex];
                txbMovieId.Text = row.Cells[0].Value.ToString();
                txbMovieTitle.Text = row.Cells[1].Value.ToString();
                txbMovieYear.Text = row.Cells[2].Value.ToString();
                txbMovieTime.Text = row.Cells[3].Value.ToString();
                txbMovieLanguage.Text = row.Cells[4].Value.ToString();

                dpMovieReleaseDate.Value = DateTime.Parse(row.Cells[5].Value.ToString());

                txbMovieReleaseCountry.Text = row.Cells[6].Value.ToString();
            }
        }

        private void btnSelectMovieImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.png)|*.jpg; *.jpeg; *.png";

            if (open.ShowDialog() == DialogResult.OK)
            {
                txbMovieImage.Text = open.FileName;
            }
        }
    }
}
