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
    public partial class AddStudent : Form
    {
        DataProvider d = new DataProvider();
        public AddStudent()
        {
            InitializeComponent();
        }

        private bool checkMaSo(String id)
        {
            try
            {
                String strCheck = "select * from SinhVien where MaSo = '" + id + "'";
                DataTable dt = d.executeQuery(strCheck);
                if (dt.Rows.Count == 0|| dt.Rows.Count == null)
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

        private void btnAddStudent_Click(object sender, EventArgs e)
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
                if (txtMaSo.Text.Trim() == "" || txtHoTen.Text.Trim() == "" || txtDiaChi.Text.Trim() == "" || txtDienThoai.Text.Trim() == "")
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
                        if (checkMaSo(txtMaSo.Text.Trim()))
                        {
                            MessageBox.Show("Mã số sinh viên đã tồn tại");
                        }
                        else
                        {
                            String strAdd = "INSERT INTO [dbo].[SinhVien]\r\n" +
                                "           ([MaSo]\r\n" +
                                "           ,[HoTen]\r\n" +
                                "           ,[NgaySinh]\r\n" +
                                "           ,[GioiTinh]\r\n" +
                                "           ,[DiaChi]\r\n" +
                                "           ,[DienThoai]\r\n" +
                                "           ,[MaKhoa])\r\n" +
                                "     VALUES\r\n" +
                                "           ('" + txtMaSo.Text.Trim() + "', N'" + txtHoTen.Text.Trim() + "', '" + dtNgaySinh.Value.ToString("yyyy/MM/dd") + "', " + nam + ", N'" + txtDiaChi.Text.Trim() + "', '" + txtDienThoai.Text.Trim() + "', '" + (String)cboKhoa.SelectedValue + "')";
                            if (d.executeNonQuery(strAdd))
                            {
                                MessageBox.Show("Thêm Sinh viên thành công!");
                                LoadData();
                            }
                        }
                    }
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void AddStudent_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        
        private void LoadData()
        {
            try
            {
                String strSelect = "select * from Khoa";
                DataTable dt = d.executeQuery(strSelect);
                cboKhoa.DataSource = dt;
                cboKhoa.DisplayMember = "TenKhoa";
                cboKhoa.ValueMember = "MaKhoa";
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);              
            }
        }


    }
}
