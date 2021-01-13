﻿using System;
using System.Linq;
using System.Windows.Forms;
using MovieManagementApplication.Database;

namespace MovieManagementApplication
{
    public partial class Form1 : Form
    {
        private readonly MovieEntities db = new MovieEntities();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Lay thong tin tren man hinh giao dien
            string username = txbUsername.Text;
            string password = txbPassword.Text;

            // Kiem tra user co ton tai trong database hay khong
            bool hasUser = db.users.Any(x => x.user_name == username && x.user_password == password);
            if (hasUser == true)
            {
                MessageBox.Show("Đăng nhập thành công");
                // TODO: Mo form menu
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
    }
}