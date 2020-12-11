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
    public partial class frmBoMon : Form
    {
        public frmBoMon()
        {
            InitializeComponent();
        }
        DataTable TB = new DataTable();
        SqlConnection conn = null;
        string strConn = "Data Source=DESKTOP-0GQGB3U; Database=DemoQuanLyDoAnTotNghiep2; Integrated Security = True";
        private void frmBoMon_Load(object sender, EventArgs e)
        {
            LoadDuLieu();
            loadDuLieuMaKhoaComboBox();
        }
        private void LoadDuLieu()
        {
            if (conn == null)
            {
                conn = new SqlConnection(strConn);
            }
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlCommand cm = new SqlCommand();
            cm.CommandType = CommandType.Text;
            cm.CommandText = "select * from BoMon";
            cm.Connection = conn;

            SqlDataReader reader = cm.ExecuteReader();
            lvThongTinBoMon.Items.Clear();
            int i = 0;
            while (reader.Read())
            {
                lvThongTinBoMon.Items.Add((i + 1).ToString());
                lvThongTinBoMon.Items[i].SubItems.Add(reader[0].ToString());
                lvThongTinBoMon.Items[i].SubItems.Add(reader[1].ToString());
                lvThongTinBoMon.Items[i].SubItems.Add(reader[2].ToString());
                
                i++;
            }
            reader.Close();
        }

        private void lvThongTinBoMon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvThongTinBoMon.SelectedItems.Count == 0) return;
            ListViewItem lvi = lvThongTinBoMon.SelectedItems[0];

            txtMaBoMon.Text = lvi.SubItems[1].Text;
            txtTenBoMon.Text = lvi.SubItems[2].Text;
            cbKhoa.Text = lvi.SubItems[3].Text;
            
        }
        private void loadDuLieuMaKhoaComboBox()
        {
            string s = "Data Source=DESKTOP-0GQGB3U; Database=DemoQuanLyDoAnTotNghiep2; Integrated Security = True";
            SqlConnection CON = new SqlConnection();
            CON.ConnectionString = s;
            try
            {
                CON.Open();
                s = "select * from Khoa";
                SqlCommand CMD = new SqlCommand(s, CON);
                SqlDataAdapter Adapt = new SqlDataAdapter(CMD);
                Adapt.Fill(TB);
                foreach (DataRow r in TB.Rows)
                {
                    s = r[0].ToString();
                    cbKhoa.Items.Add(s);
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

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaBoMon.Text == "" || txtTenBoMon.Text == "" || cbKhoa.SelectedIndex == -1)
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                }
                else
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
                    string sql = "insert into BoMon(MaBoMon, TenBoMon, MaKhoa) values ('" + txtMaBoMon.Text + "', N'" + txtTenBoMon.Text + "', '" + cbKhoa.Text + "')";
                    command.CommandText = sql;
                    command.Connection = conn;
                    int ret1 = command.ExecuteNonQuery();
                    if (ret1 > 0)
                    {
                        LoadDuLieu();
                        MessageBox.Show("Thêm Thành Công");
                    }
                    else
                    {
                        MessageBox.Show("Thêm Thất Bại!");
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi Kết Nối");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult kt = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (kt == DialogResult.Yes)
            {
                if (lvThongTinBoMon.SelectedItems.Count == -1)
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
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "delete from BoMon where MaBoMon = '" + txtMaBoMon.Text + "'";
                command.Connection = conn;
                int ret = command.ExecuteNonQuery();
                if (ret > 0)
                {
                    LoadDuLieu();
                    MessageBox.Show("Đã xóa thành công");
                    txtMaBoMon.Text = "";
                    txtTenBoMon.Text = "";
                    cbKhoa.Text = "";
                }
                else
                {
                    MessageBox.Show("Xóa thất bại");
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (lvThongTinBoMon.SelectedItems.Count == 0)
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
                ListViewItem lvi = lvThongTinBoMon.SelectedItems[0];
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
            
                command.CommandText = "update BoMon set MaBoMon = @MaBoMon, TenBoMon = @TenBoMon, MaKhoa = @MaKhoa where MaBoMon = " + "\'" + lvi.SubItems[1].Text + "\'";
                command.Connection = conn;

                command.Parameters.Add("@MaBoMon", SqlDbType.VarChar).Value = txtMaBoMon.Text;
                command.Parameters.Add("@TenBoMon", SqlDbType.NVarChar).Value = txtTenBoMon.Text;
                command.Parameters.Add("@MaKhoa", SqlDbType.VarChar).Value = cbKhoa.Text;
                int ret = command.ExecuteNonQuery();
            
                if (ret > 0)
                {
                    LoadDuLieu();
                    MessageBox.Show("Sửa Thông Tin Thành Công");
                    txtMaBoMon.Text = "";
                    txtTenBoMon.Text = "";
                    cbKhoa.Text = "";
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

        private void btnHuy_Click(object sender, EventArgs e)
        {
            LoadDuLieu();
            txtMaBoMon.Text = "";
            txtTenBoMon.Text = "";
            cbKhoa.Text = "";

        }
    }
}
