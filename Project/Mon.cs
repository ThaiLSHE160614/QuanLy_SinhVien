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
    public partial class Mon : Form
    {
        public Mon()
        {
            InitializeComponent();
        }

        private void Mon_Load(object sender, EventArgs e)
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
                dgSubject.DataSource = dt;

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
                String strSelect = "select * from Mon where TenMH like N'%"+txtName.Text.Trim()+"%'";
                DataTable dt = d.executeQuery(strSelect);
                dgSubject.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex);
            }
        }

        private void dgSubject_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var id= dgSubject.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
            new UpdateMon(id).ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
