namespace TTN_1.GUI
{
    partial class frmDeAn
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
            this.txtMaPhong = new System.Windows.Forms.TextBox();
            this.lbMaDA = new System.Windows.Forms.Label();
            this.cbTenPhong = new System.Windows.Forms.ComboBox();
            this.txtSoGio = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtMaDeAn = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbTenPhong = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grbChucNang = new System.Windows.Forms.GroupBox();
            this.btXoa = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.btTiemKiem = new System.Windows.Forms.Button();
            this.dtgrDeAn = new System.Windows.Forms.DataGridView();
            this.mada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sogio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maphong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenphongban = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btThoat = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btHienThi = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btCancel = new System.Windows.Forms.Button();
            this.btOk = new System.Windows.Forms.Button();
            this.grbDeAn.SuspendLayout();
            this.grbChucNang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrDeAn)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbDeAn
            // 
            this.grbDeAn.Controls.Add(this.txtMaPhong);
            this.grbDeAn.Controls.Add(this.lbMaDA);
            this.grbDeAn.Controls.Add(this.cbTenPhong);
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
            this.grbDeAn.Size = new System.Drawing.Size(403, 182);
            this.grbDeAn.TabIndex = 0;
            this.grbDeAn.TabStop = false;
            this.grbDeAn.Text = "Thông tin đề án";
            // 
            // txtMaPhong
            // 
            this.txtMaPhong.Enabled = false;
            this.txtMaPhong.Location = new System.Drawing.Point(303, 125);
            this.txtMaPhong.Name = "txtMaPhong";
            this.txtMaPhong.Size = new System.Drawing.Size(77, 20);
            this.txtMaPhong.TabIndex = 5;
            // 
            // lbMaDA
            // 
            this.lbMaDA.AutoSize = true;
            this.lbMaDA.Location = new System.Drawing.Point(345, 128);
            this.lbMaDA.Name = "lbMaDA";
            this.lbMaDA.Size = new System.Drawing.Size(10, 13);
            this.lbMaDA.TabIndex = 4;
            this.lbMaDA.Text = " ";
            // 
            // cbTenPhong
            // 
            this.cbTenPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTenPhong.FormattingEnabled = true;
            this.cbTenPhong.Location = new System.Drawing.Point(139, 125);
            this.cbTenPhong.Name = "cbTenPhong";
            this.cbTenPhong.Size = new System.Drawing.Size(159, 21);
            this.cbTenPhong.TabIndex = 3;
            this.cbTenPhong.SelectedIndexChanged += new System.EventHandler(this.cbTenPhong_SelectedIndexChanged);
            // 
            // txtSoGio
            // 
            this.txtSoGio.Location = new System.Drawing.Point(139, 92);
            this.txtSoGio.Name = "txtSoGio";
            this.txtSoGio.Size = new System.Drawing.Size(241, 20);
            this.txtSoGio.TabIndex = 2;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(139, 57);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(241, 20);
            this.txtTen.TabIndex = 1;
            // 
            // txtMaDeAn
            // 
            this.txtMaDeAn.Location = new System.Drawing.Point(139, 26);
            this.txtMaDeAn.Name = "txtMaDeAn";
            this.txtMaDeAn.Size = new System.Drawing.Size(241, 20);
            this.txtMaDeAn.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Phòng làm đề án:";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên đề án:";
            // 
            // lbTenPhong
            // 
            this.lbTenPhong.AutoSize = true;
            this.lbTenPhong.Location = new System.Drawing.Point(136, 149);
            this.lbTenPhong.Name = "lbTenPhong";
            this.lbTenPhong.Size = new System.Drawing.Size(0, 13);
            this.lbTenPhong.TabIndex = 0;
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
            // grbChucNang
            // 
            this.grbChucNang.Controls.Add(this.btXoa);
            this.grbChucNang.Controls.Add(this.btSua);
            this.grbChucNang.Controls.Add(this.btThem);
            this.grbChucNang.Location = new System.Drawing.Point(411, 12);
            this.grbChucNang.Name = "grbChucNang";
            this.grbChucNang.Size = new System.Drawing.Size(125, 182);
            this.grbChucNang.TabIndex = 1;
            this.grbChucNang.TabStop = false;
            this.grbChucNang.Text = "Chức năng";
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(39, 133);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(75, 23);
            this.btXoa.TabIndex = 0;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btSua
            // 
            this.btSua.Location = new System.Drawing.Point(39, 89);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(75, 23);
            this.btSua.TabIndex = 0;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(39, 33);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(75, 23);
            this.btThem.TabIndex = 0;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btTiemKiem
            // 
            this.btTiemKiem.Location = new System.Drawing.Point(475, 216);
            this.btTiemKiem.Name = "btTiemKiem";
            this.btTiemKiem.Size = new System.Drawing.Size(75, 23);
            this.btTiemKiem.TabIndex = 0;
            this.btTiemKiem.Text = "Tìm kiếm";
            this.btTiemKiem.UseVisualStyleBackColor = true;
            this.btTiemKiem.Click += new System.EventHandler(this.btTiemKiem_Click);
            // 
            // dtgrDeAn
            // 
            this.dtgrDeAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrDeAn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mada,
            this.tenda,
            this.sogio,
            this.maphong,
            this.tenphongban});
            this.dtgrDeAn.Location = new System.Drawing.Point(2, 245);
            this.dtgrDeAn.Name = "dtgrDeAn";
            this.dtgrDeAn.RowHeadersVisible = false;
            this.dtgrDeAn.Size = new System.Drawing.Size(458, 182);
            this.dtgrDeAn.TabIndex = 2;
            this.dtgrDeAn.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrDeAn_CellClick);
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
            this.tenda.HeaderText = "Tên đề án";
            this.tenda.Name = "tenda";
            // 
            // sogio
            // 
            this.sogio.DataPropertyName = "sogio";
            this.sogio.HeaderText = "Số giờ";
            this.sogio.Name = "sogio";
            // 
            // maphong
            // 
            this.maphong.DataPropertyName = "maphong";
            this.maphong.HeaderText = "Mã Phòng";
            this.maphong.Name = "maphong";
            this.maphong.Width = 50;
            // 
            // tenphongban
            // 
            this.tenphongban.DataPropertyName = "tenphongban";
            this.tenphongban.HeaderText = "Tên phòng làm đề án";
            this.tenphongban.Name = "tenphongban";
            // 
            // btThoat
            // 
            this.btThoat.Location = new System.Drawing.Point(475, 404);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(75, 23);
            this.btThoat.TabIndex = 0;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(253, 216);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(207, 20);
            this.txtTimKiem.TabIndex = 3;
            // 
            // btHienThi
            // 
            this.btHienThi.Enabled = false;
            this.btHienThi.Location = new System.Drawing.Point(461, 245);
            this.btHienThi.Name = "btHienThi";
            this.btHienThi.Size = new System.Drawing.Size(89, 23);
            this.btHienThi.TabIndex = 4;
            this.btHienThi.Text = "Hiện thông tin";
            this.btHienThi.UseVisualStyleBackColor = true;
            this.btHienThi.Click += new System.EventHandler(this.btHienThi_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btCancel);
            this.panel1.Controls.Add(this.btOk);
            this.panel1.Location = new System.Drawing.Point(466, 274);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(84, 100);
            this.panel1.TabIndex = 13;
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(3, 52);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 13;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btOk
            // 
            this.btOk.Location = new System.Drawing.Point(3, 13);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(75, 23);
            this.btOk.TabIndex = 13;
            this.btOk.Text = "Ok";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // frmDeAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(560, 428);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btHienThi);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.btTiemKiem);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.dtgrDeAn);
            this.Controls.Add(this.grbChucNang);
            this.Controls.Add(this.grbDeAn);
            this.Name = "frmDeAn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeAn";
            this.grbDeAn.ResumeLayout(false);
            this.grbDeAn.PerformLayout();
            this.grbChucNang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrDeAn)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbDeAn;
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
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btHienThi;
        private System.Windows.Forms.ComboBox cbTenPhong;
        private System.Windows.Forms.Label lbMaDA;
        private System.Windows.Forms.DataGridViewTextBoxColumn mada;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn sogio;
        private System.Windows.Forms.DataGridViewTextBoxColumn maphong;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenphongban;
        private System.Windows.Forms.TextBox txtMaPhong;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btOk;
    }
}