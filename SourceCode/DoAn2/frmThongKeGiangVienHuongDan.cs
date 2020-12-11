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
    public partial class frmThongKeGiangVienHuongDan : Form
    {
        public frmThongKeGiangVienHuongDan()
        {
            InitializeComponent();
        }
        DataTable TB2 = new DataTable();
        SqlConnection conn = null;
        string strConn = "Data Source=DESKTOP-0GQGB3U; Database=DemoQuanLyDoAnTotNghiep2; Integrated Security = True";
        private void HienThiDuLieuLenListView()
        {
            if (conn == null)
            {
                conn = new SqlConnection(strConn);
            }
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select SinhVien.MaSV, SinhVien.TenSV, GiaoVien.MaGV, GiaoVien.TenGV, DoAn.TenDoAn " +
                " from DoAn, SinhVien, GiaoVien " +
                " where DoAn.MaSV =SinhVien.MaSV and DoAn.MaGV = GiaoVien.MaGV";
            command.Connection = conn;

            SqlDataReader reader = command.ExecuteReader();

            lvDanhSachGiangVienHuongDan.Items.Clear();
            int i = 0;
            while (reader.Read())
            {
                lvDanhSachGiangVienHuongDan.Items.Add((i + 1).ToString());
                lvDanhSachGiangVienHuongDan.Items[i].SubItems.Add(reader[0].ToString());
                lvDanhSachGiangVienHuongDan.Items[i].SubItems.Add(reader[4].ToString());
                lvDanhSachGiangVienHuongDan.Items[i].SubItems.Add(reader[1].ToString());
                lvDanhSachGiangVienHuongDan.Items[i].SubItems.Add(reader[2].ToString());
                lvDanhSachGiangVienHuongDan.Items[i].SubItems.Add(reader[3].ToString());
                i++;
            }
            reader.Close();
        }
        private void loadDuLieuMaGVComboBox()
        {
            string s = "Data Source=DESKTOP-0GQGB3U; Database=DemoQuanLyDoAnTotNghiep2; Integrated Security = True";
            SqlConnection CON = new SqlConnection();
            CON.ConnectionString = s;
            try
            {
                CON.Open();
                s = "select * from GiaoVien";
                SqlCommand CMD = new SqlCommand(s, CON);
                SqlDataAdapter Adapt = new SqlDataAdapter(CMD);
                Adapt.Fill(TB2);
                foreach (DataRow r in TB2.Rows)
                {
                    s = r[0].ToString();
                    cbMaGiangVien.Items.Add(s);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi");
            }
            finally
            {
                CON.Close();
            }
        }

        private void frmThongKeGiangVienHuongDan_Load(object sender, EventArgs e)
        {
            HienThiDuLieuLenListView();
            loadDuLieuMaGVComboBox();
        }

        private void lvDanhSachGiangVienHuongDan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnLocDL_Click(object sender, EventArgs e)
        {
            if (conn == null)
            {
                conn = new SqlConnection(strConn);
            }
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = "select SinhVien.MaSV, SinhVien.TenSV, GiaoVien.MaGV, GiaoVien.TenGV, DoAn.TenDoAn " +
                " from DoAn, SinhVien, GiaoVien " +
                " where DoAn.MaGV = '" + cbMaGiangVien.Text + "' and GiaoVien.MaGV = DoAn.MaGV and SinhVien.MaSV = DoAn.MaSV";
            com.Connection = conn;

            SqlDataReader reader = com.ExecuteReader();
            lvDanhSachGiangVienHuongDan.Items.Clear();
            int i = 0;
            while (reader.Read())
            {
                lvDanhSachGiangVienHuongDan.Items.Add((i + 1).ToString());
                lvDanhSachGiangVienHuongDan.Items[i].SubItems.Add(reader[0].ToString());
                lvDanhSachGiangVienHuongDan.Items[i].SubItems.Add(reader[4].ToString());
                lvDanhSachGiangVienHuongDan.Items[i].SubItems.Add(reader[1].ToString());
                lvDanhSachGiangVienHuongDan.Items[i].SubItems.Add(reader[2].ToString());
                lvDanhSachGiangVienHuongDan.Items[i].SubItems.Add(reader[3].ToString());
                i++;
            }
            reader.Close();
        }
    }
}
