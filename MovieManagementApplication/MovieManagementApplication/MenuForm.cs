using System;
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

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình hay không?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
