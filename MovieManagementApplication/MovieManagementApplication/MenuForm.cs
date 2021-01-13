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
        private readonly string avatarPath;
        private readonly string userName;

        public MenuForm(string avatarPath, string userName)
        {
            InitializeComponent();

            this.avatarPath = avatarPath;
            this.userName = userName;
            // TODO: Them hinh avatar
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
            CloseAction();
        }
    }
}
