using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void btnAdd_Click(object sender, EventArgs e)
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
                db.movies.Add(movie);
                db.SaveChanges();

                MessageBox.Show("Thêm movie thành công");
            }
            catch (Exception)
            {
                MessageBox.Show("Thêm movie thất bại");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
