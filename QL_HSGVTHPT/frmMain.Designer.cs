namespace QL_HSGVTHPT
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tmrTime = new System.Windows.Forms.Timer(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbChucVu = new System.Windows.Forms.Label();
            this.lbTaiKhoan = new System.Windows.Forms.Label();
            this.lbTime = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.HeThong = new System.Windows.Forms.ToolStripMenuItem();
            this.HT_frmTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.HT_frmDangNhap = new System.Windows.Forms.ToolStripMenuItem();
            this.DanhMuc = new System.Windows.Forms.ToolStripMenuItem();
            this.frmDM_HSGV = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.frmDM_HSHS = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.frmDM_HSGD = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.frmDM_PhongHoc = new System.Windows.Forms.ToolStripMenuItem();
            this.frmDM_MonHoc = new System.Windows.Forms.ToolStripMenuItem();
            this.frmDM_LopHoc = new System.Windows.Forms.ToolStripMenuItem();
            this.frmThoiKhoaBieu = new System.Windows.Forms.ToolStripMenuItem();
            this.frmTimKiem = new System.Windows.Forms.ToolStripMenuItem();
            this.frmHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.hDSửDụngPMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.trợGiúpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.menuStrip1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 775);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // tmrTime
            // 
            this.tmrTime.Enabled = true;
            this.tmrTime.Interval = 1000;
            this.tmrTime.Tick += new System.EventHandler(this.tmrTime_Tick);
            // 
            // groupBox3
            // 
            this.groupBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox3.BackgroundImage")));
            this.groupBox3.Controls.Add(this.lbChucVu);
            this.groupBox3.Controls.Add(this.lbTaiKhoan);
            this.groupBox3.Controls.Add(this.lbTime);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.pictureBox1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(268, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1228, 775);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // lbChucVu
            // 
            this.lbChucVu.Location = new System.Drawing.Point(333, 202);
            this.lbChucVu.Name = "lbChucVu";
            this.lbChucVu.Size = new System.Drawing.Size(238, 21);
            this.lbChucVu.TabIndex = 4;
            // 
            // lbTaiKhoan
            // 
            this.lbTaiKhoan.Location = new System.Drawing.Point(333, 149);
            this.lbTaiKhoan.Name = "lbTaiKhoan";
            this.lbTaiKhoan.Size = new System.Drawing.Size(238, 21);
            this.lbTaiKhoan.TabIndex = 4;
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.Location = new System.Drawing.Point(956, 139);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(68, 31);
            this.lbTime.TabIndex = 3;
            this.lbTime.Text = "Time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(849, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày / Giờ :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(331, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(739, 36);
            this.label3.TabIndex = 2;
            this.label3.Text = "Phần Mềm Quản Lý Học Sinh _ Giáo Viên Trường THPT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(225, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chức Vụ :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(225, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tài Khoản : ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(202, 211);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menuStrip1.BackgroundImage")));
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HeThong,
            this.DanhMuc,
            this.frmThoiKhoaBieu,
            this.frmTimKiem,
            this.frmHelp});
            this.menuStrip1.Location = new System.Drawing.Point(3, 16);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(262, 756);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // HeThong
            // 
            this.HeThong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.HeThong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HT_frmTaiKhoan,
            this.toolStripMenuItem1,
            this.HT_frmDangNhap});
            this.HeThong.Name = "HeThong";
            this.HeThong.Size = new System.Drawing.Size(255, 26);
            this.HeThong.Text = "Hệ Thống";
            // 
            // HT_frmTaiKhoan
            // 
            this.HT_frmTaiKhoan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.HT_frmTaiKhoan.Image = global::QL_HSGVTHPT.Properties.Resources.business_people_01;
            this.HT_frmTaiKhoan.Name = "HT_frmTaiKhoan";
            this.HT_frmTaiKhoan.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.HT_frmTaiKhoan.Size = new System.Drawing.Size(234, 26);
            this.HT_frmTaiKhoan.Text = "Tài Khoản";
            this.HT_frmTaiKhoan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(231, 6);
            // 
            // HT_frmDangNhap
            // 
            this.HT_frmDangNhap.Image = global::QL_HSGVTHPT.Properties.Resources.sign_out;
            this.HT_frmDangNhap.Name = "HT_frmDangNhap";
            this.HT_frmDangNhap.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.HT_frmDangNhap.Size = new System.Drawing.Size(234, 26);
            this.HT_frmDangNhap.Text = "Đăng Xuất";
            this.HT_frmDangNhap.Click += new System.EventHandler(this.HT_frmDangNhap_Click);
            // 
            // DanhMuc
            // 
            this.DanhMuc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.frmDM_HSGV,
            this.toolStripMenuItem2,
            this.frmDM_HSHS,
            this.toolStripMenuItem3,
            this.frmDM_HSGD,
            this.toolStripMenuItem4,
            this.frmDM_PhongHoc,
            this.frmDM_MonHoc,
            this.frmDM_LopHoc});
            this.DanhMuc.Name = "DanhMuc";
            this.DanhMuc.Size = new System.Drawing.Size(255, 26);
            this.DanhMuc.Text = "Danh Mục";
            // 
            // frmDM_HSGV
            // 
            this.frmDM_HSGV.Image = global::QL_HSGVTHPT.Properties.Resources.invoice;
            this.frmDM_HSGV.Name = "frmDM_HSGV";
            this.frmDM_HSGV.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.frmDM_HSGV.Size = new System.Drawing.Size(256, 26);
            this.frmDM_HSGV.Text = "Hồ Sơ Giáo Viên";
            this.frmDM_HSGV.Click += new System.EventHandler(this.frmDM_HSGV_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(253, 6);
            // 
            // frmDM_HSHS
            // 
            this.frmDM_HSHS.Image = global::QL_HSGVTHPT.Properties.Resources.bill_of_document;
            this.frmDM_HSHS.Name = "frmDM_HSHS";
            this.frmDM_HSHS.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.frmDM_HSHS.Size = new System.Drawing.Size(256, 26);
            this.frmDM_HSHS.Text = "Hồ Sơ Học Sinh";
            this.frmDM_HSHS.Click += new System.EventHandler(this.frmDM_HSHS_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(253, 6);
            // 
            // frmDM_HSGD
            // 
            this.frmDM_HSGD.Image = global::QL_HSGVTHPT.Properties.Resources.invoice__1_;
            this.frmDM_HSGD.Name = "frmDM_HSGD";
            this.frmDM_HSGD.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.frmDM_HSGD.Size = new System.Drawing.Size(256, 26);
            this.frmDM_HSGD.Text = "Hồ Sơ Giảng Dạy";
            this.frmDM_HSGD.Click += new System.EventHandler(this.frmDM_HSGD_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(253, 6);
            // 
            // frmDM_PhongHoc
            // 
            this.frmDM_PhongHoc.Image = global::QL_HSGVTHPT.Properties.Resources.home_w;
            this.frmDM_PhongHoc.Name = "frmDM_PhongHoc";
            this.frmDM_PhongHoc.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.frmDM_PhongHoc.Size = new System.Drawing.Size(256, 26);
            this.frmDM_PhongHoc.Text = "Phòng Học";
            this.frmDM_PhongHoc.Click += new System.EventHandler(this.frmDM_PhongHoc_Click);
            // 
            // frmDM_MonHoc
            // 
            this.frmDM_MonHoc.Image = global::QL_HSGVTHPT.Properties.Resources.product;
            this.frmDM_MonHoc.Name = "frmDM_MonHoc";
            this.frmDM_MonHoc.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.frmDM_MonHoc.Size = new System.Drawing.Size(256, 26);
            this.frmDM_MonHoc.Text = "Môn Học";
            this.frmDM_MonHoc.Click += new System.EventHandler(this.frmDM_MonHoc_Click);
            // 
            // frmDM_LopHoc
            // 
            this.frmDM_LopHoc.Image = global::QL_HSGVTHPT.Properties.Resources.istockphoto_521262978_1024x1024;
            this.frmDM_LopHoc.Name = "frmDM_LopHoc";
            this.frmDM_LopHoc.ShortcutKeys = System.Windows.Forms.Keys.F6;
            this.frmDM_LopHoc.Size = new System.Drawing.Size(256, 26);
            this.frmDM_LopHoc.Text = "Lớp Học";
            this.frmDM_LopHoc.Click += new System.EventHandler(this.frmDM_LopHoc_Click);
            // 
            // frmThoiKhoaBieu
            // 
            this.frmThoiKhoaBieu.Name = "frmThoiKhoaBieu";
            this.frmThoiKhoaBieu.Size = new System.Drawing.Size(255, 26);
            this.frmThoiKhoaBieu.Text = "TKB Toàn Trường";
            // 
            // frmTimKiem
            // 
            this.frmTimKiem.Name = "frmTimKiem";
            this.frmTimKiem.Size = new System.Drawing.Size(255, 26);
            this.frmTimKiem.Text = "Tìm Kiếm";
            this.frmTimKiem.Click += new System.EventHandler(this.frmTimKiem_Click);
            // 
            // frmHelp
            // 
            this.frmHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hDSửDụngPMToolStripMenuItem,
            this.toolStripMenuItem5,
            this.trợGiúpToolStripMenuItem1});
            this.frmHelp.Name = "frmHelp";
            this.frmHelp.Size = new System.Drawing.Size(255, 26);
            this.frmHelp.Text = "Help";
            // 
            // hDSửDụngPMToolStripMenuItem
            // 
            this.hDSửDụngPMToolStripMenuItem.Image = global::QL_HSGVTHPT.Properties.Resources.edit_find;
            this.hDSửDụngPMToolStripMenuItem.Name = "hDSửDụngPMToolStripMenuItem";
            this.hDSửDụngPMToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.hDSửDụngPMToolStripMenuItem.Size = new System.Drawing.Size(288, 26);
            this.hDSửDụngPMToolStripMenuItem.Text = "HD Sử Dụng PM";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(285, 6);
            // 
            // trợGiúpToolStripMenuItem1
            // 
            this.trợGiúpToolStripMenuItem1.Image = global::QL_HSGVTHPT.Properties.Resources.gnome_dialog_question__1_;
            this.trợGiúpToolStripMenuItem1.Name = "trợGiúpToolStripMenuItem1";
            this.trợGiúpToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.trợGiúpToolStripMenuItem1.Size = new System.Drawing.Size(288, 26);
            this.trợGiúpToolStripMenuItem1.Text = "Trợ Giúp";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1496, 775);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMain";
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem HeThong;
        private System.Windows.Forms.ToolStripMenuItem HT_frmTaiKhoan;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem HT_frmDangNhap;
        private System.Windows.Forms.ToolStripMenuItem DanhMuc;
        private System.Windows.Forms.ToolStripMenuItem frmDM_HSGV;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem frmDM_HSHS;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem frmDM_HSGD;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem frmDM_PhongHoc;
        private System.Windows.Forms.ToolStripMenuItem frmDM_MonHoc;
        private System.Windows.Forms.ToolStripMenuItem frmDM_LopHoc;
        private System.Windows.Forms.ToolStripMenuItem frmThoiKhoaBieu;
        private System.Windows.Forms.ToolStripMenuItem frmTimKiem;
        private System.Windows.Forms.ToolStripMenuItem frmHelp;
        private System.Windows.Forms.ToolStripMenuItem hDSửDụngPMToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem trợGiúpToolStripMenuItem1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer tmrTime;
        private System.Windows.Forms.Label lbChucVu;
        private System.Windows.Forms.Label lbTaiKhoan;
    }
}