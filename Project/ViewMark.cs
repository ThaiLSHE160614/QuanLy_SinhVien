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
    public partial class ViewMark : Form
    {
        public ViewMark()
        {
            InitializeComponent();
        }

        private void ViewMark_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        DataProvider d = new DataProvider();
        private void LoadData()
        {
            try
            {
                String strSelect = "SELECT       SinhVien.MaSo, SinhVien.HoTen, Khoa.TenKhoa\r\n" +
                    "FROM            Khoa INNER JOIN\r\n" +
                    "                         SinhVien ON Khoa.MaKhoa = SinhVien.MaKhoa";
                DataTable dt = d.executeQuery(strSelect);
                cboMaSo.DataSource = dt;
                cboMaSo.DisplayMember = "MaSo";
                cboMaSo.ValueMember = "MaSo";

                cboName.DataSource = dt;
                cboName.DisplayMember = "HoTen";
                cboName.ValueMember = "HoTen";

                txtMajor.DataBindings.Clear();
                txtMajor.DataBindings.Add("Text", dt, "TenKhoa");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex);
            }
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            try
            {
                String strSelect = "SELECT       Mon.TenMH, KetQua.Diem\r\n" +
                    "FROM            KetQua INNER JOIN\r\n" +
                    "                         Mon ON KetQua.MaMH = Mon.MaMH\r\n" +
                    "WHERE        KetQua.MaSo="+cboMaSo.Text;
                DataTable dt= d.executeQuery(strSelect);
                dgMark.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex);
            }
        }
    }
}
