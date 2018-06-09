namespace TTN_1.GUI
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
            this.nHÂNVIÊNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ttPhongBan = new System.Windows.Forms.ToolStripMenuItem();
            this.đỀÁNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hƯỚNGDẪNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lOGOUTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hOToolStripMenuItem,
            this.qUẢNLÝNHÂNSỰToolStripMenuItem,
            this.hƯỚNGDẪNToolStripMenuItem,
            this.lOGOUTToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(864, 24);
            this.menuStrip1.TabIndex = 0;
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
            this.nHÂNVIÊNToolStripMenuItem,
            this.ttPhongBan,
            this.đỀÁNToolStripMenuItem});
            this.qUẢNLÝNHÂNSỰToolStripMenuItem.Name = "qUẢNLÝNHÂNSỰToolStripMenuItem";
            this.qUẢNLÝNHÂNSỰToolStripMenuItem.Size = new System.Drawing.Size(123, 20);
            this.qUẢNLÝNHÂNSỰToolStripMenuItem.Text = "QUẢN LÝ NHÂN SỰ";
            // 
            // nHÂNVIÊNToolStripMenuItem
            // 
            this.nHÂNVIÊNToolStripMenuItem.Name = "nHÂNVIÊNToolStripMenuItem";
            this.nHÂNVIÊNToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.nHÂNVIÊNToolStripMenuItem.Text = "NHÂN VIÊN";
            // 
            // ttPhongBan
            // 
            this.ttPhongBan.Name = "ttPhongBan";
            this.ttPhongBan.Size = new System.Drawing.Size(152, 22);
            this.ttPhongBan.Text = "PHÒNG BAN";
            this.ttPhongBan.Click += new System.EventHandler(this.ttPhongBan_Click);
            // 
            // đỀÁNToolStripMenuItem
            // 
            this.đỀÁNToolStripMenuItem.Name = "đỀÁNToolStripMenuItem";
            this.đỀÁNToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.đỀÁNToolStripMenuItem.Text = "ĐỀ ÁN";
            // 
            // hƯỚNGDẪNToolStripMenuItem
            // 
            this.hƯỚNGDẪNToolStripMenuItem.Name = "hƯỚNGDẪNToolStripMenuItem";
            this.hƯỚNGDẪNToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.hƯỚNGDẪNToolStripMenuItem.Text = "HƯỚNG DẪN";
            // 
            // lOGOUTToolStripMenuItem
            // 
            this.lOGOUTToolStripMenuItem.Name = "lOGOUTToolStripMenuItem";
            this.lOGOUTToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.lOGOUTToolStripMenuItem.Text = "LOG OUT";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 414);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "frmMaincs";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem qUẢNLÝNHÂNSỰToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nHÂNVIÊNToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ttPhongBan;
        private System.Windows.Forms.ToolStripMenuItem đỀÁNToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hƯỚNGDẪNToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lOGOUTToolStripMenuItem;
    }
}