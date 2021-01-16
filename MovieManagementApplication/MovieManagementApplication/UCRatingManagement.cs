using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MovieManagementApplication.Database;

namespace MovieManagementApplication
{
    public partial class UCRatingManagement : UserControl
    {
        private readonly MovieEntities db = new MovieEntities();

        public UCRatingManagement()
        {
            InitializeComponent();
        }

        private void UCRatingManagement_Load(object sender, EventArgs e)
        {
            List<rating> ratings = db.ratings.ToList();
            dataGridViewRating.DataSource = ratings;
        }

        private void ReloadDataGird()
        {
            dataGridViewRating.Columns.Clear();
            List<rating> ratings = db.ratings.ToList();
            dataGridViewRating.DataSource = ratings;
        }

        public bool CheckUserRoleForRatingPage()
        {
            UserType userType = Constants.GetUserType();
            switch (userType)
            {
                case UserType.Admin:
                case UserType.Reviewer:
                    return true;

                case UserType.Actor:
                case UserType.Director:
                default:
                    return false;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (CheckUserRoleForRatingPage())
            {
                AddRating();
            }
        }

        private void AddRating()
        {
            //reviewer reviewer = db.reviewers.FirstOrDefault(x=>x.rev_id==)
            //rating rating = new rating();
            //rating.rev_id = ;
            //rating.num_o_ratings = ;
            //rating.rev_stars = ;
            //db.ratings.Add(rating);
        }
    }
}
