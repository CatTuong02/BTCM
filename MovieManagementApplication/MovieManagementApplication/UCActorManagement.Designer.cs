using System.Windows.Forms;

namespace MovieManagementApplication
{
    partial class UCActorManagement : UserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCActorManagement));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnAdd = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnEdit = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnDelete = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuCustomDataGrid2 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.dataGridViewActor = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbbActorGender = new Bunifu.Framework.UI.BunifuDropdown();
            this.label7 = new System.Windows.Forms.Label();
            this.txbActorId = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbActorLastName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txbActorFirstName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txbActorImage = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSelectActorImage = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewActor)).BeginInit();
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
            this.bunifuCustomDataGrid2.TabIndex = 4;
            // 
            // dataGridViewActor
            // 
            this.dataGridViewActor.AllowUserToAddRows = false;
            this.dataGridViewActor.AllowUserToDeleteRows = false;
            this.dataGridViewActor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewActor.Location = new System.Drawing.Point(3, 215);
            this.dataGridViewActor.MultiSelect = false;
            this.dataGridViewActor.Name = "dataGridViewActor";
            this.dataGridViewActor.ReadOnly = true;
            this.dataGridViewActor.RowHeadersWidth = 51;
            this.dataGridViewActor.Size = new System.Drawing.Size(994, 282);
            this.dataGridViewActor.TabIndex = 5;
            this.dataGridViewActor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMovie_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnSelectActorImage);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txbActorImage);
            this.groupBox1.Controls.Add(this.cbbActorGender);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txbActorId);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txbActorLastName);
            this.groupBox1.Controls.Add(this.txbActorFirstName);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(732, 167);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin Actor";
            // 
            // cbbActorGender
            // 
            this.cbbActorGender.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.cbbActorGender.BackColor = System.Drawing.Color.Transparent;
            this.cbbActorGender.BorderRadius = 3;
            this.cbbActorGender.DisabledColor = System.Drawing.Color.Gray;
            this.cbbActorGender.ForeColor = System.Drawing.Color.White;
            this.cbbActorGender.Items = new string[] {
        "M",
        "F"};
            this.cbbActorGender.Location = new System.Drawing.Point(522, 49);
            this.cbbActorGender.Name = "cbbActorGender";
            this.cbbActorGender.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.cbbActorGender.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.cbbActorGender.selectedIndex = -1;
            this.cbbActorGender.Size = new System.Drawing.Size(76, 35);
            this.cbbActorGender.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Id actor";
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
            this.txbActorId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbActorId.Name = "txbActorId";
            this.txbActorId.Size = new System.Drawing.Size(95, 44);
            this.txbActorId.TabIndex = 15;
            this.txbActorId.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(520, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Giới tính";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "First name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(315, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Last name";
            // 
            // txbActorLastName
            // 
            this.txbActorLastName.BorderColorFocused = System.Drawing.Color.Blue;
            this.txbActorLastName.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbActorLastName.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txbActorLastName.BorderThickness = 3;
            this.txbActorLastName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbActorLastName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txbActorLastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbActorLastName.isPassword = false;
            this.txbActorLastName.Location = new System.Drawing.Point(309, 42);
            this.txbActorLastName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbActorLastName.Name = "txbActorLastName";
            this.txbActorLastName.Size = new System.Drawing.Size(180, 44);
            this.txbActorLastName.TabIndex = 8;
            this.txbActorLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.txbActorFirstName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbActorFirstName.Name = "txbActorFirstName";
            this.txbActorFirstName.Size = new System.Drawing.Size(180, 44);
            this.txbActorFirstName.TabIndex = 1;
            this.txbActorFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txbActorImage
            // 
            this.txbActorImage.BorderColorFocused = System.Drawing.Color.Blue;
            this.txbActorImage.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbActorImage.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txbActorImage.BorderThickness = 3;
            this.txbActorImage.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbActorImage.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txbActorImage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbActorImage.isPassword = false;
            this.txbActorImage.Location = new System.Drawing.Point(7, 123);
            this.txbActorImage.Margin = new System.Windows.Forms.Padding(4);
            this.txbActorImage.Name = "txbActorImage";
            this.txbActorImage.Size = new System.Drawing.Size(283, 44);
            this.txbActorImage.TabIndex = 18;
            this.txbActorImage.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Ảnh";
            // 
            // btnSelectActorImage
            // 
            this.btnSelectActorImage.ActiveBorderThickness = 1;
            this.btnSelectActorImage.ActiveCornerRadius = 20;
            this.btnSelectActorImage.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnSelectActorImage.ActiveForecolor = System.Drawing.Color.White;
            this.btnSelectActorImage.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnSelectActorImage.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnSelectActorImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSelectActorImage.BackgroundImage")));
            this.btnSelectActorImage.ButtonText = "Chọn ảnh";
            this.btnSelectActorImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelectActorImage.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectActorImage.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnSelectActorImage.IdleBorderThickness = 1;
            this.btnSelectActorImage.IdleCornerRadius = 5;
            this.btnSelectActorImage.IdleFillColor = System.Drawing.Color.White;
            this.btnSelectActorImage.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnSelectActorImage.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnSelectActorImage.Location = new System.Drawing.Point(308, 123);
            this.btnSelectActorImage.Margin = new System.Windows.Forms.Padding(5);
            this.btnSelectActorImage.Name = "btnSelectActorImage";
            this.btnSelectActorImage.Size = new System.Drawing.Size(91, 41);
            this.btnSelectActorImage.TabIndex = 7;
            this.btnSelectActorImage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSelectActorImage.Click += new System.EventHandler(this.btnSelectActorImage_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(353, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Ảnh";
            // 
            // UCActorManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.dataGridViewActor);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bunifuCustomDataGrid2);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Name = "UCActorManagement";
            this.Size = new System.Drawing.Size(1000, 500);
            this.Load += new System.EventHandler(this.UCActorManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewActor)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuThinButton2 btnAdd;
        private Bunifu.Framework.UI.BunifuThinButton2 btnEdit;
        private Bunifu.Framework.UI.BunifuThinButton2 btnDelete;
        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid2;
        private System.Windows.Forms.DataGridView dataGridViewActor;
        private System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.Framework.UI.BunifuMetroTextbox txbActorFirstName;
        private Bunifu.Framework.UI.BunifuMetroTextbox txbActorLastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuMetroTextbox txbActorId;
        private Bunifu.Framework.UI.BunifuDropdown cbbActorGender;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSelectActorImage;
        private Label label4;
        private Bunifu.Framework.UI.BunifuMetroTextbox txbActorImage;
        private Label label5;
    }
}
