﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieManagementApplication
{
    public partial class MenuForm : Form
    {
        public Action CloseAction;
        public string avatarPath;
        public string userName;

        public MenuForm()
        {
            InitializeComponent();
        }

        private void InitUI()
        {
            labelUserName.Text = userName;
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
            InitUI();
        }

        private void MenuForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
