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
    public partial class frmGiangVien : Form
    {
        public frmGiangVien()
        {
            InitializeComponent();
        }
        DataTable TB = new DataTable();
        SqlConnection conn = null;
        string strConn = "Data Source=DESKTOP-0GQGB3U; Database=DemoQuanLyDoAnTotNghiep2; Integrated Security = True";
        private void frmGiangVien_Load(object sender, EventArgs e)
        {
            LoadDuLieuLenListView();
            loadDuLieuMaBoMonLenComboBox();
        }
        private void LoadDuLieuLenListView()
        {
            if(conn == null)
            {
                conn = new SqlConnection(strConn);
            }
            if(conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from GiaoVien";
            cmd.Connection = conn;
            SqlDataReader reader = cmd.ExecuteReader();
            lvThongTinGiangVien.Items.Clear();
            int i = 0;
            while (reader.Read())
            {
                lvThongTinGiangVien.Items.Add((i+1).ToString());
                lvThongTinGiangVien.Items[i].SubItems.Add(reader[0].ToString());
                lvThongTinGiangVien.Items[i].SubItems.Add(reader[1].ToString());
                lvThongTinGiangVien.Items[i].SubItems.Add(reader[2].ToString());
                i++;
            }
            reader.Close();
            
        }
        private void loadDuLieuMaBoMonLenComboBox()
        {
            string s = "Data Source=DESKTOP-0GQGB3U; Database=DemoQuanLyDoAnTotNghiep2; Integrated Security = True";
            SqlConnection CON = new SqlConnection();
            CON.ConnectionString = strConn;
            try
            {
                CON.Open();
                s = "select * from BoMon";
                SqlCommand CMD = new SqlCommand(s, CON);
                SqlDataAdapter Adapt = new SqlDataAdapter(CMD);
                Adapt.Fill(TB);
                foreach (DataRow r in TB.Rows)
                {
                    s = r[0].ToString();
                    cbMaBoMon.Items.Add(s);
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
        private void lvThongTinGiangVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvThongTinGiangVien.SelectedItems.Count == 0) return;
            ListViewItem lvi = lvThongTinGiangVien.SelectedItems[0];
            txtMaGV.Text = lvi.SubItems[1].Text;
            txtTenGV.Text = lvi.SubItems[2].Text;
            cbMaBoMon.Text = lvi.SubItems[3].Text;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn == null)
                {
                    conn = new SqlConnection(strConn);
                }
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into GiaoVien(MaGV, TenGV, MaBoMon) values (@MaGV, @TenGV, @MaBoMon)";
                cmd.Connection = conn;
                cmd.Parameters.Add("@MaGV", SqlDbType.VarChar).Value = txtMaGV.Text;
                cmd.Parameters.Add("@TenGV", SqlDbType.NVarChar).Value = txtTenGV.Text;
                cmd.Parameters.Add("@MaBoMon", SqlDbType.VarChar).Value = cbMaBoMon.Text;
                int ret = cmd.ExecuteNonQuery();
                if (ret > 0)
                {
                    LoadDuLieuLenListView();
                    MessageBox.Show("Thêm Thành Công");
                }
                else
                {
                    MessageBox.Show("Thêm Thất Bại");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Lỗi Kết Nối");
            }
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

            try
            {
                if (lvThongTinGiangVien.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Bạn chưa chọn đối tượng cần sửa");
                    return;
                }
                if (conn == null)
                {
                    conn = new SqlConnection();
                }
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                ListViewItem lvi = lvThongTinGiangVien.SelectedItems[0];
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                string sql = "update GiaoVien " +
                    "set MaGV = @MaGV, TenGV = @TenGV, MaBoMon = @MaBoMon " + 
                    "where MaGV = " + "\'" + lvi.SubItems[1].Text + "\'";
                command.CommandText = sql;
                command.Connection = conn;
                command.Parameters.Add("@MaGV", SqlDbType.VarChar).Value = txtMaGV.Text;
                command.Parameters.Add("@TenGV", SqlDbType.NVarChar).Value = txtTenGV.Text;
                command.Parameters.Add("@MaBoMon", SqlDbType.VarChar).Value = cbMaBoMon.Text;
                int ret = command.ExecuteNonQuery();

                if (ret > 0)
                {
                    LoadDuLieuLenListView();
                    MessageBox.Show("Sửa Thông Tin Thành Công");
                    txtMaGV.Text = "";
                    txtTenGV.Text = "";
                    cbMaBoMon.Text = "";
                }
                else
                {
                    MessageBox.Show("Sửa Thông Tin Thất Bại");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Lỗi kết nối");
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult kt = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kt == DialogResult.Yes)
            {
                if (lvThongTinGiangVien.SelectedItems.Count == -1)
                {
                    MessageBox.Show("Bạn chưa chọn đối tượng để xóa");
                    return;
                }
                if (conn == null)
                {
                    conn = new SqlConnection();
                }
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from GiaoVien where MaGV = @MaGV";
                cmd.Connection = conn;

                cmd.Parameters.Add("MaGV", SqlDbType.VarChar).Value = txtMaGV.Text;
                int ret = cmd.ExecuteNonQuery();
                if (ret > 0)
                {
                    LoadDuLieuLenListView();
                    MessageBox.Show("Xóa Thành Công");
                    txtMaGV.Text = "";
                    txtTenGV.Text = "";
                    cbMaBoMon.Text = "";
                }
                else
                {
                    MessageBox.Show("Xóa Thất Bại");
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            LoadDuLieuLenListView();
            txtMaGV.Text = "";
            txtTenGV.Text = "";
            cbMaBoMon.Text = "";
        }

        private void btnTimKiemGV_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTimKiemGV.Text != "")
                {
                    if (cbTimKiemGV.Text == "Tìm Theo Mã Giảng Viên")
                    {
                        if (conn == null)
                        {
                            conn = new SqlConnection();
                        }
                        if (conn.State == ConnectionState.Closed)
                        {
                            conn.Open();
                        }
                        SqlCommand com = new SqlCommand();
                        com.CommandType = CommandType.Text;
                        com.CommandText = "select * from GiaoVien where MaGV = '" + txtTimKiemGV.Text + "'";
                        com.Connection = conn;

                        SqlDataReader reader = com.ExecuteReader();
                        lvThongTinGiangVien.Items.Clear();
                        int i = 0;
                        while (reader.Read())
                        {
                            lvThongTinGiangVien.Items.Add((i + 1).ToString());
                            lvThongTinGiangVien.Items[i].SubItems.Add(reader[0].ToString());
                            lvThongTinGiangVien.Items[i].SubItems.Add(reader[1].ToString());
                            lvThongTinGiangVien.Items[i].SubItems.Add(reader[2].ToString());
                        }
                        reader.Close();
                    }
                    else if (cbTimKiemGV.Text == "Tìm Theo Tên Giảng Viên")
                    {

                        if (conn == null)
                        {
                            conn = new SqlConnection();
                        }
                        if (conn.State == ConnectionState.Closed)
                        {
                            conn.Open();
                        }
                        SqlCommand com = new SqlCommand();
                        com.CommandType = CommandType.Text;
                        com.CommandText = "select * from GiaoVien where TenGV = N'" + txtTimKiemGV.Text + "'";
                        com.Connection = conn;

                        SqlDataReader reader = com.ExecuteReader();
                        lvThongTinGiangVien.Items.Clear();
                        int i = 0;
                        while (reader.Read())
                        {
                            lvThongTinGiangVien.Items.Add((i + 1).ToString());
                            lvThongTinGiangVien.Items[i].SubItems.Add(reader[0].ToString());
                            lvThongTinGiangVien.Items[i].SubItems.Add(reader[1].ToString());
                            lvThongTinGiangVien.Items[i].SubItems.Add(reader[2].ToString());
                        }
                        reader.Close();
                    }
                    else
                        MessageBox.Show("Vui Lòng Chọn Tìm Theo Mã Giảng Viên Hoặc Theo Tên Giảng Viên");
                }
                else
                    MessageBox.Show("Hãy Nhập Từ Khóa Cần Tìm !");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.Message);
            }
        }

        private void cbMaBoMon_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
