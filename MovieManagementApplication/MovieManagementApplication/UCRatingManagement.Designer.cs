namespace MovieManagementApplication
{
    partial class UCRatingManagement
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCRatingManagement));
            this.dataGridViewRating = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RatingScore = new Bunifu.Framework.UI.BunifuRating();
            this.label7 = new System.Windows.Forms.Label();
            this.txbActorId = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbNumberOfRating = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txbActorFirstName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomDataGrid2 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.btnAdd = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRating)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewRating
            // 
            this.dataGridViewRating.AllowUserToAddRows = false;
            this.dataGridViewRating.AllowUserToDeleteRows = false;
            this.dataGridViewRating.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRating.Location = new System.Drawing.Point(3, 215);
            this.dataGridViewRating.MultiSelect = false;
            this.dataGridViewRating.Name = "dataGridViewRating";
            this.dataGridViewRating.ReadOnly = true;
            this.dataGridViewRating.RowHeadersWidth = 51;
            this.dataGridViewRating.Size = new System.Drawing.Size(994, 282);
            this.dataGridViewRating.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RatingScore);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txbActorId);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txbNumberOfRating);
            this.groupBox1.Controls.Add(this.txbActorFirstName);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(732, 167);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin Rating";
            // 
            // RatingScore
            // 
            this.RatingScore.BackColor = System.Drawing.Color.Transparent;
            this.RatingScore.ForeColor = System.Drawing.Color.SeaGreen;
            this.RatingScore.Location = new System.Drawing.Point(7, 102);
            this.RatingScore.Name = "RatingScore";
            this.RatingScore.Size = new System.Drawing.Size(162, 30);
            this.RatingScore.TabIndex = 18;
            this.RatingScore.Value = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Id movie";
            // 
            // txbActorId
            // 
            this.txbActorId.BorderColorFocused = System.Drawing.Color.Blue;
            this.txbActorId.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbActorId.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txbActorId.BorderThickness = 3;
            this.txbActorId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbActorId.Enabled = false;
            this.txbActorId.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txbActorId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbActorId.isPassword = false;
            this.txbActorId.Location = new System.Drawing.Point(7, 40);
            this.txbActorId.Margin = new System.Windows.Forms.Padding(4);
            this.txbActorId.Name = "txbActorId";
            this.txbActorId.Size = new System.Drawing.Size(80, 44);
            this.txbActorId.TabIndex = 15;
            this.txbActorId.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Id reviwer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(315, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Số lần rate";
            // 
            // txbNumberOfRating
            // 
            this.txbNumberOfRating.BorderColorFocused = System.Drawing.Color.Blue;
            this.txbNumberOfRating.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbNumberOfRating.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txbNumberOfRating.BorderThickness = 3;
            this.txbNumberOfRating.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbNumberOfRating.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txbNumberOfRating.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbNumberOfRating.isPassword = false;
            this.txbNumberOfRating.Location = new System.Drawing.Point(309, 42);
            this.txbNumberOfRating.Margin = new System.Windows.Forms.Padding(4);
            this.txbNumberOfRating.Name = "txbNumberOfRating";
            this.txbNumberOfRating.Size = new System.Drawing.Size(180, 44);
            this.txbNumberOfRating.TabIndex = 8;
            this.txbNumberOfRating.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txbActorFirstName
            // 
            this.txbActorFirstName.BorderColorFocused = System.Drawing.Color.Blue;
            this.txbActorFirstName.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbActorFirstName.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txbActorFirstName.BorderThickness = 3;
            this.txbActorFirstName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbActorFirstName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txbActorFirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbActorFirstName.isPassword = false;
            this.txbActorFirstName.Location = new System.Drawing.Point(110, 40);
            this.txbActorFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.txbActorFirstName.Name = "txbActorFirstName";
            this.txbActorFirstName.Size = new System.Drawing.Size(180, 44);
            this.txbActorFirstName.TabIndex = 1;
            this.txbActorFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomDataGrid2
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuCustomDataGrid2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.bunifuCustomDataGrid2.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.bunifuCustomDataGrid2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomDataGrid2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.bunifuCustomDataGrid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bunifuCustomDataGrid2.DoubleBuffered = true;
            this.bunifuCustomDataGrid2.EnableHeadersVisualStyles = false;
            this.bunifuCustomDataGrid2.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomDataGrid2.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomDataGrid2.Location = new System.Drawing.Point(618, 105);
            this.bunifuCustomDataGrid2.Name = "bunifuCustomDataGrid2";
            this.bunifuCustomDataGrid2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bunifuCustomDataGrid2.RowHeadersWidth = 51;
            this.bunifuCustomDataGrid2.Size = new System.Drawing.Size(8, 8);
            this.bunifuCustomDataGrid2.TabIndex = 10;
            // 
            // btnAdd
            // 
            this.btnAdd.ActiveBorderThickness = 1;
            this.btnAdd.ActiveCornerRadius = 20;
            this.btnAdd.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnAdd.ActiveForecolor = System.Drawing.Color.White;
            this.btnAdd.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnAdd.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.BackgroundImage")));
            this.btnAdd.ButtonText = "Thêm";
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnAdd.IdleBorderThickness = 1;
            this.btnAdd.IdleCornerRadius = 20;
            this.btnAdd.IdleFillColor = System.Drawing.Color.White;
            this.btnAdd.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnAdd.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnAdd.Location = new System.Drawing.Point(743, 43);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(181, 41);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // UCRatingManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.dataGridViewRating);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bunifuCustomDataGrid2);
            this.Controls.Add(this.btnAdd);
            this.Name = "UCRatingManagement";
            this.Size = new System.Drawing.Size(1000, 500);
            this.Load += new System.EventHandler(this.UCRatingManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRating)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewRating;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuMetroTextbox txbActorId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMetroTextbox txbNumberOfRating;
        private Bunifu.Framework.UI.BunifuMetroTextbox txbActorFirstName;
        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid2;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAdd;
        private Bunifu.Framework.UI.BunifuRating RatingScore;
    }
}
