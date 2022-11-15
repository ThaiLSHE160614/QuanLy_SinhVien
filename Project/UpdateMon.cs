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
    public partial class UpdateMon : Form
    {
        public UpdateMon(String id)
        {
            this.id = id;
            InitializeComponent();
        }
        private String id;
        DataProvider d = new DataProvider();
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                String strUpdate = "update Mon set TenMH = N'" + txtName.Text.Trim() + "', SoTiet = " + nboSoTiet.Text.Trim() + " where MaMH = '" + id + "'";
                if (d.executeNonQuery(strUpdate))
                {
                    MessageBox.Show("Cập nhật thành công");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void UpdateMon_Load(object sender, EventArgs e)
        {
            try
            {
                String strSelect = "select * from Mon where MaMH like '" + id + "'";
                DataTable dt = d.executeQuery(strSelect);
                txtMaMon.DataBindings.Clear();
                txtMaMon.DataBindings.Add("Text", dt, "MaMH");

                txtName.DataBindings.Clear();
                txtName.DataBindings.Add("Text", dt, "TenMH");

                nboSoTiet.DataBindings.Clear();
                nboSoTiet.DataBindings.Add("Text", dt, "SoTiet");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi: "+ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                String strDelete1 = "delete from KetQua where MaMH = '" + id + "'";
                String strDelete = "delete from Mon where MaMH = '"+id+"'";
                DialogResult dr = MessageBox.Show("Bạn có muốn xóa môn này không? " + "\nChú ý: Xóa môn sẽ xóa các điểm liên quan", "Thông báo", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    if (d.executeNonQuery(strDelete1) && d.executeNonQuery(strDelete))
                    {
                        MessageBox.Show("Xóa thành công");
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
