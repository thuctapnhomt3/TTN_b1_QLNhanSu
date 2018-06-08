namespace ThucTapNhom_B1
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qUẢNLÝNHÂNSỰToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.ttPhongBan = new System.Windows.Forms.ToolStripMenuItem();
            this.tsDeAn = new System.Windows.Forms.ToolStripMenuItem();
            this.tsNVDA = new System.Windows.Forms.ToolStripMenuItem();
            this.hƯỚNGDẪNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsLogOut = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hOToolStripMenuItem,
            this.qUẢNLÝNHÂNSỰToolStripMenuItem,
            this.hƯỚNGDẪNToolStripMenuItem,
            this.tsLogOut});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(737, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hOToolStripMenuItem
            // 
            this.hOToolStripMenuItem.Name = "hOToolStripMenuItem";
            this.hOToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.hOToolStripMenuItem.Text = "HOME";
            // 
            // qUẢNLÝNHÂNSỰToolStripMenuItem
            // 
            this.qUẢNLÝNHÂNSỰToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsNhanVien,
            this.ttPhongBan,
            this.tsDeAn,
            this.tsNVDA});
            this.qUẢNLÝNHÂNSỰToolStripMenuItem.Name = "qUẢNLÝNHÂNSỰToolStripMenuItem";
            this.qUẢNLÝNHÂNSỰToolStripMenuItem.Size = new System.Drawing.Size(123, 20);
            this.qUẢNLÝNHÂNSỰToolStripMenuItem.Text = "QUẢN LÝ NHÂN SỰ";
            // 
            // tsNhanVien
            // 
            this.tsNhanVien.Name = "tsNhanVien";
            this.tsNhanVien.Size = new System.Drawing.Size(182, 22);
            this.tsNhanVien.Text = "NHÂN VIÊN";
            // 
            // ttPhongBan
            // 
            this.ttPhongBan.Name = "ttPhongBan";
            this.ttPhongBan.Size = new System.Drawing.Size(182, 22);
            this.ttPhongBan.Text = "PHÒNG BAN";
            // 
            // tsDeAn
            // 
            this.tsDeAn.Name = "tsDeAn";
            this.tsDeAn.Size = new System.Drawing.Size(182, 22);
            this.tsDeAn.Text = "ĐỀ ÁN";
            // 
            // tsNVDA
            // 
            this.tsNVDA.Name = "tsNVDA";
            this.tsNVDA.Size = new System.Drawing.Size(182, 22);
            this.tsNVDA.Text = "NHÂN VIÊN - ĐỀ ÁN";
            // 
            // hƯỚNGDẪNToolStripMenuItem
            // 
            this.hƯỚNGDẪNToolStripMenuItem.Name = "hƯỚNGDẪNToolStripMenuItem";
            this.hƯỚNGDẪNToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.hƯỚNGDẪNToolStripMenuItem.Text = "HƯỚNG DẪN";
            // 
            // tsLogOut
            // 
            this.tsLogOut.Name = "tsLogOut";
            this.tsLogOut.Size = new System.Drawing.Size(69, 20);
            this.tsLogOut.Text = "LOG OUT";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(737, 381);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem qUẢNLÝNHÂNSỰToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsNhanVien;
        private System.Windows.Forms.ToolStripMenuItem ttPhongBan;
        private System.Windows.Forms.ToolStripMenuItem tsDeAn;
        private System.Windows.Forms.ToolStripMenuItem tsNVDA;
        private System.Windows.Forms.ToolStripMenuItem hƯỚNGDẪNToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsLogOut;
    }
}