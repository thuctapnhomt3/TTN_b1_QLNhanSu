namespace TTN_1.GUI
{
    partial class DeAn
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
            this.grbDeAn = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaDeAn = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtSoGio = new System.Windows.Forms.TextBox();
            this.txtMaPhong = new System.Windows.Forms.TextBox();
            this.lbTenPhong = new System.Windows.Forms.Label();
            this.grbChucNang = new System.Windows.Forms.GroupBox();
            this.btThem = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btTiemKiem = new System.Windows.Forms.Button();
            this.dtgrDeAn = new System.Windows.Forms.DataGridView();
            this.btThoat = new System.Windows.Forms.Button();
            this.mada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sogio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenphong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbDeAn.SuspendLayout();
            this.grbChucNang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrDeAn)).BeginInit();
            this.SuspendLayout();
            // 
            // grbDeAn
            // 
            this.grbDeAn.Controls.Add(this.txtMaPhong);
            this.grbDeAn.Controls.Add(this.txtSoGio);
            this.grbDeAn.Controls.Add(this.txtTen);
            this.grbDeAn.Controls.Add(this.txtMaDeAn);
            this.grbDeAn.Controls.Add(this.label4);
            this.grbDeAn.Controls.Add(this.label3);
            this.grbDeAn.Controls.Add(this.label2);
            this.grbDeAn.Controls.Add(this.lbTenPhong);
            this.grbDeAn.Controls.Add(this.label1);
            this.grbDeAn.Location = new System.Drawing.Point(2, 12);
            this.grbDeAn.Name = "grbDeAn";
            this.grbDeAn.Size = new System.Drawing.Size(364, 182);
            this.grbDeAn.TabIndex = 0;
            this.grbDeAn.TabStop = false;
            this.grbDeAn.Text = "Thông tin đề án";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã đề án:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên đề án:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Số giờ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mã phòng làm đề án:";
            // 
            // txtMaDeAn
            // 
            this.txtMaDeAn.Location = new System.Drawing.Point(139, 26);
            this.txtMaDeAn.Name = "txtMaDeAn";
            this.txtMaDeAn.Size = new System.Drawing.Size(207, 20);
            this.txtMaDeAn.TabIndex = 0;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(139, 57);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(207, 20);
            this.txtTen.TabIndex = 1;
            // 
            // txtSoGio
            // 
            this.txtSoGio.Location = new System.Drawing.Point(139, 92);
            this.txtSoGio.Name = "txtSoGio";
            this.txtSoGio.Size = new System.Drawing.Size(207, 20);
            this.txtSoGio.TabIndex = 2;
            // 
            // txtMaPhong
            // 
            this.txtMaPhong.Location = new System.Drawing.Point(139, 126);
            this.txtMaPhong.Name = "txtMaPhong";
            this.txtMaPhong.Size = new System.Drawing.Size(207, 20);
            this.txtMaPhong.TabIndex = 3;
            // 
            // lbTenPhong
            // 
            this.lbTenPhong.AutoSize = true;
            this.lbTenPhong.Location = new System.Drawing.Point(136, 149);
            this.lbTenPhong.Name = "lbTenPhong";
            this.lbTenPhong.Size = new System.Drawing.Size(0, 13);
            this.lbTenPhong.TabIndex = 0;
            // 
            // grbChucNang
            // 
            this.grbChucNang.Controls.Add(this.btTiemKiem);
            this.grbChucNang.Controls.Add(this.btXoa);
            this.grbChucNang.Controls.Add(this.btSua);
            this.grbChucNang.Controls.Add(this.btThem);
            this.grbChucNang.Location = new System.Drawing.Point(372, 12);
            this.grbChucNang.Name = "grbChucNang";
            this.grbChucNang.Size = new System.Drawing.Size(150, 182);
            this.grbChucNang.TabIndex = 1;
            this.grbChucNang.TabStop = false;
            this.grbChucNang.Text = "Chức năng";
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
            // btSua
            // 
            this.btSua.Location = new System.Drawing.Point(38, 59);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(75, 23);
            this.btSua.TabIndex = 0;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = true;
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
            // btTiemKiem
            // 
            this.btTiemKiem.Location = new System.Drawing.Point(38, 133);
            this.btTiemKiem.Name = "btTiemKiem";
            this.btTiemKiem.Size = new System.Drawing.Size(75, 23);
            this.btTiemKiem.TabIndex = 0;
            this.btTiemKiem.Text = "Tìm kiếm";
            this.btTiemKiem.UseVisualStyleBackColor = true;
            // 
            // dtgrDeAn
            // 
            this.dtgrDeAn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            this.dtgrDeAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrDeAn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mada,
            this.tenda,
            this.sogio,
            this.tenphong});
            this.dtgrDeAn.Location = new System.Drawing.Point(2, 200);
            this.dtgrDeAn.Name = "dtgrDeAn";
            this.dtgrDeAn.RowHeadersVisible = false;
            this.dtgrDeAn.Size = new System.Drawing.Size(458, 182);
            this.dtgrDeAn.TabIndex = 2;
            // 
            // btThoat
            // 
            this.btThoat.Location = new System.Drawing.Point(466, 281);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(75, 23);
            this.btThoat.TabIndex = 0;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            // 
            // mada
            // 
            this.mada.HeaderText = "Mã đề án";
            this.mada.Name = "mada";
            this.mada.Width = 21;
            // 
            // tenda
            // 
            this.tenda.HeaderText = "Tên đề án";
            this.tenda.Name = "tenda";
            this.tenda.Width = 21;
            // 
            // sogio
            // 
            this.sogio.HeaderText = "Số giờ";
            this.sogio.Name = "sogio";
            this.sogio.Width = 21;
            // 
            // tenphong
            // 
            this.tenphong.HeaderText = "Tên phòng làm đề án";
            this.tenphong.Name = "tenphong";
            this.tenphong.Width = 21;
            // 
            // DeAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 409);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.dtgrDeAn);
            this.Controls.Add(this.grbChucNang);
            this.Controls.Add(this.grbDeAn);
            this.Name = "DeAn";
            this.Text = "DeAn";
            this.grbDeAn.ResumeLayout(false);
            this.grbDeAn.PerformLayout();
            this.grbChucNang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrDeAn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbDeAn;
        private System.Windows.Forms.TextBox txtMaPhong;
        private System.Windows.Forms.TextBox txtSoGio;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtMaDeAn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbTenPhong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbChucNang;
        private System.Windows.Forms.Button btTiemKiem;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.DataGridView dtgrDeAn;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.DataGridViewTextBoxColumn mada;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn sogio;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenphong;
    }
}