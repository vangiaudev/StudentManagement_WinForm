using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DoAn2
{
    public partial class frmXuatDanhSachSinhVien : Form
    {
        public frmXuatDanhSachSinhVien()
        {
            InitializeComponent();
        }
        SqlConnection conn = null;
        string strConn = "Data Source=DESKTOP-0GQGB3U; Database=DemoQuanLyDoAnTotNghiep2; Integrated Security = True";
        private void frmXuatDanhSachSinhVien_Load(object sender, EventArgs e)
        {
            if (conn == null)
            {
                conn = new SqlConnection(strConn);
            }
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            string sql = "select MaSV, TenSV, MaLop from SinhVien";
            DataSet ds = new DataSet();
            SqlDataAdapter adapt = new SqlDataAdapter(sql, conn);
            adapt.Fill(ds);
            dgvXuatDanhSachSV.DataSource = ds.Tables[0];
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            try
            {
                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
                Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                worksheet = workbook.Sheets["Sheet1"];
                worksheet = workbook.ActiveSheet;
                app.Visible = true;
                //Đổ DL vào sheet
                worksheet.Cells[1, 3] = "BẢNG TỔNG HỢP DANH SÁCH SINH VIÊN";
                worksheet.Cells[3, 1] = "STT";
                worksheet.Cells[3, 2] = "Mã Sinh Viên";
                worksheet.Cells[3, 3] = "Tên Sinh Viên";
                worksheet.Cells[3, 4] = "Mã Lớp";

                for (int i = 0; i < dgvXuatDanhSachSV.RowCount - 1; i++)
                {
                    for (int j = 0; j < 3; ++j)
                    {
                        worksheet.Cells[i + 4, 1] = i + 1;
                        worksheet.Cells[i + 4, j + 2] = dgvXuatDanhSachSV.Rows[i].Cells[j].Value;

                    }
                }
                //Dinh dang Excel
                worksheet.Range["A1"].ColumnWidth = 8.25;
                worksheet.Range["B1"].ColumnWidth = 16.5;
                worksheet.Range["C1"].ColumnWidth = 30.5;
                worksheet.Range["D1"].ColumnWidth = 16.5;
                //Dinh dang font
                worksheet.Range["A1", "G100"].Font.Name = "Times New Roman";
                worksheet.Range["A1", "G100"].Font.Size = 12;
                worksheet.Range["A1", "D1"].MergeCells = true;
                worksheet.Range["A1", "D1"].Font.Bold = true;
                worksheet.Range["A3", "D3"].Font.Bold = true;
                //Ke bang
                worksheet.Range["A3", "D" + (dgvXuatDanhSachSV.RowCount + 2)].Borders.LineStyle = 1;
                worksheet.Range["A1", "D1"].HorizontalAlignment = 3;
            }
            catch (Exception)
            {

                MessageBox.Show("Xuất File Thành Công !");
            }
        }
    }
}
