using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class UpdateSinhVien : Form
    {
        public UpdateSinhVien(String id)
        {
            this.id = id;
            InitializeComponent();
        }

        private String id;
        DataProvider d = new DataProvider();
        private void UpdateSinhVien_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            if (String.IsNullOrEmpty(id))
            {
                this.Text = "Thêm sinh viên mới";
            }
            else
            {
                
                this.Text = "Cập nhật thông tin sinh viên";
                try
                {
                    String strSelect = "SELECT * from SinhVien where MaSo = " + id;
                    DataTable dt = d.executeQuery(strSelect);
                    txtHoTen.DataBindings.Clear();
                    txtHoTen.DataBindings.Add("Text", dt, "HoTen");

                    dtNgaySinh.DataBindings.Clear();
                    dtNgaySinh.DataBindings.Add("Text", dt, "NgaySinh");

                    rdNam.DataBindings.Clear();
                    rdNam.DataBindings.Add("Checked", dt, "GioiTinh");

                    if (!rdNam.Checked)
                    {
                        rdNu.Checked = true;
                    }

                    txtDiaChi.DataBindings.Clear();
                    txtDiaChi.DataBindings.Add("Text", dt, "DiaChi");

                    txtDienThoai.DataBindings.Clear();
                    txtDienThoai.DataBindings.Add("Text", dt, "DienThoai");

                    String strSelect2 = "select * from Khoa";
                    DataTable dt2 = d.executeQuery(strSelect2);
                    cboKhoa.DataSource = dt2;
                    cboKhoa.DisplayMember = "MaKhoa";
                    cboKhoa.ValueMember = "MaKhoa";

                    cboKhoa.DataBindings.Clear();
                    cboKhoa.DataBindings.Add("Text", dt, "MaKhoa");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int nam = 1;
                if (rdNam.Checked)
                {
                    nam = 1;
                }
                if (rdNu.Checked)
                {
                    nam = 0;
                }
                if (txtHoTen.Text.Trim() == "" || txtDiaChi.Text.Trim() == "" || txtDienThoai.Text.Trim() == "")
                {
                    MessageBox.Show("Hãy nhập đầy đủ thông tin sinh viên");
                }
                else
                {
                    if (dtNgaySinh.Value >= DateTime.Now)
                    {
                        MessageBox.Show("Nhập sai ngày! Hãy nhập lại");
                    }
                    else
                    {
                        
                            String strUpdate = "UPDATE [dbo].[SinhVien]\r\n" +
                    "   SET [HoTen] = N'" + txtHoTen.Text + "'\r\n" +
                    "      ,[NgaySinh] = '" + dtNgaySinh.Value.ToString("yyyy/MM/dd") + "'\r\n" +
                    "      ,[GioiTinh] = " + nam + "\r\n" +
                    "      ,[DiaChi] = N'" + txtDiaChi.Text + "'\r\n" +
                    "      ,[DienThoai] = N'" + txtDienThoai.Text + "'\r\n" +
                    "      ,[MaKhoa] = '" + (String)cboKhoa.SelectedValue + "'\r\n" +
                    " WHERE MaSo = " + id;
                            if (d.executeNonQuery(strUpdate))
                            {
                                MessageBox.Show("Cập nhật thành công!");
                                LoadData();
                            }
                        }
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                String strDelete1= "DELETE FROM [dbo].[KetQua]\r\n" +
                    "      WHERE MaSo = " + id;
                String strDelete = "DELETE FROM [dbo].[SinhVien]\r\n" +
                    "      WHERE MaSo = " + id;
                DialogResult dr=MessageBox.Show("Bạn có muốn xóa Sinh viên này không? " + "\nChú ý: Xóa sinh viên sẽ xóa các điểm liên quan", "Thông báo", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    if (d.executeNonQuery(strDelete1) && d.executeNonQuery(strDelete))
                    {
                        MessageBox.Show("Xóa thành công");
                        this.Close();
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

    }
}
