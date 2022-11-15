using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataTable = System.Data.DataTable;

namespace Project
{
    public partial class Sinhvien : Form
    {
        public Sinhvien()
        {
            InitializeComponent();
        }

        private void dgStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var id = dgStudent.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                new UpdateSinhVien(id).ShowDialog();
            }
        }
        private void Sinhvien_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        DataProvider d = new DataProvider();
        private void LoadData()
        {
            try
            {
                String strSelect = "select MaSo, HoTen, NgaySinh, (CASE when GioiTinh = 1 then 'Nam' else N'Nữ' END) as GioiTinh, DiaChi, DienThoai, MaKhoa\r\n" +
                    "from SinhVien";
                DataTable dt = d.executeQuery(strSelect);

                dgStudent.DataSource = dt;
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
                String strSelect = "select MaSo, HoTen, NgaySinh, (CASE when GioiTinh = 1 then 'Nam' else N'Nữ' END) as GioiTinh, DiaChi, DienThoai, MaKhoa\r\n" +
                    "from SinhVien where HoTen LIKE N'%" + txtName.Text.Trim() + "%'";
                DataTable dt = d.executeQuery(strSelect);
                dgStudent.DataSource = dt;

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
        private String fileName = "";
        private void btnExport_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx" })
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    fileName = saveFileDialog.FileName;
                    Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
                    Workbook wb = excel.Workbooks.Add(XlSheetType.xlWorksheet);
                    Worksheet ws = (Worksheet)excel.ActiveSheet;
                    excel.Visible = false;

                    ws.Cells[1, 1] = "Mã Số";
                    ws.Cells[1, 2] = "Họ và Tên";
                    ws.Cells[1, 3] = "Ngày sinh";
                    ws.Cells[1, 4] = "Giới tính";
                    ws.Cells[1, 5] = "Địa chỉ";
                    ws.Cells[1, 6] = "Số điện thoại";
                    ws.Cells[1, 7] = "Mã Khoa";

                    for (int i = 0; i < dgStudent.Rows.Count - 1; i++)
                    {
                        for (int j = 0; j < dgStudent.Columns.Count; j++)
                        {
                            ws.Cells[i + 2, j + 1] = dgStudent.Rows[i].Cells[j].Value.ToString();
                        }
                    }

                    ws.SaveAs(fileName, XlFileFormat.xlWorkbookDefault, Type.Missing, Type.Missing, true, false, XlSaveAsAccessMode.xlNoChange, XlSaveConflictResolution.xlLocalSessionChanges, Type.Missing, Type.Missing);
                    excel.Quit();
                    MessageBox.Show("Xuất file thành công");
                }


            }


        }
    }
}
