﻿namespace ThucTapNhom_B1
{
    partial class frmNV_DA
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
            this.btOk = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btCancel = new System.Windows.Forms.Button();
            this.btHienThi = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.mada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btThem = new System.Windows.Forms.Button();
            this.btTiemKiem = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.dtgvNVDA = new System.Windows.Forms.DataGridView();
            this.grbChucNang = new System.Windows.Forms.GroupBox();
            this.btSua = new System.Windows.Forms.Button();
            this.cbTenNV = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btThoat = new System.Windows.Forms.Button();
            this.txtMaDA = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.cbTenDA = new System.Windows.Forms.ComboBox();
            this.grbDeAn = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvNVDA)).BeginInit();
            this.grbChucNang.SuspendLayout();
            this.grbDeAn.SuspendLayout();
            this.SuspendLayout();
            // 
            // btOk
            // 
            this.btOk.Location = new System.Drawing.Point(3, 13);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(75, 23);
            this.btOk.TabIndex = 13;
            this.btOk.Text = "Ok";
            this.btOk.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btCancel);
            this.panel1.Controls.Add(this.btOk);
            this.panel1.Location = new System.Drawing.Point(544, 263);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(84, 100);
            this.panel1.TabIndex = 22;
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(3, 52);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 13;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            // 
            // btHienThi
            // 
            this.btHienThi.Enabled = false;
            this.btHienThi.Location = new System.Drawing.Point(544, 230);
            this.btHienThi.Name = "btHienThi";
            this.btHienThi.Size = new System.Drawing.Size(95, 23);
            this.btHienThi.TabIndex = 21;
            this.btHienThi.Text = "Hiện thị thông tin";
            this.btHienThi.UseVisualStyleBackColor = true;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(351, 201);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(207, 20);
            this.txtTimKiem.TabIndex = 17;
            // 
            // mada
            // 
            this.mada.DataPropertyName = "mada";
            this.mada.HeaderText = "Mã đề án";
            this.mada.Name = "mada";
            // 
            // tenda
            // 
            this.tenda.DataPropertyName = "tenda";
            this.tenda.HeaderText = "Đề án";
            this.tenda.Name = "tenda";
            // 
            // manv
            // 
            this.manv.DataPropertyName = "manv";
            this.manv.HeaderText = "Mã nhân viên";
            this.manv.Name = "manv";
            // 
            // ten
            // 
            this.ten.DataPropertyName = "ten";
            this.ten.HeaderText = "Nhân viên";
            this.ten.Name = "ten";
            this.ten.Width = 120;
            // 
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(38, 24);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(75, 23);
            this.btThem.TabIndex = 0;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            // 
            // btTiemKiem
            // 
            this.btTiemKiem.Location = new System.Drawing.Point(564, 201);
            this.btTiemKiem.Name = "btTiemKiem";
            this.btTiemKiem.Size = new System.Drawing.Size(75, 23);
            this.btTiemKiem.TabIndex = 15;
            this.btTiemKiem.Text = "Tìm kiếm";
            this.btTiemKiem.UseVisualStyleBackColor = true;
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(38, 99);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(75, 23);
            this.btXoa.TabIndex = 0;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            // 
            // dtgvNVDA
            // 
            this.dtgvNVDA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvNVDA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ten,
            this.manv,
            this.tenda,
            this.mada});
            this.dtgvNVDA.Location = new System.Drawing.Point(102, 230);
            this.dtgvNVDA.Name = "dtgvNVDA";
            this.dtgvNVDA.RowHeadersVisible = false;
            this.dtgvNVDA.Size = new System.Drawing.Size(424, 168);
            this.dtgvNVDA.TabIndex = 20;
            // 
            // grbChucNang
            // 
            this.grbChucNang.Controls.Add(this.btXoa);
            this.grbChucNang.Controls.Add(this.btSua);
            this.grbChucNang.Controls.Add(this.btThem);
            this.grbChucNang.Location = new System.Drawing.Point(506, 23);
            this.grbChucNang.Name = "grbChucNang";
            this.grbChucNang.Size = new System.Drawing.Size(133, 144);
            this.grbChucNang.TabIndex = 19;
            this.grbChucNang.TabStop = false;
            this.grbChucNang.Text = "Chức năng";
            // 
            // btSua
            // 
            this.btSua.Location = new System.Drawing.Point(38, 59);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(75, 23);
            this.btSua.TabIndex = 0;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            // 
            // cbTenNV
            // 
            this.cbTenNV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTenNV.FormattingEnabled = true;
            this.cbTenNV.Location = new System.Drawing.Point(113, 21);
            this.cbTenNV.Name = "cbTenNV";
            this.cbTenNV.Size = new System.Drawing.Size(161, 21);
            this.cbTenNV.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đề án";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nhân Viên";
            // 
            // btThoat
            // 
            this.btThoat.Location = new System.Drawing.Point(550, 369);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(75, 23);
            this.btThoat.TabIndex = 16;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            // 
            // txtMaDA
            // 
            this.txtMaDA.Enabled = false;
            this.txtMaDA.Location = new System.Drawing.Point(301, 58);
            this.txtMaDA.Name = "txtMaDA";
            this.txtMaDA.Size = new System.Drawing.Size(100, 20);
            this.txtMaDA.TabIndex = 2;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Enabled = false;
            this.txtMaNV.Location = new System.Drawing.Point(302, 21);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(100, 20);
            this.txtMaNV.TabIndex = 2;
            // 
            // cbTenDA
            // 
            this.cbTenDA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTenDA.FormattingEnabled = true;
            this.cbTenDA.Location = new System.Drawing.Point(113, 57);
            this.cbTenDA.Name = "cbTenDA";
            this.cbTenDA.Size = new System.Drawing.Size(161, 21);
            this.cbTenDA.TabIndex = 1;
            // 
            // grbDeAn
            // 
            this.grbDeAn.Controls.Add(this.txtMaDA);
            this.grbDeAn.Controls.Add(this.txtMaNV);
            this.grbDeAn.Controls.Add(this.cbTenDA);
            this.grbDeAn.Controls.Add(this.cbTenNV);
            this.grbDeAn.Controls.Add(this.label1);
            this.grbDeAn.Controls.Add(this.label2);
            this.grbDeAn.Location = new System.Drawing.Point(93, 63);
            this.grbDeAn.Name = "grbDeAn";
            this.grbDeAn.Size = new System.Drawing.Size(407, 104);
            this.grbDeAn.TabIndex = 18;
            this.grbDeAn.TabStop = false;
            this.grbDeAn.Text = "Thông tin NV_DA";
            // 
            // frmNV_DA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(666, 415);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btHienThi);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.btTiemKiem);
            this.Controls.Add(this.dtgvNVDA);
            this.Controls.Add(this.grbChucNang);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.grbDeAn);
            this.Name = "frmNV_DA";
            this.Text = "frmNV_DA";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvNVDA)).EndInit();
            this.grbChucNang.ResumeLayout(false);
            this.grbDeAn.ResumeLayout(false);
            this.grbDeAn.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btHienThi;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn mada;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn manv;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btTiemKiem;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.DataGridView dtgvNVDA;
        private System.Windows.Forms.GroupBox grbChucNang;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.ComboBox cbTenNV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.TextBox txtMaDA;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.ComboBox cbTenDA;
        private System.Windows.Forms.GroupBox grbDeAn;
    }
}