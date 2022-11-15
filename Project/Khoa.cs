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
    public partial class Khoa : Form
    {
        public Khoa()
        {
            InitializeComponent();
        }

        private void Khoa_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        DataProvider d = new DataProvider();
        private void LoadData()
        {
            try
            {
                String strSelect = "select * from Khoa";
                DataTable dt = d.executeQuery(strSelect);
                dgMajor.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                String strSelect = "select * from Khoa where TenKhoa like N'%"+txtName.Text.Trim()+"%'";
                DataTable dt = d.executeQuery(strSelect);
                dgMajor.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgMajor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var id = dgMajor.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                new UpdateKhoa(id).ShowDialog();
            }
        }
    }
}
