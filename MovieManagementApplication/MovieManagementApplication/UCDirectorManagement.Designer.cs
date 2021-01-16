﻿
namespace MovieManagementApplication
{
    partial class UCDirectorManagement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCDirectorManagement));
            this.label7 = new System.Windows.Forms.Label();
            this.txbDirectorId = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbDirectorLastName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txbDirectorFirstName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.dataGridViewDirector = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bunifuCustomDataGrid2 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.btnDelete = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnEdit = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnAdd = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDirector)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid2)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 28);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Id director";
            // 
            // txbDirectorId
            // 
            this.txbDirectorId.BorderColorFocused = System.Drawing.Color.Blue;
            this.txbDirectorId.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbDirectorId.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txbDirectorId.BorderThickness = 3;
            this.txbDirectorId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbDirectorId.Enabled = false;
            this.txbDirectorId.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txbDirectorId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbDirectorId.isPassword = false;
            this.txbDirectorId.Location = new System.Drawing.Point(9, 49);
            this.txbDirectorId.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txbDirectorId.Name = "txbDirectorId";
            this.txbDirectorId.Size = new System.Drawing.Size(107, 54);
            this.txbDirectorId.TabIndex = 15;
            this.txbDirectorId.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "First name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(420, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Last name";
            // 
            // txbDirectorLastName
            // 
            this.txbDirectorLastName.BorderColorFocused = System.Drawing.Color.Blue;
            this.txbDirectorLastName.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbDirectorLastName.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txbDirectorLastName.BorderThickness = 3;
            this.txbDirectorLastName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbDirectorLastName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txbDirectorLastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbDirectorLastName.isPassword = false;
            this.txbDirectorLastName.Location = new System.Drawing.Point(412, 52);
            this.txbDirectorLastName.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txbDirectorLastName.Name = "txbDirectorLastName";
            this.txbDirectorLastName.Size = new System.Drawing.Size(240, 54);
            this.txbDirectorLastName.TabIndex = 8;
            this.txbDirectorLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txbDirectorFirstName
            // 
            this.txbDirectorFirstName.BorderColorFocused = System.Drawing.Color.Blue;
            this.txbDirectorFirstName.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbDirectorFirstName.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txbDirectorFirstName.BorderThickness = 3;
            this.txbDirectorFirstName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbDirectorFirstName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txbDirectorFirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbDirectorFirstName.isPassword = false;
            this.txbDirectorFirstName.Location = new System.Drawing.Point(147, 49);
            this.txbDirectorFirstName.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txbDirectorFirstName.Name = "txbDirectorFirstName";
            this.txbDirectorFirstName.Size = new System.Drawing.Size(240, 54);
            this.txbDirectorFirstName.TabIndex = 1;
            this.txbDirectorFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // dataGridViewDirector
            // 
            this.dataGridViewDirector.AllowUserToAddRows = false;
            this.dataGridViewDirector.AllowUserToDeleteRows = false;
            this.dataGridViewDirector.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDirector.Location = new System.Drawing.Point(4, 265);
            this.dataGridViewDirector.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewDirector.MultiSelect = false;
            this.dataGridViewDirector.Name = "dataGridViewDirector";
            this.dataGridViewDirector.ReadOnly = true;
            this.dataGridViewDirector.RowHeadersWidth = 51;
            this.dataGridViewDirector.Size = new System.Drawing.Size(1325, 347);
            this.dataGridViewDirector.TabIndex = 11;
            this.dataGridViewDirector.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDirector_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txbDirectorId);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txbDirectorLastName);
            this.groupBox1.Controls.Add(this.txbDirectorFirstName);
            this.groupBox1.Location = new System.Drawing.Point(4, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(976, 206);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin Director";
            // 
            // bunifuCustomDataGrid2
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuCustomDataGrid2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.bunifuCustomDataGrid2.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.bunifuCustomDataGrid2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomDataGrid2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.bunifuCustomDataGrid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bunifuCustomDataGrid2.DoubleBuffered = true;
            this.bunifuCustomDataGrid2.EnableHeadersVisualStyles = false;
            this.bunifuCustomDataGrid2.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomDataGrid2.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomDataGrid2.Location = new System.Drawing.Point(824, 129);
            this.bunifuCustomDataGrid2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuCustomDataGrid2.Name = "bunifuCustomDataGrid2";
            this.bunifuCustomDataGrid2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bunifuCustomDataGrid2.RowHeadersWidth = 51;
            this.bunifuCustomDataGrid2.Size = new System.Drawing.Size(11, 10);
            this.bunifuCustomDataGrid2.TabIndex = 10;
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
            this.btnDelete.Location = new System.Drawing.Point(991, 178);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(241, 50);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
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
            this.btnEdit.Location = new System.Drawing.Point(991, 116);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(241, 50);
            this.btnEdit.TabIndex = 8;
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
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
            this.btnAdd.Location = new System.Drawing.Point(991, 53);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(241, 50);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // UCDirectorManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.dataGridViewDirector);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bunifuCustomDataGrid2);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UCDirectorManagement";
            this.Size = new System.Drawing.Size(1333, 615);
            this.Load += new System.EventHandler(this.UCDirectorManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDirector)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuMetroTextbox txbDirectorId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMetroTextbox txbDirectorLastName;
        private Bunifu.Framework.UI.BunifuMetroTextbox txbDirectorFirstName;
        private System.Windows.Forms.DataGridView dataGridViewDirector;
        private System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid2;
        private Bunifu.Framework.UI.BunifuThinButton2 btnDelete;
        private Bunifu.Framework.UI.BunifuThinButton2 btnEdit;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAdd;
    }
}
