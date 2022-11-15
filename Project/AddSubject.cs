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
    public partial class AddSubject : Form
    {
        public AddSubject()
        {
            InitializeComponent();
        }
        DataProvider d= new DataProvider();
        private bool checkMaMH(String id)
        {
            try
            {
                String strSelect = "select * from Mon where MaMH = '"+id+"'";
                DataTable dt= d.executeQuery(strSelect);
                if (dt.Rows.Count == 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
                return false;
            }
        }
        private void btnAddSubject_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaMH.Text.Trim() == "" || txtTenMH.Text.Trim() == "")
                {
                    MessageBox.Show("Hãy nhập đầy đủ thông tin");
                }
                else
                {
                    if(nboSoTiet.Value <= 0)
                    {
                        MessageBox.Show("Số tiết phải lớn hơn 0");
                    }
                    else
                    {
                        String sqlAdd = "INSERT INTO [dbo].[Mon]\r\n" +
                            "           ([MaMH]\r\n" +
                            "           ,[TenMH]\r\n" +
                            "           ,[SoTiet])\r\n" +
                            "     VALUES\r\n" +
                            "           ('"+txtMaMH.Text.Trim()+"', N'"+txtTenMH.Text.Trim()+"', "+nboSoTiet.Value+")";
                        if (d.executeNonQuery(sqlAdd))
                        {
                            MessageBox.Show("Thêm môn mới thành công");
                            txtMaMH.Clear();
                            txtTenMH.Clear();
                            nboSoTiet.Value = 0;
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
