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
    public partial class ViewMarkBySubject : Form
    {
        public ViewMarkBySubject()
        {
            InitializeComponent();
        }

        private void ViewMarkBySubject_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        DataProvider d = new DataProvider();
        private void LoadData()
        {
            try
            {
                String strSelect = "select * from Mon";
                DataTable dt = d.executeQuery(strSelect);
                cboMaMH.DataSource = dt;
                cboMaMH.DisplayMember = "MaMH";
                cboMaMH.ValueMember = "MaMH";

                cboTenMH.DataSource = dt;
                cboTenMH.DisplayMember = "TenMH";
                cboTenMH.ValueMember = "TenMH";
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi: "+ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try {
                String strSelect = "SELECT       SinhVien.HoTen, KetQua.Diem\r\n" +
                    "FROM            KetQua INNER JOIN\r\n" +
                    "                         Mon ON KetQua.MaMH = Mon.MaMH INNER JOIN\r\n" +
                    "                         SinhVien ON KetQua.MaSo = SinhVien.MaSo\r\n" +
                    "where        Mon.MaMH= '" + cboMaMH.Text + "'";
                DataTable dt2 = d.executeQuery(strSelect);
                dgMark.DataSource= dt2 ;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}
