using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MovieManagementApplication.Database;

namespace MovieManagementApplication
{
    public partial class UCActorManagement : UserControl
    {
        private readonly MovieEntities db = new MovieEntities();
        public UCActorManagement()
        {
            InitializeComponent();
        }

        private void UCActorManagement_Load(object sender, EventArgs e)
        {
            List<actor> actors = db.actors.ToList();
            dataGridViewActor.DataSource = actors;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txbActorFirstName.Text == ""
                || txbActorLastName.Text == ""
                || cbbActorGender.selectedValue == "")
            {
                MessageBox.Show("Thông tin chưa đủ");
            }

            try
            {
                actor actor = new actor();
                actor.act_fname = txbActorFirstName.Text;
                actor.act_lname = txbActorLastName.Text;
                actor.act_gender = cbbActorGender.selectedValue;
                db.actors.Add(actor);
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
            int actorId = Convert.ToInt32(txbActorId.Text);

            if (txbActorFirstName.Text == ""
                || txbActorLastName.Text == ""
                || cbbActorGender.selectedValue == "")
            {
                MessageBox.Show("Thông tin chưa đủ");
            }
            else
            {
                actor actor = db.actors.FirstOrDefault(x => x.act_id == actorId);
                if (actor == null)
                {
                    MessageBox.Show("Actor không tồn tại, sửa không thành công");
                }
                else
                {
                    try
                    {
                        actor.act_fname = txbActorFirstName.Text;
                        actor.act_lname = txbActorLastName.Text;
                        actor.act_gender = cbbActorGender.selectedValue;

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
            int actorId = Convert.ToInt32(txbActorId.Text);

            actor actor = db.actors.FirstOrDefault(x => x.act_id == actorId);
            if (actor == null)
            {
                MessageBox.Show("Actor không tồn tại, xoá không thành công");
            }
            else
            {
                try
                {
                    db.actors.Remove(actor);
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
            dataGridViewActor.Columns.Clear();
            List<actor> actors = db.actors.ToList();
            dataGridViewActor.DataSource = actors;
        }

        private void dataGridViewMovie_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewActor.Rows[e.RowIndex];
                txbActorId.Text = row.Cells[0].Value.ToString();
                txbActorFirstName.Text = row.Cells[1].Value.ToString();
                txbActorLastName.Text = row.Cells[2].Value.ToString();

                if (row.Cells[3].Value.ToString() == "M")
                {
                    cbbActorGender.selectedIndex = 0;
                }
                else
                {
                    cbbActorGender.selectedIndex = 1;
                }
            }
        }
    }
}
