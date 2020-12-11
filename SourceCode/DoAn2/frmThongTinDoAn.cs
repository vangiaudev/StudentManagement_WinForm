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
using System.IO;

namespace DoAn2
{
    public partial class frmThongTinDoAn : Form
    {
        public frmThongTinDoAn()
        {
            InitializeComponent();
        }
        DataTable TB = new DataTable();
        DataTable TB2 = new DataTable();
        SqlConnection conn = null;
        string strConn = "Data Source=DESKTOP-0GQGB3U; Database=DemoQuanLyDoAnTotNghiep2; Integrated Security = True";
        private void frmThongTinDoAn_Load(object sender, EventArgs e)
        {
            LoadDuLieu();
            loadDuLieuMaSVComboBox();
            loadDuLieuMaGVComboBox();
        }
        private void KiemTraKetNoiServer()
        {
            if (conn == null)
            {
                conn = new SqlConnection(strConn);
            }
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }
        private void LoadDuLieu()
        {
            KiemTraKetNoiServer();
            SqlCommand cm = new SqlCommand();
            cm.CommandType = CommandType.Text;
            cm.CommandText = "select * from DoAn";
            cm.Connection = conn;

            SqlDataReader reader = cm.ExecuteReader();
            lvDoAn.Items.Clear();
            int i = 0;
            while (reader.Read())
            {
                lvDoAn.Items.Add((i + 1).ToString());
                lvDoAn.Items[i].SubItems.Add(reader[0].ToString());
                lvDoAn.Items[i].SubItems.Add(reader[1].ToString());
                lvDoAn.Items[i].SubItems.Add(reader[2].ToString());
                lvDoAn.Items[i].SubItems.Add(reader[3].ToString());
                lvDoAn.Items[i].SubItems.Add(reader[4].ToString());
                lvDoAn.Items[i].SubItems.Add(reader[5].ToString());
                i++;
            }
            reader.Close();
        }

        private void lvDoAn_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvDoAn.SelectedItems.Count == 0) return;
            ListViewItem lvi = lvDoAn.SelectedItems[0];

            txtMaDoAn.Text = lvi.SubItems[1].Text;
            txtTenDoAn.Text = lvi.SubItems[2].Text;
            rtxtTomTatNoiDung.Text = lvi.SubItems[3].Text;
            txtTuKhoa.Text = lvi.SubItems[4].Text;
            cbMaSV.Text = lvi.SubItems[5].Text;
            cbMaGV.Text = lvi.SubItems[6].Text;
        }

        private void btnThem1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaDoAn.Text == "" || txtTenDoAn.Text == "" || txtTuKhoa.Text == "" || cbMaSV.SelectedIndex == -1 || cbMaGV.SelectedIndex == -1)
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                }
                else
                {
                    KiemTraKetNoiServer();
                    SqlCommand command = new SqlCommand();
                    command.CommandType = CommandType.Text;
                    string sql = "insert into DoAn(MaDoAn, TenDoAn, TomTatNoiDung, TuKhoa, MaSV, MaGV) values ('" + txtMaDoAn.Text + "', N'" + txtTenDoAn.Text + "', N'" + rtxtTomTatNoiDung.Text + "', '" + txtTuKhoa.Text + "', '" + cbMaSV.Text + "', '" + cbMaGV.Text + "')";
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

        private void loadDuLieuMaSVComboBox()
        {
            string str = "Data Source=DESKTOP-0GQGB3U; Database=DemoQuanLyDoAnTotNghiep2; Integrated Security = True";
            SqlConnection CON = new SqlConnection();
            CON.ConnectionString = str;
            try
            {
                CON.Open();
                str = "select * from SinhVien";
                SqlCommand CMD = new SqlCommand(str, CON);
                SqlDataAdapter Adapt = new SqlDataAdapter(CMD);
                Adapt.Fill(TB);
                foreach (DataRow r in TB.Rows)
                {
                    str = r[0].ToString();
                    cbMaSV.Items.Add(str);
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
                    cbMaGV.Items.Add(s);
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

        private void btnSua1_Click(object sender, EventArgs e)
        {
            try
            {
                if (lvDoAn.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Bạn chưa chọn đối tượng cần sửa");
                    return;
                }
                else
                {
                    ListViewItem lvi = lvDoAn.SelectedItems[0];
                    KiemTraKetNoiServer();
                    SqlCommand command = new SqlCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText = "update DoAn " +
                                          "set MaDoAn = @MaDoAn, TenDoAn = @TenDoAn, TomTatNoiDung = @TomTatNoiDung, TuKhoa = @TuKhoa, MaSV = @MaSV, MaGV = @MaGV " +
                                          "where MaDoAn = " + "\'" + lvi.SubItems[1].Text + "\'";
                    command.Connection = conn;
                    command.Parameters.Add("@MaDoAn", SqlDbType.VarChar).Value = txtMaDoAn.Text;
                    command.Parameters.Add("@TenDoAn", SqlDbType.NVarChar).Value = txtTenDoAn.Text;
                    command.Parameters.Add("@TomTatNoiDung", SqlDbType.NVarChar).Value = rtxtTomTatNoiDung.Text;
                    command.Parameters.Add("@TuKhoa", SqlDbType.VarChar).Value = txtTuKhoa.Text;
                    command.Parameters.Add("@MaSV", SqlDbType.VarChar).Value = cbMaSV.Text;
                    command.Parameters.Add("@MaGV", SqlDbType.VarChar).Value = cbMaGV.Text;
                    int ret = command.ExecuteNonQuery();
                    if (ret > 0)
                    {
                        LoadDuLieu();
                        MessageBox.Show("Sửa Thông Tin Thành Công");
                        txtMaDoAn.Text = "";
                        txtTenDoAn.Text = "";
                        txtTuKhoa.Text = "";
                        rtxtTomTatNoiDung.Text = "";
                        cbMaSV.Text = "";
                        cbMaGV.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Sửa Thông Tin Thất Bại");
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi kết nối");
            }
        }

        private void btnXoa1_Click(object sender, EventArgs e)
        {
            DialogResult kt = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (kt == DialogResult.Yes)
            {
                if (lvDoAn.SelectedItems.Count == -1)
                {
                    MessageBox.Show("Bạn chưa chọn đối tượng để xóa");
                    return;
                }
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
                command.CommandText = "delete from DoAn where MaDoAn = '" + txtMaDoAn.Text + "'";
                command.Connection = conn;
                int ret = command.ExecuteNonQuery();
                if (ret > 0)
                {
                    LoadDuLieu();
                    MessageBox.Show("Đã xóa thành công");
                    txtMaDoAn.Text = "";
                    txtTenDoAn.Text = "";
                    txtTuKhoa.Text = "";
                    rtxtTomTatNoiDung.Text = "";
                    cbMaSV.Text = "";
                    cbMaGV.Text = "";
                }
                else
                {
                    MessageBox.Show("Xóa thất bại");
                }
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTimKiem.Text != "")
                {
                    if (cbTimKiem.Text == "Tìm Theo Mã Đồ Án")
                    {
                        KiemTraKetNoiServer();

                        SqlCommand com = new SqlCommand();
                        com.CommandType = CommandType.Text;
                        com.CommandText = "select * from DoAn where MaDoAn = '" + txtTimKiem.Text + "'";
                        com.Connection = conn;

                        SqlDataReader reader = com.ExecuteReader();
                        lvDoAn.Items.Clear();
                        int i = 0;
                        while (reader.Read())
                        {
                            lvDoAn.Items.Add((i + 1).ToString());
                            lvDoAn.Items[i].SubItems.Add(reader[0].ToString());
                            lvDoAn.Items[i].SubItems.Add(reader[1].ToString());
                            lvDoAn.Items[i].SubItems.Add(reader[2].ToString());
                            lvDoAn.Items[i].SubItems.Add(reader[3].ToString());
                            lvDoAn.Items[i].SubItems.Add(reader[4].ToString());
                            lvDoAn.Items[i].SubItems.Add(reader[5].ToString());
                        }
                        reader.Close();
                    }
                    else if (cbTimKiem.Text == "Tìm Theo Tên Đồ Án")
                    {

                        KiemTraKetNoiServer();
                        
                        SqlCommand com = new SqlCommand();
                        com.CommandType = CommandType.Text;
                        com.CommandText = "select * from DoAn where TenDoAn = N'" + txtTimKiem.Text + "'";
                        com.Connection = conn;

                        SqlDataReader reader = com.ExecuteReader();
                        lvDoAn.Items.Clear();
                        int i = 0;
                        while (reader.Read())
                        {
                            lvDoAn.Items.Add((i + 1).ToString());
                            lvDoAn.Items[i].SubItems.Add(reader[0].ToString());
                            lvDoAn.Items[i].SubItems.Add(reader[1].ToString());
                            lvDoAn.Items[i].SubItems.Add(reader[2].ToString());
                            lvDoAn.Items[i].SubItems.Add(reader[3].ToString());
                            lvDoAn.Items[i].SubItems.Add(reader[4].ToString());
                            lvDoAn.Items[i].SubItems.Add(reader[5].ToString());
                        }
                        reader.Close();
                    }
                    else if (cbTimKiem.Text == "Tìm Theo Từ Khóa")
                    {
                        KiemTraKetNoiServer();

                        SqlCommand com = new SqlCommand();
                        com.CommandType = CommandType.Text;
                        com.CommandText = "select * from DoAn where TuKhoa = '" + txtTimKiem.Text + "'";
                        com.Connection = conn;

                        SqlDataReader reader = com.ExecuteReader();
                        lvDoAn.Items.Clear();
                        int i = 0;
                        while (reader.Read())
                        {
                            lvDoAn.Items.Add((i + 1).ToString());
                            lvDoAn.Items[i].SubItems.Add(reader[0].ToString());
                            lvDoAn.Items[i].SubItems.Add(reader[1].ToString());
                            lvDoAn.Items[i].SubItems.Add(reader[2].ToString());
                            lvDoAn.Items[i].SubItems.Add(reader[3].ToString());
                            lvDoAn.Items[i].SubItems.Add(reader[4].ToString());
                            lvDoAn.Items[i].SubItems.Add(reader[5].ToString());
                        }
                        reader.Close();
                    }
                    else
                        MessageBox.Show("Vui Lòng Chọn Tìm Theo Mã Đồ Án, Tên Đồ Án Hoặc Từ Khóa");
                }
                else
                    MessageBox.Show("Hãy Nhập Từ Khóa Cần Tìm!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.Message);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadDuLieu();
            txtMaDoAn.Text = "";
            txtTenDoAn.Text = "";
            txtTuKhoa.Text = "";
            rtxtTomTatNoiDung.Text = "";
            cbMaSV.Text = "";
            cbMaGV.Text = "";

        }

        private void txtTenDoAn_TextChanged(object sender, EventArgs e)
        {

        }

        private void rtxtTomTatNoiDung_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMaDoAn_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTuKhoa_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbMaSV_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbMaGV_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSaveAs_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaDoAn.Text != "")
                {
                    SaveFileDialog dlg = new SaveFileDialog();
                    dlg.Filter = "file *.txt|*.txt";
                    if (dlg.ShowDialog() == DialogResult.OK)
                    {
                        FileStream fs = new FileStream(dlg.FileName, FileMode.OpenOrCreate, FileAccess.Write);
                        StreamWriter sw = new StreamWriter(fs);
                        sw.Write("-----------Thông Tin Đồ Án: " + txtTenDoAn.Text + "        -----------\r\n");
                        sw.Write("-----------Mã Đồ Án     : " + txtMaDoAn.Text + "         -----------\r\n");
                        sw.Write("-----------Tên Đồ Án    : " + txtTenDoAn.Text + "        -----------\r\n");
                        sw.Write("-----------Nội Dung    : " + rtxtTomTatNoiDung.Text + "        -----------\r\n");
                        sw.Write("-----------Mã Sinh Viên    : " + cbMaSV.Text + "        -----------\r\n");
                        sw.Write("-----------Mã Giảng Viên    : " + cbMaGV.Text + "        -----------\r\n");
                        sw.Write("-----------Chương Trình Quản Lý Đồ Án Tốt Nghiệp     ----------------\r\n");
                        MessageBox.Show("Đã lưu file thành công");
                        sw.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Bạn chưa chọn đồ án để lưu");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Có Lỗi Không Thể Lưu File");
            }
        }

        private void labelThôngTinĐồÁn_Click(object sender, EventArgs e)
        {
        }
    }
}
