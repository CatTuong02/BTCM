namespace MovieManagementApplication
{
    partial class MenuForm
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
            this.tabControlMenu = new System.Windows.Forms.TabControl();
            this.tabPageMenuActor = new System.Windows.Forms.TabPage();
            this.tabPageDirector = new System.Windows.Forms.TabPage();
            this.tabPageMenuRating = new System.Windows.Forms.TabPage();
            this.tabPageMenuMovie = new System.Windows.Forms.TabPage();
            this.labelUserName = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.button2 = new System.Windows.Forms.Button();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.ucActorManagement1 = new MovieManagementApplication.UCActorManagement();
            this.ucMovieManagement1 = new MovieManagementApplication.UCMovieManagement();
            this.tabControlMenu.SuspendLayout();
            this.tabPageMenuActor.SuspendLayout();
            this.tabPageMenuMovie.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMenu
            // 
            this.tabControlMenu.Controls.Add(this.tabPageMenuActor);
            this.tabControlMenu.Controls.Add(this.tabPageDirector);
            this.tabControlMenu.Controls.Add(this.tabPageMenuRating);
            this.tabControlMenu.Controls.Add(this.tabPageMenuMovie);
            this.tabControlMenu.Location = new System.Drawing.Point(16, 75);
            this.tabControlMenu.Margin = new System.Windows.Forms.Padding(4);
            this.tabControlMenu.Name = "tabControlMenu";
            this.tabControlMenu.SelectedIndex = 0;
            this.tabControlMenu.Size = new System.Drawing.Size(1360, 689);
            this.tabControlMenu.TabIndex = 0;
            // 
            // tabPageMenuActor
            // 
            this.tabPageMenuActor.Controls.Add(this.ucActorManagement1);
            this.tabPageMenuActor.Location = new System.Drawing.Point(4, 25);
            this.tabPageMenuActor.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageMenuActor.Name = "tabPageMenuActor";
            this.tabPageMenuActor.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageMenuActor.Size = new System.Drawing.Size(1352, 660);
            this.tabPageMenuActor.TabIndex = 1;
            this.tabPageMenuActor.Text = "Quản lý Actor";
            this.tabPageMenuActor.UseVisualStyleBackColor = true;
            // 
            // tabPageDirector
            // 
            this.tabPageDirector.Location = new System.Drawing.Point(4, 25);
            this.tabPageDirector.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageDirector.Name = "tabPageDirector";
            this.tabPageDirector.Size = new System.Drawing.Size(1352, 660);
            this.tabPageDirector.TabIndex = 2;
            this.tabPageDirector.Text = "Quản lý Director";
            this.tabPageDirector.UseVisualStyleBackColor = true;
            // 
            // tabPageMenuRating
            // 
            this.tabPageMenuRating.Location = new System.Drawing.Point(4, 25);
            this.tabPageMenuRating.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageMenuRating.Name = "tabPageMenuRating";
            this.tabPageMenuRating.Size = new System.Drawing.Size(1352, 660);
            this.tabPageMenuRating.TabIndex = 3;
            this.tabPageMenuRating.Text = "Quản lý Rating";
            this.tabPageMenuRating.UseVisualStyleBackColor = true;
            // 
            // tabPageMenuMovie
            // 
            this.tabPageMenuMovie.Controls.Add(this.ucMovieManagement1);
            this.tabPageMenuMovie.Location = new System.Drawing.Point(4, 25);
            this.tabPageMenuMovie.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageMenuMovie.Name = "tabPageMenuMovie";
            this.tabPageMenuMovie.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageMenuMovie.Size = new System.Drawing.Size(1352, 660);
            this.tabPageMenuMovie.TabIndex = 0;
            this.tabPageMenuMovie.Text = "Quản lý Movie";
            this.tabPageMenuMovie.UseVisualStyleBackColor = true;
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Location = new System.Drawing.Point(1075, 34);
            this.labelUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(137, 17);
            this.labelUserName.TabIndex = 1;
            this.labelUserName.Text = "bunifuCustomLabel1";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1346, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(37, 28);
            this.button2.TabIndex = 15;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(13, 8);
            this.bunifuCustomLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(54, 21);
            this.bunifuCustomLabel1.TabIndex = 16;
            this.bunifuCustomLabel1.Text = "Menu";
            // 
            // ucActorManagement1
            // 
            this.ucActorManagement1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ucActorManagement1.Location = new System.Drawing.Point(11, 8);
            this.ucActorManagement1.Margin = new System.Windows.Forms.Padding(4);
            this.ucActorManagement1.Name = "ucActorManagement1";
            this.ucActorManagement1.Size = new System.Drawing.Size(1333, 615);
            this.ucActorManagement1.TabIndex = 0;
            // 
            // ucMovieManagement1
            // 
            this.ucMovieManagement1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ucMovieManagement1.Location = new System.Drawing.Point(8, 8);
            this.ucMovieManagement1.Margin = new System.Windows.Forms.Padding(4);
            this.ucMovieManagement1.Name = "ucMovieManagement1";
            this.ucMovieManagement1.Size = new System.Drawing.Size(1333, 615);
            this.ucMovieManagement1.TabIndex = 0;
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1385, 779);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.labelUserName);
            this.Controls.Add(this.tabControlMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MenuForm";
            this.Load += new System.EventHandler(this.MenuForm_Load);
            this.tabControlMenu.ResumeLayout(false);
            this.tabPageMenuActor.ResumeLayout(false);
            this.tabPageMenuMovie.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMenu;
        private System.Windows.Forms.TabPage tabPageMenuMovie;
        private System.Windows.Forms.TabPage tabPageMenuActor;
        private System.Windows.Forms.TabPage tabPageDirector;
        private System.Windows.Forms.TabPage tabPageMenuRating;
        private Bunifu.Framework.UI.BunifuCustomLabel labelUserName;
        private System.Windows.Forms.Button button2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private UCActorManagement ucActorManagement1;
        private UCMovieManagement ucMovieManagement1;
    }
}