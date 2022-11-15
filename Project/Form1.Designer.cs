namespace Project
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chứcNăngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sinhViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.khoaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mônHọcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sửaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sinhViênToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.khoaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mônToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhSáchSinhViênTheoKhoaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhSáchĐiểmTheoSinhViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhSáchĐiểmTheoMônToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhậpĐiểmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hỗTrợToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.sbtnStudent = new System.Windows.Forms.ToolStripButton();
            this.sbtnMajor = new System.Windows.Forms.ToolStripButton();
            this.sbtnSubject = new System.Windows.Forms.ToolStripButton();
            this.sbtnAddMark = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.sbtnMark = new System.Windows.Forms.ToolStripButton();
            this.sbtnAll = new System.Windows.Forms.ToolStripButton();
            this.sbtnExit = new System.Windows.Forms.ToolStripButton();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.miniToolStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.chứcNăngToolStripMenuItem,
            this.hỗTrợToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // chứcNăngToolStripMenuItem
            // 
            this.chứcNăngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmToolStripMenuItem,
            this.sửaToolStripMenuItem,
            this.thốngKêToolStripMenuItem,
            this.nhậpĐiểmToolStripMenuItem});
            this.chứcNăngToolStripMenuItem.Name = "chứcNăngToolStripMenuItem";
            this.chứcNăngToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.chứcNăngToolStripMenuItem.Text = "Chức năng";
            // 
            // thêmToolStripMenuItem
            // 
            this.thêmToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sinhViênToolStripMenuItem,
            this.khoaToolStripMenuItem,
            this.mônHọcToolStripMenuItem});
            this.thêmToolStripMenuItem.Name = "thêmToolStripMenuItem";
            this.thêmToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.thêmToolStripMenuItem.Text = "Thêm";
            // 
            // sinhViênToolStripMenuItem
            // 
            this.sinhViênToolStripMenuItem.Name = "sinhViênToolStripMenuItem";
            this.sinhViênToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sinhViênToolStripMenuItem.Text = "Sinh viên";
            this.sinhViênToolStripMenuItem.Click += new System.EventHandler(this.sinhViênToolStripMenuItem_Click_1);
            // 
            // khoaToolStripMenuItem
            // 
            this.khoaToolStripMenuItem.Name = "khoaToolStripMenuItem";
            this.khoaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.khoaToolStripMenuItem.Text = "Khoa";
            this.khoaToolStripMenuItem.Click += new System.EventHandler(this.khoaToolStripMenuItem_Click_1);
            // 
            // mônHọcToolStripMenuItem
            // 
            this.mônHọcToolStripMenuItem.Name = "mônHọcToolStripMenuItem";
            this.mônHọcToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mônHọcToolStripMenuItem.Text = "Môn học";
            this.mônHọcToolStripMenuItem.Click += new System.EventHandler(this.mônHọcToolStripMenuItem_Click);
            // 
            // sửaToolStripMenuItem
            // 
            this.sửaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sinhViênToolStripMenuItem1,
            this.khoaToolStripMenuItem1,
            this.mônToolStripMenuItem});
            this.sửaToolStripMenuItem.Name = "sửaToolStripMenuItem";
            this.sửaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sửaToolStripMenuItem.Text = "Sửa thông tin";
            // 
            // sinhViênToolStripMenuItem1
            // 
            this.sinhViênToolStripMenuItem1.Name = "sinhViênToolStripMenuItem1";
            this.sinhViênToolStripMenuItem1.Size = new System.Drawing.Size(123, 22);
            this.sinhViênToolStripMenuItem1.Text = "Sinh Viên";
            this.sinhViênToolStripMenuItem1.Click += new System.EventHandler(this.sinhViênToolStripMenuItem1_Click);
            // 
            // khoaToolStripMenuItem1
            // 
            this.khoaToolStripMenuItem1.Name = "khoaToolStripMenuItem1";
            this.khoaToolStripMenuItem1.Size = new System.Drawing.Size(123, 22);
            this.khoaToolStripMenuItem1.Text = "Khoa";
            this.khoaToolStripMenuItem1.Click += new System.EventHandler(this.khoaToolStripMenuItem1_Click);
            // 
            // mônToolStripMenuItem
            // 
            this.mônToolStripMenuItem.Name = "mônToolStripMenuItem";
            this.mônToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.mônToolStripMenuItem.Text = "Môn";
            this.mônToolStripMenuItem.Click += new System.EventHandler(this.mônToolStripMenuItem_Click);
            // 
            // thốngKêToolStripMenuItem
            // 
            this.thốngKêToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.danhSáchSinhViênTheoKhoaToolStripMenuItem,
            this.danhSáchĐiểmTheoSinhViênToolStripMenuItem,
            this.danhSáchĐiểmTheoMônToolStripMenuItem});
            this.thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
            this.thốngKêToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.thốngKêToolStripMenuItem.Text = "Thống kê";
            // 
            // danhSáchSinhViênTheoKhoaToolStripMenuItem
            // 
            this.danhSáchSinhViênTheoKhoaToolStripMenuItem.Name = "danhSáchSinhViênTheoKhoaToolStripMenuItem";
            this.danhSáchSinhViênTheoKhoaToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.danhSáchSinhViênTheoKhoaToolStripMenuItem.Text = "Danh sách sinh viên theo khoa";
            this.danhSáchSinhViênTheoKhoaToolStripMenuItem.Click += new System.EventHandler(this.danhSáchSinhViênTheoKhoaToolStripMenuItem_Click);
            // 
            // danhSáchĐiểmTheoSinhViênToolStripMenuItem
            // 
            this.danhSáchĐiểmTheoSinhViênToolStripMenuItem.Name = "danhSáchĐiểmTheoSinhViênToolStripMenuItem";
            this.danhSáchĐiểmTheoSinhViênToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.danhSáchĐiểmTheoSinhViênToolStripMenuItem.Text = "Danh sách điểm theo sinh viên";
            this.danhSáchĐiểmTheoSinhViênToolStripMenuItem.Click += new System.EventHandler(this.danhSáchĐiểmTheoSinhViênToolStripMenuItem_Click);
            // 
            // danhSáchĐiểmTheoMônToolStripMenuItem
            // 
            this.danhSáchĐiểmTheoMônToolStripMenuItem.Name = "danhSáchĐiểmTheoMônToolStripMenuItem";
            this.danhSáchĐiểmTheoMônToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.danhSáchĐiểmTheoMônToolStripMenuItem.Text = "Danh sách điểm theo môn";
            this.danhSáchĐiểmTheoMônToolStripMenuItem.Click += new System.EventHandler(this.danhSáchĐiểmTheoMônToolStripMenuItem_Click);
            // 
            // nhậpĐiểmToolStripMenuItem
            // 
            this.nhậpĐiểmToolStripMenuItem.Name = "nhậpĐiểmToolStripMenuItem";
            this.nhậpĐiểmToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nhậpĐiểmToolStripMenuItem.Text = "Nhập điểm";
            this.nhậpĐiểmToolStripMenuItem.Click += new System.EventHandler(this.nhậpĐiểmToolStripMenuItem_Click);
            // 
            // hỗTrợToolStripMenuItem
            // 
            this.hỗTrợToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.hỗTrợToolStripMenuItem.Name = "hỗTrợToolStripMenuItem";
            this.hỗTrợToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.hỗTrợToolStripMenuItem.Text = "Hỗ trợ";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.aboutToolStripMenuItem.Text = "About.. .. ";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sbtnStudent,
            this.sbtnMajor,
            this.sbtnSubject,
            this.sbtnAddMark,
            this.toolStripSeparator1,
            this.sbtnMark,
            this.sbtnAll,
            this.sbtnExit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // sbtnStudent
            // 
            this.sbtnStudent.Image = ((System.Drawing.Image)(resources.GetObject("sbtnStudent.Image")));
            this.sbtnStudent.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.sbtnStudent.Name = "sbtnStudent";
            this.sbtnStudent.Size = new System.Drawing.Size(75, 22);
            this.sbtnStudent.Text = "Sinh viên";
            this.sbtnStudent.Click += new System.EventHandler(this.sbtnStudent_Click);
            // 
            // sbtnMajor
            // 
            this.sbtnMajor.Image = ((System.Drawing.Image)(resources.GetObject("sbtnMajor.Image")));
            this.sbtnMajor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.sbtnMajor.Name = "sbtnMajor";
            this.sbtnMajor.Size = new System.Drawing.Size(54, 22);
            this.sbtnMajor.Text = "Khoa";
            this.sbtnMajor.Click += new System.EventHandler(this.sbtnMajor_Click);
            // 
            // sbtnSubject
            // 
            this.sbtnSubject.Image = ((System.Drawing.Image)(resources.GetObject("sbtnSubject.Image")));
            this.sbtnSubject.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.sbtnSubject.Name = "sbtnSubject";
            this.sbtnSubject.Size = new System.Drawing.Size(75, 22);
            this.sbtnSubject.Text = "Môn học";
            this.sbtnSubject.Click += new System.EventHandler(this.sbtnSubject_Click);
            // 
            // sbtnAddMark
            // 
            this.sbtnAddMark.Image = ((System.Drawing.Image)(resources.GetObject("sbtnAddMark.Image")));
            this.sbtnAddMark.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.sbtnAddMark.Name = "sbtnAddMark";
            this.sbtnAddMark.Size = new System.Drawing.Size(86, 22);
            this.sbtnAddMark.Text = "Nhập điểm";
            this.sbtnAddMark.Click += new System.EventHandler(this.sbtnAddMark_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // sbtnMark
            // 
            this.sbtnMark.Image = ((System.Drawing.Image)(resources.GetObject("sbtnMark.Image")));
            this.sbtnMark.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.sbtnMark.Name = "sbtnMark";
            this.sbtnMark.Size = new System.Drawing.Size(81, 22);
            this.sbtnMark.Text = "Xem điểm";
            this.sbtnMark.Click += new System.EventHandler(this.sbtnMark_Click);
            // 
            // sbtnAll
            // 
            this.sbtnAll.Image = ((System.Drawing.Image)(resources.GetObject("sbtnAll.Image")));
            this.sbtnAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.sbtnAll.Name = "sbtnAll";
            this.sbtnAll.Size = new System.Drawing.Size(105, 22);
            this.sbtnAll.Text = "Thống kê khoa";
            this.sbtnAll.Click += new System.EventHandler(this.sbtnAll_Click);
            // 
            // sbtnExit
            // 
            this.sbtnExit.Image = ((System.Drawing.Image)(resources.GetObject("sbtnExit.Image")));
            this.sbtnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.sbtnExit.Margin = new System.Windows.Forms.Padding(75, 1, 0, 2);
            this.sbtnExit.Name = "sbtnExit";
            this.sbtnExit.Size = new System.Drawing.Size(57, 22);
            this.sbtnExit.Text = "Thoát";
            this.sbtnExit.Click += new System.EventHandler(this.sbtnExit_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // miniToolStrip
            // 
            this.miniToolStrip.AccessibleName = "New item selection";
            this.miniToolStrip.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonDropDown;
            this.miniToolStrip.AutoSize = false;
            this.miniToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.miniToolStrip.Location = new System.Drawing.Point(802, 23);
            this.miniToolStrip.Name = "miniToolStrip";
            this.miniToolStrip.Size = new System.Drawing.Size(800, 22);
            this.miniToolStrip.TabIndex = 0;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel1.Text = "Ready";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 377);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Quản lý sinh viên";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem hệThốngToolStripMenuItem;
        private ToolStripMenuItem chứcNăngToolStripMenuItem;
        private ToolStripMenuItem hỗTrợToolStripMenuItem;
        private ToolStrip toolStrip1;
        private ToolStripButton sbtnStudent;
        private ToolStripButton sbtnMajor;
        private ToolStripButton sbtnSubject;
        private ToolStripButton sbtnAddMark;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton sbtnMark;
        private ToolStripButton sbtnAll;
        private ToolStripButton sbtnExit;
        private FileSystemWatcher fileSystemWatcher1;
        private StatusStrip miniToolStrip;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private StatusStrip statusStrip1;
        private ToolStripMenuItem thêmToolStripMenuItem;
        private ToolStripMenuItem sinhViênToolStripMenuItem;
        private ToolStripMenuItem khoaToolStripMenuItem;
        private ToolStripMenuItem mônHọcToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ToolStripMenuItem sửaToolStripMenuItem;
        private ToolStripMenuItem sinhViênToolStripMenuItem1;
        private ToolStripMenuItem khoaToolStripMenuItem1;
        private ToolStripMenuItem mônToolStripMenuItem;
        private ToolStripMenuItem thốngKêToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem nhậpĐiểmToolStripMenuItem;
        private ToolStripMenuItem danhSáchSinhViênTheoKhoaToolStripMenuItem;
        private ToolStripMenuItem danhSáchĐiểmTheoSinhViênToolStripMenuItem;
        private ToolStripMenuItem danhSáchĐiểmTheoMônToolStripMenuItem;
    }
}