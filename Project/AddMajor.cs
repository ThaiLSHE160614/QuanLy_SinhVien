using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class AddMajor : Form
    {
        public AddMajor()
        {
            InitializeComponent();
        }
        DataProvider d = new DataProvider();

        private bool checkMaKhoa(String id)
        {
            try
            {
                String strSelect = "select * from Khoa where MaKhoa = '"+id+"'";
                DataTable dt = d.executeQuery(strSelect);
                if (dt.Rows.Count == null || dt.Rows.Count == 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
                return false;
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaKhoa.Text.Trim() == "" || txtTenKhoa.Text.Trim() == "")
                {
                    MessageBox.Show("Hãy nhập đầy đủ thông tin");
                }
                else
                {

                    if (checkMaKhoa(txtMaKhoa.Text.Trim()))
                    {
                        MessageBox.Show("Mã khoa đã tồn tại");
                    }
                    else
                    {
                        String strAdd = "INSERT INTO [dbo].[Khoa]\r\n" +
                            "           ([MaKhoa]\r\n" +
                            "           ,[TenKhoa])\r\n" +
                            "     VALUES\r\n" +
                            "           ('" + txtMaKhoa.Text.Trim() + "', N'" + txtTenKhoa.Text.Trim() + "')";
                        if (d.executeNonQuery(strAdd))
                        {
                            MessageBox.Show("Thêm khoa thành công!");
                            txtMaKhoa.Clear();
                            txtTenKhoa.Clear();

                        }
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
