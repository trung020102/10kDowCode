
namespace QLSV
{
    partial class Form1
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
            this.mnuHethong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDangnhap = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDangxuat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDanhmuc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDanhmucLop = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDanhmucSV = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTracuu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTracuuLop = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuTracuuSV = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBaocao = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBaocaoSV = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHethong,
            this.mnuDanhmuc,
            this.mnuTracuu,
            this.mnuBaocao});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 46);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuHethong
            // 
            this.mnuHethong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDangnhap,
            this.mnuDangxuat,
            this.mnuThoat});
            this.mnuHethong.Name = "mnuHethong";
            this.mnuHethong.Size = new System.Drawing.Size(149, 42);
            this.mnuHethong.Text = "Hệ thống";
            this.mnuHethong.Click += new System.EventHandler(this.hệThốngToolStripMenuItem_Click);
            // 
            // mnuDangnhap
            // 
            this.mnuDangnhap.Name = "mnuDangnhap";
            this.mnuDangnhap.Size = new System.Drawing.Size(260, 46);
            this.mnuDangnhap.Text = "Đăng nhập";
            this.mnuDangnhap.Click += new System.EventHandler(this.mnuDangnhap_Click);
            // 
            // mnuDangxuat
            // 
            this.mnuDangxuat.Name = "mnuDangxuat";
            this.mnuDangxuat.Size = new System.Drawing.Size(260, 46);
            this.mnuDangxuat.Text = "Đăng xuất";
            // 
            // mnuThoat
            // 
            this.mnuThoat.Name = "mnuThoat";
            this.mnuThoat.Size = new System.Drawing.Size(260, 46);
            this.mnuThoat.Text = "Thoát";
            this.mnuThoat.Click += new System.EventHandler(this.mnuThoat_Click);
            // 
            // mnuDanhmuc
            // 
            this.mnuDanhmuc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDanhmucLop,
            this.mnuDanhmucSV});
            this.mnuDanhmuc.Name = "mnuDanhmuc";
            this.mnuDanhmuc.Size = new System.Drawing.Size(160, 42);
            this.mnuDanhmuc.Text = "Danh mục";
            // 
            // mnuDanhmucLop
            // 
            this.mnuDanhmucLop.Name = "mnuDanhmucLop";
            this.mnuDanhmucLop.Size = new System.Drawing.Size(270, 46);
            this.mnuDanhmucLop.Text = "Lớp";
            this.mnuDanhmucLop.Click += new System.EventHandler(this.mnuDanhmucLop_Click);
            // 
            // mnuDanhmucSV
            // 
            this.mnuDanhmucSV.Name = "mnuDanhmucSV";
            this.mnuDanhmucSV.Size = new System.Drawing.Size(270, 46);
            this.mnuDanhmucSV.Text = "Sinh viên";
            this.mnuDanhmucSV.Click += new System.EventHandler(this.mnuDanhmucSV_Click);
            // 
            // mnuTracuu
            // 
            this.mnuTracuu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTracuuLop,
            this.toolStripSeparator1,
            this.mnuTracuuSV});
            this.mnuTracuu.Name = "mnuTracuu";
            this.mnuTracuu.Size = new System.Drawing.Size(123, 42);
            this.mnuTracuu.Text = "Tra cứu";
            // 
            // mnuTracuuLop
            // 
            this.mnuTracuuLop.Name = "mnuTracuuLop";
            this.mnuTracuuLop.Size = new System.Drawing.Size(237, 46);
            this.mnuTracuuLop.Text = "Lớp";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(234, 6);
            // 
            // mnuTracuuSV
            // 
            this.mnuTracuuSV.Name = "mnuTracuuSV";
            this.mnuTracuuSV.Size = new System.Drawing.Size(237, 46);
            this.mnuTracuuSV.Text = "Sinh viên";
            // 
            // mnuBaocao
            // 
            this.mnuBaocao.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBaocaoSV});
            this.mnuBaocao.Name = "mnuBaocao";
            this.mnuBaocao.Size = new System.Drawing.Size(130, 42);
            this.mnuBaocao.Text = "Báo cáo";
            // 
            // mnuBaocaoSV
            // 
            this.mnuBaocaoSV.Name = "mnuBaocaoSV";
            this.mnuBaocaoSV.Size = new System.Drawing.Size(237, 46);
            this.mnuBaocaoSV.Text = "Sinh viên";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Chương trình quản lí sinh viên";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.Form1_Load);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuHethong;
        private System.Windows.Forms.ToolStripMenuItem mnuDangnhap;
        private System.Windows.Forms.ToolStripMenuItem mnuDangxuat;
        private System.Windows.Forms.ToolStripMenuItem mnuThoat;
        private System.Windows.Forms.ToolStripMenuItem mnuDanhmuc;
        private System.Windows.Forms.ToolStripMenuItem mnuDanhmucLop;
        private System.Windows.Forms.ToolStripMenuItem mnuDanhmucSV;
        private System.Windows.Forms.ToolStripMenuItem mnuTracuu;
        private System.Windows.Forms.ToolStripMenuItem mnuTracuuLop;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnuTracuuSV;
        private System.Windows.Forms.ToolStripMenuItem mnuBaocao;
        private System.Windows.Forms.ToolStripMenuItem mnuBaocaoSV;
    }
}

