namespace MovieManagementApplication
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txbUsername = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txbPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.cbbUserType = new Bunifu.Framework.UI.BunifuDropdown();
            this.btnLogin = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnRegister = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.SuspendLayout();
            // 
            // txbUsername
            // 
            this.txbUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbUsername.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txbUsername.ForeColor = System.Drawing.Color.Black;
            this.txbUsername.HintForeColor = System.Drawing.Color.Empty;
            this.txbUsername.HintText = "";
            this.txbUsername.isPassword = false;
            this.txbUsername.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(230)))), ((int)(((byte)(94)))));
            this.txbUsername.LineIdleColor = System.Drawing.Color.SeaGreen;
            this.txbUsername.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(230)))), ((int)(((byte)(94)))));
            this.txbUsername.LineThickness = 3;
            this.txbUsername.Location = new System.Drawing.Point(174, 103);
            this.txbUsername.Margin = new System.Windows.Forms.Padding(4);
            this.txbUsername.Name = "txbUsername";
            this.txbUsername.Size = new System.Drawing.Size(379, 33);
            this.txbUsername.TabIndex = 1;
            this.txbUsername.Text = "Username";
            this.txbUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txbPassword
            // 
            this.txbPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbPassword.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txbPassword.ForeColor = System.Drawing.Color.Black;
            this.txbPassword.HintForeColor = System.Drawing.Color.Empty;
            this.txbPassword.HintText = "";
            this.txbPassword.isPassword = true;
            this.txbPassword.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(230)))), ((int)(((byte)(94)))));
            this.txbPassword.LineIdleColor = System.Drawing.Color.SeaGreen;
            this.txbPassword.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(230)))), ((int)(((byte)(94)))));
            this.txbPassword.LineThickness = 3;
            this.txbPassword.Location = new System.Drawing.Point(174, 216);
            this.txbPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.Size = new System.Drawing.Size(379, 33);
            this.txbPassword.TabIndex = 2;
            this.txbPassword.Text = "password";
            this.txbPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // cbbUserType
            // 
            this.cbbUserType.BackColor = System.Drawing.Color.Transparent;
            this.cbbUserType.BorderRadius = 3;
            this.cbbUserType.DisabledColor = System.Drawing.Color.Gray;
            this.cbbUserType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(230)))), ((int)(((byte)(94)))));
            this.cbbUserType.Items = new string[0];
            this.cbbUserType.Location = new System.Drawing.Point(174, 338);
            this.cbbUserType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbbUserType.Name = "cbbUserType";
            this.cbbUserType.NomalColor = System.Drawing.Color.SeaGreen;
            this.cbbUserType.onHoverColor = System.Drawing.Color.SeaGreen;
            this.cbbUserType.selectedIndex = -1;
            this.cbbUserType.Size = new System.Drawing.Size(379, 43);
            this.cbbUserType.TabIndex = 3;
            // 
            // btnLogin
            // 
            this.btnLogin.ActiveBorderThickness = 1;
            this.btnLogin.ActiveCornerRadius = 20;
            this.btnLogin.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnLogin.ActiveForecolor = System.Drawing.Color.White;
            this.btnLogin.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnLogin.BackColor = System.Drawing.SystemColors.Control;
            this.btnLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogin.BackgroundImage")));
            this.btnLogin.ButtonText = "Đăng nhập";
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnLogin.IdleBorderThickness = 1;
            this.btnLogin.IdleCornerRadius = 20;
            this.btnLogin.IdleFillColor = System.Drawing.Color.White;
            this.btnLogin.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnLogin.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnLogin.Location = new System.Drawing.Point(174, 445);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(5);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(181, 41);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRegister
            // 
            this.btnRegister.ActiveBorderThickness = 1;
            this.btnRegister.ActiveCornerRadius = 20;
            this.btnRegister.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnRegister.ActiveForecolor = System.Drawing.Color.White;
            this.btnRegister.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnRegister.BackColor = System.Drawing.SystemColors.Control;
            this.btnRegister.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRegister.BackgroundImage")));
            this.btnRegister.ButtonText = "Đăng ký";
            this.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegister.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnRegister.IdleBorderThickness = 1;
            this.btnRegister.IdleCornerRadius = 20;
            this.btnRegister.IdleFillColor = System.Drawing.Color.White;
            this.btnRegister.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnRegister.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnRegister.Location = new System.Drawing.Point(372, 445);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(5);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(181, 41);
            this.btnRegister.TabIndex = 7;
            this.btnRegister.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(171, 82);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(73, 17);
            this.bunifuCustomLabel1.TabIndex = 8;
            this.bunifuCustomLabel1.Text = "Username";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(171, 195);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(69, 17);
            this.bunifuCustomLabel2.TabIndex = 9;
            this.bunifuCustomLabel2.Text = "Password";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(171, 317);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(137, 17);
            this.bunifuCustomLabel3.TabIndex = 10;
            this.bunifuCustomLabel3.Text = "bunifuCustomLabel3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 645);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.cbbUserType);
            this.Controls.Add(this.txbPassword);
            this.Controls.Add(this.txbUsername);
            this.Name = "Form1";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuMaterialTextbox txbUsername;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txbPassword;
        private Bunifu.Framework.UI.BunifuDropdown cbbUserType;
        private Bunifu.Framework.UI.BunifuThinButton2 btnLogin;
        private Bunifu.Framework.UI.BunifuThinButton2 btnRegister;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
    }
}

