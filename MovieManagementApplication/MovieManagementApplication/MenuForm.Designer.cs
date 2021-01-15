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
            this.ucActorManagement1 = new MovieManagementApplication.UCActorManagement();
            this.tabPageDirector = new System.Windows.Forms.TabPage();
            this.tabPageMenuRating = new System.Windows.Forms.TabPage();
            this.tabPageMenuMovie = new System.Windows.Forms.TabPage();
            this.ucMovieManagement1 = new MovieManagementApplication.UCMovieManagement();
            this.labelUserName = new Bunifu.Framework.UI.BunifuCustomLabel();
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
            this.tabControlMenu.Location = new System.Drawing.Point(12, 61);
            this.tabControlMenu.Name = "tabControlMenu";
            this.tabControlMenu.SelectedIndex = 0;
            this.tabControlMenu.Size = new System.Drawing.Size(1020, 560);
            this.tabControlMenu.TabIndex = 0;
            // 
            // tabPageMenuActor
            // 
            this.tabPageMenuActor.Controls.Add(this.ucActorManagement1);
            this.tabPageMenuActor.Location = new System.Drawing.Point(4, 22);
            this.tabPageMenuActor.Name = "tabPageMenuActor";
            this.tabPageMenuActor.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMenuActor.Size = new System.Drawing.Size(1012, 534);
            this.tabPageMenuActor.TabIndex = 1;
            this.tabPageMenuActor.Text = "Quản lý Actor";
            this.tabPageMenuActor.UseVisualStyleBackColor = true;
            // 
            // ucActorManagement1
            // 
            this.ucActorManagement1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ucActorManagement1.Location = new System.Drawing.Point(8, 6);
            this.ucActorManagement1.Name = "ucActorManagement1";
            this.ucActorManagement1.Size = new System.Drawing.Size(1000, 500);
            this.ucActorManagement1.TabIndex = 0;
            // 
            // tabPageDirector
            // 
            this.tabPageDirector.Location = new System.Drawing.Point(4, 22);
            this.tabPageDirector.Name = "tabPageDirector";
            this.tabPageDirector.Size = new System.Drawing.Size(1012, 534);
            this.tabPageDirector.TabIndex = 2;
            this.tabPageDirector.Text = "Quản lý Director";
            this.tabPageDirector.UseVisualStyleBackColor = true;
            // 
            // tabPageMenuRating
            // 
            this.tabPageMenuRating.Location = new System.Drawing.Point(4, 22);
            this.tabPageMenuRating.Name = "tabPageMenuRating";
            this.tabPageMenuRating.Size = new System.Drawing.Size(1012, 534);
            this.tabPageMenuRating.TabIndex = 3;
            this.tabPageMenuRating.Text = "Quản lý Rating";
            this.tabPageMenuRating.UseVisualStyleBackColor = true;
            // 
            // tabPageMenuMovie
            // 
            this.tabPageMenuMovie.Controls.Add(this.ucMovieManagement1);
            this.tabPageMenuMovie.Location = new System.Drawing.Point(4, 22);
            this.tabPageMenuMovie.Name = "tabPageMenuMovie";
            this.tabPageMenuMovie.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMenuMovie.Size = new System.Drawing.Size(1012, 534);
            this.tabPageMenuMovie.TabIndex = 0;
            this.tabPageMenuMovie.Text = "Quản lý Movie";
            this.tabPageMenuMovie.UseVisualStyleBackColor = true;
            // 
            // ucMovieManagement1
            // 
            this.ucMovieManagement1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ucMovieManagement1.Location = new System.Drawing.Point(6, 6);
            this.ucMovieManagement1.Name = "ucMovieManagement1";
            this.ucMovieManagement1.Size = new System.Drawing.Size(1000, 500);
            this.ucMovieManagement1.TabIndex = 0;
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Location = new System.Drawing.Point(806, 28);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(103, 13);
            this.labelUserName.TabIndex = 1;
            this.labelUserName.Text = "bunifuCustomLabel1";
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 633);
            this.Controls.Add(this.labelUserName);
            this.Controls.Add(this.tabControlMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MenuForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MenuForm_FormClosing);
            this.Load += new System.EventHandler(this.MenuForm_Load);
            this.tabControlMenu.ResumeLayout(false);
            this.tabPageMenuActor.ResumeLayout(false);
            this.tabPageMenuMovie.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMenu;
        private System.Windows.Forms.TabPage tabPageDirector;
        private System.Windows.Forms.TabPage tabPageMenuRating;
        private Bunifu.Framework.UI.BunifuCustomLabel labelUserName;
        private System.Windows.Forms.TabPage tabPageMenuActor;
        private UCActorManagement ucActorManagement1;
        private System.Windows.Forms.TabPage tabPageMenuMovie;
        private UCMovieManagement ucMovieManagement1;
    }
}