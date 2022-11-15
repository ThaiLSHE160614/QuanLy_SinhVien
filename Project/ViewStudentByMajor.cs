using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class ViewStudentByMajor : Form
    {
        public ViewStudentByMajor()
        {
            InitializeComponent();
        }

        DataProvider d = new DataProvider();
        private void ViewStudentByMajor_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                String strSelect = "SELECT * from Khoa";
                DataTable dt = d.executeQuery(strSelect);
                cboMaKhoa.DataSource = dt;
                cboMaKhoa.DisplayMember = "MaKhoa";
                cboMaKhoa.ValueMember = "MaKhoa";

                cboTenKhoa.DataSource = dt;
                cboTenKhoa.DisplayMember = "TenKhoa";
                cboTenKhoa.ValueMember = "TenKhoa";

            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi: "+ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                String strSelect = "SELECT       SinhVien.MaSo, SinhVien.HoTen, SinhVien.NgaySinh, SinhVien.GioiTinh, SinhVien.DiaChi, SinhVien.DienThoai\r\n" +
                    "FROM            Khoa INNER JOIN\r\n" +
                    "                         SinhVien ON Khoa.MaKhoa = SinhVien.MaKhoa\r\n" +
                    "Where        Khoa.MaKhoa = '"+cboMaKhoa.Text.Trim()+"'";
                DataTable dt = d.executeQuery(strSelect);
                dgStudent.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}
