namespace Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            About ab = new About();
            ab.MdiParent = this;
            ab.Show();
        }

        private void sbtnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void sbtnAddMark_Click(object sender, EventArgs e)
        {
            AddMark addMark = new AddMark();
            addMark.MdiParent = this;
            addMark.Show(); 
        }

        private void sbtnStudent_Click(object sender, EventArgs e)
        {
            Sinhvien sinhvien = new Sinhvien();
            sinhvien.MdiParent = this;
            sinhvien.Show();
        }

        private void sbtnSubject_Click(object sender, EventArgs e)
        {
            Mon mon = new Mon();
            mon.MdiParent = this;
            mon.Show(); 
        }

        private void sbtnMajor_Click(object sender, EventArgs e)
        {
            Khoa khoa = new Khoa();
            khoa.MdiParent = this;
            khoa.Show();
        }

        private void sbtnMark_Click(object sender, EventArgs e)
        {
            ViewMark viewMark = new ViewMark();
            viewMark.MdiParent = this;
            viewMark.Show();
        }

        private void sinhViênToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            AddStudent addStudent = new AddStudent();
            addStudent.MdiParent = this;
            addStudent.Show();
        }

        private void khoaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            AddMajor addMajor = new AddMajor();
            addMajor.MdiParent = this;
            addMajor.Show();
        }

        private void mônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddSubject addSubject= new AddSubject();
            addSubject.MdiParent = this;
            addSubject.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About ab = new About();
            ab.MdiParent = this;
            ab.Show();
        }

        private void nhậpĐiểmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddMark addMark = new AddMark();
            addMark.MdiParent = this;
            addMark.Show();
        }

        private void danhSáchSinhViênTheoKhoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewStudentByMajor viewStudentByMajor = new ViewStudentByMajor();
            viewStudentByMajor.MdiParent = this;
            viewStudentByMajor.Show();
        }

        private void danhSáchĐiểmTheoSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewMark viewMark = new ViewMark();
            viewMark.MdiParent = this;
            viewMark.Show();
        }

        private void sinhViênToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Sinhvien sinhvien = new Sinhvien();
            sinhvien.MdiParent = this;
            sinhvien.Show();
        }

        private void khoaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Khoa khoa = new Khoa();
            khoa.MdiParent = this;
            khoa.Show();
        }

        private void mônToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mon mon = new Mon();
            mon.MdiParent = this;
            mon.Show();
        }

        private void danhSáchĐiểmTheoMônToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewMarkBySubject viewMarkBySubject = new ViewMarkBySubject();
            viewMarkBySubject.MdiParent = this;
            viewMarkBySubject.Show();
        }

        private void sbtnAll_Click(object sender, EventArgs e)
        {
            ViewAllStudentByMajor viewAllStudentByMajor = new ViewAllStudentByMajor();
            viewAllStudentByMajor.MdiParent = this;
            viewAllStudentByMajor.Show();
        }
    }
}