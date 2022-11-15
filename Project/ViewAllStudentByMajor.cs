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
    public partial class ViewAllStudentByMajor : Form
    {
        public ViewAllStudentByMajor()
        {
            InitializeComponent();
        }

        DataProvider d = new DataProvider();
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            try
            {
                String strSelect = "SELECT       MaSo, HoTen, NgaySinh, GioiTinh, DiaChi, DienThoai\r\n" +
                    "FROM            SinhVien\r\n" +
                    "WHERE        MaKhoa = '"+cboMaKhoa.Text+"'";
                DataTable dt = d.executeQuery(strSelect);
                dgKhoa.DataSource = dt;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void ViewAllStudentByMajor_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                String strSelect = "select * from Khoa";
                DataTable dt = d.executeQuery(strSelect);
                cboMaKhoa.DataSource = dt;
                cboMaKhoa.DisplayMember = "MaKhoa";
                cboMaKhoa.ValueMember = "MaKhoa";

                cboTenKhoa.DataSource = dt;
                cboTenKhoa.DisplayMember = "TenKhoa";
                cboTenKhoa.ValueMember = "TenKhoa";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}
