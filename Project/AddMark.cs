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
    public partial class AddMark : Form
    {
        public AddMark()
        {
            InitializeComponent();
        }

        private void AddMark_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        DataProvider d = new DataProvider();
        private void LoadData()
        {
            try
            {
                String strSelect1 = "select MaSo, HoTen from SinhVien";
                DataTable dt = d.executeQuery(strSelect1);
                cboMaSo.DataSource = dt;
                cboMaSo.DisplayMember = "MaSo";
                cboMaSo.ValueMember = "MaSo";

                cboHoTen.DataSource = dt;
                cboHoTen.DisplayMember = "HoTen";
                cboHoTen.ValueMember = "HoTen";

                String strSelect2 = "select MaMH, TenMH from Mon";
                DataTable dt2 = d.executeQuery(strSelect2);
                cboMaMH.DataSource = dt2;
                cboMaMH.DisplayMember = "MaMH";
                cboMaMH.ValueMember = "MaMH";

                cboTenMH.DataSource = dt2;
                cboTenMH.DisplayMember = "TenMH";
                cboTenMH.ValueMember = "TenMH";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex);
            }
        }

        private void btnAddMark_Click(object sender, EventArgs e)
        {
            try
            {
                String strSelect = "select * from KetQua where MaSo = " + cboMaSo.Text + " and MaMH = '" + cboMaMH.Text + "'";
                DataTable dt = d.executeQuery(strSelect);

                int mark = Int32.Parse(txtMark.Text);
                if (mark >= 0 && mark <= 10)
                {
                    if (dt.Rows.Count == 0 || dt.Rows.Count == null)
                    {
                        String strAdd = "INSERT INTO [dbo].[KetQua]\r\n" +
                        "           ([MaSo]\r\n" +
                        "           ,[MaMH]\r\n" +
                        "           ,[Diem])\r\n" +
                        "     VALUES\r\n" +
                        "           ('" + cboMaSo.Text + "', '" + cboMaMH.Text + "', " + mark + ")";
                        if (d.executeNonQuery(strAdd))
                        {
                            MessageBox.Show("Nhập điểm thành công");
                        }

                    }
                    else
                    {
                        int oldmark= Convert.ToInt32(dt.Rows[0][2].ToString());
                        DialogResult dr = MessageBox.Show("Điểm của " + cboHoTen.Text + " môn " + cboTenMH.Text + " là " +oldmark+". Bạn có muốn thay đổi thành "+txtMark.Text+" không?", "Thông báo", MessageBoxButtons.YesNoCancel);
                        if(dr == DialogResult.Yes)
                        {
                            String strUpdate = "UPDATE [dbo].[KetQua]\r\n" +
                                "   SET [Diem] = "+mark+"\r\n" +
                                " WHERE MaSo = "+cboMaSo.Text+" and MaMH = '"+cboMaMH.Text+"'";
                            if (d.executeNonQuery(strUpdate))
                            {
                                MessageBox.Show("Cập nhật điểm thành công");
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Nhập điểm trong khoảng từ 0 đến 10");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex);
            }
        }
    }
}
