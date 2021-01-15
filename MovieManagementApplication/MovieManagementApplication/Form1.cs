using MovieManagementApplication.Database;
using System;
using System.Linq;
using System.Windows.Forms;

namespace MovieManagementApplication
{
    public partial class Form1 : Form
    {
        private readonly MovieEntities db = new MovieEntities();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Lay thong tin tren man hinh giao dien
            string username = txbUsername.Text;
            string password = txbPassword.Text;

            // Kiem tra user co ton tai trong database hay khong
            user user = db.users.FirstOrDefault(x => x.user_name == username && x.user_password == password);
            if (user != null)
            {
                MessageBox.Show("Đăng nhập thành công");

                MenuForm menuForm = new MenuForm();
                //menuForm.avatarPath = user.user_avatar;
                menuForm.userName = user.user_name;
                menuForm.CloseAction = () =>
                {
                    menuForm.Close();
                    this.Show();
                };

                this.Hide();
                menuForm.Show();

            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại");
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // Lay thong tin tren man hinh giao dien
            string username = txbUsername.Text;
            string password = txbPassword.Text;

            // Kiem tra user co ton tai trong database hay khong
            bool hasUser = db.users.Any(x => x.user_name == username && x.user_password == password);
            if (hasUser == true)
            {
                MessageBox.Show("Tài khoản đã tồn tại, đăng ký thất bại");
            }
            else
            {
                string type = cbbUserType.selectedValue;

                user newUser = new user();
                newUser.user_name = username;
                newUser.user_password = password;
                newUser.user_type = type;

                try
                {
                    db.users.Add(newUser);
                    db.SaveChanges();
                    MessageBox.Show("Đăng ký thành công");
                }
                catch (Exception)
                {
                    MessageBox.Show("Đăng ký thất bại");
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
