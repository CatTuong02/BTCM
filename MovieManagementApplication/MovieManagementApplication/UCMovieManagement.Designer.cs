namespace MovieManagementApplication
{
    partial class UCMovieManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCMovieManagement));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnAdd = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnEdit = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnDelete = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuCustomDataGrid2 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.dataGridViewMovie = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txbMovieId = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbMovieYear = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.dpMovieReleaseDate = new Bunifu.Framework.UI.BunifuDatepicker();
            this.txbMovieTime = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txbMovieLanguage = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txbMovieReleaseCountry = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txbMovieTitle = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btnSelectMovieImage = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label8 = new System.Windows.Forms.Label();
            this.txbMovieImage = new Bunifu.Framework.UI.BunifuMetroTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMovie)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            this.btnAdd.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(181, 41);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.ActiveBorderThickness = 1;
            this.btnEdit.ActiveCornerRadius = 20;
            this.btnEdit.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnEdit.ActiveForecolor = System.Drawing.Color.White;
            this.btnEdit.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnEdit.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnEdit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEdit.BackgroundImage")));
            this.btnEdit.ButtonText = "Sửa";
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnEdit.IdleBorderThickness = 1;
            this.btnEdit.IdleCornerRadius = 20;
            this.btnEdit.IdleFillColor = System.Drawing.Color.White;
            this.btnEdit.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnEdit.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnEdit.Location = new System.Drawing.Point(743, 94);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(181, 41);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.ActiveBorderThickness = 1;
            this.btnDelete.ActiveCornerRadius = 20;
            this.btnDelete.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnDelete.ActiveForecolor = System.Drawing.Color.White;
            this.btnDelete.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnDelete.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.BackgroundImage")));
            this.btnDelete.ButtonText = "Xoá";
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnDelete.IdleBorderThickness = 1;
            this.btnDelete.IdleCornerRadius = 20;
            this.btnDelete.IdleFillColor = System.Drawing.Color.White;
            this.btnDelete.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnDelete.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnDelete.Location = new System.Drawing.Point(743, 145);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(181, 41);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // bunifuCustomDataGrid2
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuCustomDataGrid2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bunifuCustomDataGrid2.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.bunifuCustomDataGrid2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomDataGrid2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
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
            this.bunifuCustomDataGrid2.TabIndex = 4;
            // 
            // dataGridViewMovie
            // 
            this.dataGridViewMovie.AllowUserToAddRows = false;
            this.dataGridViewMovie.AllowUserToDeleteRows = false;
            this.dataGridViewMovie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMovie.Location = new System.Drawing.Point(3, 215);
            this.dataGridViewMovie.MultiSelect = false;
            this.dataGridViewMovie.Name = "dataGridViewMovie";
            this.dataGridViewMovie.ReadOnly = true;
            this.dataGridViewMovie.RowHeadersWidth = 51;
            this.dataGridViewMovie.Size = new System.Drawing.Size(994, 282);
            this.dataGridViewMovie.TabIndex = 5;
            this.dataGridViewMovie.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMovie_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txbMovieId);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txbMovieYear);
            this.groupBox1.Controls.Add(this.dpMovieReleaseDate);
            this.groupBox1.Controls.Add(this.txbMovieTime);
            this.groupBox1.Controls.Add(this.txbMovieLanguage);
            this.groupBox1.Controls.Add(this.txbMovieReleaseCountry);
            this.groupBox1.Controls.Add(this.txbMovieTitle);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(732, 206);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin Movie";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Id phim";
            // 
            // txbMovieId
            // 
            this.txbMovieId.BorderColorFocused = System.Drawing.Color.Blue;
            this.txbMovieId.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbMovieId.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txbMovieId.BorderThickness = 3;
            this.txbMovieId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbMovieId.Enabled = false;
            this.txbMovieId.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txbMovieId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbMovieId.isPassword = false;
            this.txbMovieId.Location = new System.Drawing.Point(7, 40);
            this.txbMovieId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbMovieId.Name = "txbMovieId";
            this.txbMovieId.Size = new System.Drawing.Size(80, 44);
            this.txbMovieId.TabIndex = 15;
            this.txbMovieId.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(109, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Ngày phát hành";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(315, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Nơi phát hành";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(520, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Ngôn ngữ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(520, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Thời lượng phim";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tên phim";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(315, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Năm phát hành";
            // 
            // txbMovieYear
            // 
            this.txbMovieYear.BorderColorFocused = System.Drawing.Color.Blue;
            this.txbMovieYear.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbMovieYear.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txbMovieYear.BorderThickness = 3;
            this.txbMovieYear.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbMovieYear.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txbMovieYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbMovieYear.isPassword = false;
            this.txbMovieYear.Location = new System.Drawing.Point(309, 42);
            this.txbMovieYear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbMovieYear.Name = "txbMovieYear";
            this.txbMovieYear.Size = new System.Drawing.Size(180, 44);
            this.txbMovieYear.TabIndex = 8;
            this.txbMovieYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // dpMovieReleaseDate
            // 
            this.dpMovieReleaseDate.BackColor = System.Drawing.Color.SeaGreen;
            this.dpMovieReleaseDate.BorderRadius = 0;
            this.dpMovieReleaseDate.ForeColor = System.Drawing.Color.White;
            this.dpMovieReleaseDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpMovieReleaseDate.FormatCustom = "dd-MM-yyyy";
            this.dpMovieReleaseDate.Location = new System.Drawing.Point(109, 114);
            this.dpMovieReleaseDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dpMovieReleaseDate.Name = "dpMovieReleaseDate";
            this.dpMovieReleaseDate.Size = new System.Drawing.Size(180, 36);
            this.dpMovieReleaseDate.TabIndex = 7;
            this.dpMovieReleaseDate.Value = new System.DateTime(2021, 1, 14, 0, 9, 26, 781);
            // 
            // txbMovieTime
            // 
            this.txbMovieTime.BorderColorFocused = System.Drawing.Color.Blue;
            this.txbMovieTime.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbMovieTime.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txbMovieTime.BorderThickness = 3;
            this.txbMovieTime.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbMovieTime.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txbMovieTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbMovieTime.isPassword = false;
            this.txbMovieTime.Location = new System.Drawing.Point(512, 42);
            this.txbMovieTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbMovieTime.Name = "txbMovieTime";
            this.txbMovieTime.Size = new System.Drawing.Size(180, 44);
            this.txbMovieTime.TabIndex = 4;
            this.txbMovieTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txbMovieLanguage
            // 
            this.txbMovieLanguage.BorderColorFocused = System.Drawing.Color.Blue;
            this.txbMovieLanguage.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbMovieLanguage.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txbMovieLanguage.BorderThickness = 3;
            this.txbMovieLanguage.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbMovieLanguage.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txbMovieLanguage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbMovieLanguage.isPassword = false;
            this.txbMovieLanguage.Location = new System.Drawing.Point(512, 106);
            this.txbMovieLanguage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbMovieLanguage.Name = "txbMovieLanguage";
            this.txbMovieLanguage.Size = new System.Drawing.Size(180, 44);
            this.txbMovieLanguage.TabIndex = 3;
            this.txbMovieLanguage.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txbMovieReleaseCountry
            // 
            this.txbMovieReleaseCountry.BorderColorFocused = System.Drawing.Color.Blue;
            this.txbMovieReleaseCountry.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbMovieReleaseCountry.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txbMovieReleaseCountry.BorderThickness = 3;
            this.txbMovieReleaseCountry.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbMovieReleaseCountry.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txbMovieReleaseCountry.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbMovieReleaseCountry.isPassword = false;
            this.txbMovieReleaseCountry.Location = new System.Drawing.Point(309, 106);
            this.txbMovieReleaseCountry.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbMovieReleaseCountry.Name = "txbMovieReleaseCountry";
            this.txbMovieReleaseCountry.Size = new System.Drawing.Size(180, 44);
            this.txbMovieReleaseCountry.TabIndex = 2;
            this.txbMovieReleaseCountry.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txbMovieTitle
            // 
            this.txbMovieTitle.BorderColorFocused = System.Drawing.Color.Blue;
            this.txbMovieTitle.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbMovieTitle.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txbMovieTitle.BorderThickness = 3;
            this.txbMovieTitle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbMovieTitle.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txbMovieTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbMovieTitle.isPassword = false;
            this.txbMovieTitle.Location = new System.Drawing.Point(110, 40);
            this.txbMovieTitle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbMovieTitle.Name = "txbMovieTitle";
            this.txbMovieTitle.Size = new System.Drawing.Size(180, 44);
            this.txbMovieTitle.TabIndex = 1;
            this.txbMovieTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnSelectMovieImage
            // 
            this.btnSelectMovieImage.ActiveBorderThickness = 1;
            this.btnSelectMovieImage.ActiveCornerRadius = 20;
            this.btnSelectMovieImage.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnSelectMovieImage.ActiveForecolor = System.Drawing.Color.White;
            this.btnSelectMovieImage.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnSelectMovieImage.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnSelectMovieImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSelectMovieImage.BackgroundImage")));
            this.btnSelectMovieImage.ButtonText = "Chọn ảnh";
            this.btnSelectMovieImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelectMovieImage.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectMovieImage.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnSelectMovieImage.IdleBorderThickness = 1;
            this.btnSelectMovieImage.IdleCornerRadius = 5;
            this.btnSelectMovieImage.IdleFillColor = System.Drawing.Color.White;
            this.btnSelectMovieImage.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnSelectMovieImage.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnSelectMovieImage.Location = new System.Drawing.Point(311, 162);
            this.btnSelectMovieImage.Margin = new System.Windows.Forms.Padding(5);
            this.btnSelectMovieImage.Name = "btnSelectMovieImage";
            this.btnSelectMovieImage.Size = new System.Drawing.Size(91, 41);
            this.btnSelectMovieImage.TabIndex = 20;
            this.btnSelectMovieImage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSelectMovieImage.Click += new System.EventHandler(this.btnSelectMovieImage_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 145);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Ảnh";
            // 
            // txbMovieImage
            // 
            this.txbMovieImage.BorderColorFocused = System.Drawing.Color.Blue;
            this.txbMovieImage.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbMovieImage.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txbMovieImage.BorderThickness = 3;
            this.txbMovieImage.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbMovieImage.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txbMovieImage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbMovieImage.isPassword = false;
            this.txbMovieImage.Location = new System.Drawing.Point(10, 162);
            this.txbMovieImage.Margin = new System.Windows.Forms.Padding(4);
            this.txbMovieImage.Name = "txbMovieImage";
            this.txbMovieImage.Size = new System.Drawing.Size(283, 44);
            this.txbMovieImage.TabIndex = 21;
            this.txbMovieImage.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // UCMovieManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.btnSelectMovieImage);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txbMovieImage);
            this.Controls.Add(this.dataGridViewMovie);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bunifuCustomDataGrid2);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Name = "UCMovieManagement";
            this.Size = new System.Drawing.Size(1000, 500);
            this.Load += new System.EventHandler(this.UCMovieManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMovie)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuThinButton2 btnAdd;
        private Bunifu.Framework.UI.BunifuThinButton2 btnEdit;
        private Bunifu.Framework.UI.BunifuThinButton2 btnDelete;
        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid2;
        private System.Windows.Forms.DataGridView dataGridViewMovie;
        private System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.Framework.UI.BunifuDatepicker dpMovieReleaseDate;
        private Bunifu.Framework.UI.BunifuMetroTextbox txbMovieTime;
        private Bunifu.Framework.UI.BunifuMetroTextbox txbMovieLanguage;
        private Bunifu.Framework.UI.BunifuMetroTextbox txbMovieReleaseCountry;
        private Bunifu.Framework.UI.BunifuMetroTextbox txbMovieTitle;
        private Bunifu.Framework.UI.BunifuMetroTextbox txbMovieYear;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuMetroTextbox txbMovieId;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSelectMovieImage;
        private System.Windows.Forms.Label label8;
        private Bunifu.Framework.UI.BunifuMetroTextbox txbMovieImage;
    }
}
