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
    public partial class UpdateKhoa : Form
    {
        public UpdateKhoa(String id)
        {
            this.id = id;
            InitializeComponent();
        }
        private string id;
        DataProvider d = new DataProvider();
        private void UpdateKhoa_Load(object sender, EventArgs e)
        {
            try
            {
                String strSelect = "select * from Khoa where MaKhoa = '" + id + "'";
                DataTable dt = d.executeQuery(strSelect);
                txtMaKhoa.DataBindings.Clear();
                txtMaKhoa.DataBindings.Add("Text", dt, "MaKhoa");

                txtTenKhoa.DataBindings.Clear();
                txtTenKhoa.DataBindings.Add("Text", dt, "TenKhoa");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTenKhoa.Text.Trim() != "")
                {
                    String strUpdate = "UPDATE [dbo].[Khoa]\r\n" +
                        "   SET\r\n" +
                        "      [TenKhoa] = N'" + txtTenKhoa.Text.Trim()+ "' " +
                        " where MaKhoa = '" + id + "'";
                    if (d.executeNonQuery(strUpdate))
                    {
                        MessageBox.Show("Cập nhật thành công");

                    }

                }
                else
                {
                    MessageBox.Show("Hãy nhập đầy đủ thông tin");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void txtMaKhoa_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                String strUpdate = "UPDATE [dbo].[SinhVien]\r\n" +
                    "   SET \r\n" +
                    "      [MaKhoa] = null\r\n" +
                    " WHERE MaKhoa = '" + id + "'";
                String strDelete = "DELETE FROM [dbo].[Khoa]\r\n" +
                                   "WHERE MaKhoa = '" + id + "'";
                DialogResult dr = MessageBox.Show("Bạn có muốn xóa Khoa này không? " + "\nChú ý: Xóa khoa sẽ liên quan đến dữ liệu bảng Sinh viên ", "Thông báo", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    if (d.executeNonQuery(strUpdate) && d.executeNonQuery(strDelete))
                    {
                        MessageBox.Show("Xóa thành công");
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}
