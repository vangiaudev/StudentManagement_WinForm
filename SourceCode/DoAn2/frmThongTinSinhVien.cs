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
using System.Drawing.Imaging;

namespace DoAn2
{
    public partial class frmThongTinSinhVien : Form
    {
        public frmThongTinSinhVien()
        {
            InitializeComponent();
        }
        
        SqlConnection conn = null;
        string strConn = "Data Source=DESKTOP-0GQGB3U;Initial Catalog=DemoQuanLyDoAnTotNghiep2;Integrated Security=True";
        private void frmThongTinSinhVien_Load(object sender, EventArgs e)
        {
            HienThiDuLieuLenListView();
            loadDuLieuTenKhoaComboBox();
            LoadHinhAnh();
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
        private void HienThiDuLieuLenListView()
        {
            KiemTraKetNoiServer();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select SinhVien.MaSV, SinhVien.TenSV, SinhVien.MaLop, Khoa.TenKhoa, SinhVien.GioiTinh " +
                " from SinhVien, Khoa, Lop, BoMon " + 
                " where SinhVien.MaLop = Lop.MaLop and Lop.MaBoMon = BoMon.MaBoMon and Khoa.MaKhoa = BoMon.MaKhoa";

            command.Connection = conn;

            SqlDataReader reader = command.ExecuteReader();

            lvDanhSachSinhVien.Items.Clear();
            int i = 0;
            while (reader.Read())
            {
                lvDanhSachSinhVien.Items.Add((i + 1).ToString());
                lvDanhSachSinhVien.Items[i].SubItems.Add(reader[0].ToString());
                lvDanhSachSinhVien.Items[i].SubItems.Add(reader[1].ToString());
                lvDanhSachSinhVien.Items[i].SubItems.Add(reader[2].ToString());
                lvDanhSachSinhVien.Items[i].SubItems.Add(reader[3].ToString());
                lvDanhSachSinhVien.Items[i].SubItems.Add(reader[4].ToString());
                i++;
            }
            reader.Close();
        }
        private void btnThem_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (txtMaSV.Text == "" || txtHoTen.Text == "" || txtMaLop.Text == "" || cbKhoa.SelectedIndex == -1)
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                }
                else
                {
                    MemoryStream streamm = new MemoryStream();
                    pictureBoxSV.Image.Save(streamm, ImageFormat.Jpeg);
                    MyDbContextDataContext myDb = new MyDbContextDataContext();
                    SinhVien sv = new SinhVien();
                    sv.MaSV = txtMaSV.Text;
                    sv.TenSV = txtHoTen.Text;
                    sv.MaLop = txtMaLop.Text;
                    sv.HinhAnh = streamm.ToArray();
                    if(rbNam.Checked == true)
                    {
                        sv.GioiTinh = "Nam";
                    }
                    else if(rbNu.Checked == true)
                    {
                        sv.GioiTinh = "Nữ";
                    }
                    myDb.SinhViens.InsertOnSubmit(sv);
                    myDb.SubmitChanges();
                    HienThiDuLieuLenListView();
                    MessageBox.Show("Thêm Sinh Viên Thành Công !");
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
                if (lvDanhSachSinhVien.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Bạn chưa chọn đối tượng cần sửa");
                    return;
                }
                ListViewItem lvi = lvDanhSachSinhVien.SelectedItems[0];
                KiemTraKetNoiServer();
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "update SinhVien " +
                                      "set MaSV = @MaSV, TenSV = @TenSV, GioiTinh  = @GioiTinh, MaLop = @MaLop " +
                                      "where MaSV = " + "\'" + lvi.SubItems[1].Text + "\'";
                command.Connection = conn;
                command.Parameters.Add("@TenSV", SqlDbType.NVarChar).Value = txtHoTen.Text;
                command.Parameters.Add("@MaSV", SqlDbType.VarChar).Value = txtMaSV.Text;
                command.Parameters.Add("@MaLop", SqlDbType.VarChar).Value = txtMaLop.Text;
                if (rbNam.Checked == true)
                {
                    command.Parameters.Add("@GioiTinh", SqlDbType.NVarChar).Value = "Nam";
                }
                else if(rbNu.Checked == true)
                {
                    command.Parameters.Add("@GioiTinh", SqlDbType.NVarChar).Value = "Nữ";
                }
                int ret = command.ExecuteNonQuery();

                if (ret > 0)
                {
                    HienThiDuLieuLenListView();
                    MessageBox.Show("Sửa Thông Tin Thành Công");
                    txtHoTen.Text = "";
                    txtMaLop.Text = "";
                    txtMaSV.Text = "";
                    txtSTT.Text = "";
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

        private void lvDanhSachSinhVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvDanhSachSinhVien.SelectedItems.Count == 0) return;
            ListViewItem lvi = lvDanhSachSinhVien.SelectedItems[0];
            txtSTT.Text = lvi.SubItems[0].Text;
            txtMaSV.Text = lvi.SubItems[1].Text;
            txtHoTen.Text = lvi.SubItems[2].Text;
            txtMaLop.Text = lvi.SubItems[3].Text;
            cbKhoa.Text = lvi.SubItems[4].Text;
            if(lvi.SubItems[5].Text == "Nam")
            {
                rbNam.Checked = true;
            }
            else
            {
                rbNu.Checked = true;
            }
            LoadHinhAnh();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult kt = MessageBox.Show("Bạn có chắc chắn muốn xóa sinh viên này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (kt == DialogResult.Yes)
            {
                if (lvDanhSachSinhVien.SelectedItems.Count == -1)
                {
                    MessageBox.Show("Bạn chưa chọn đối tượng để xóa");
                    return;
                }
                KiemTraKetNoiServer();
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "delete from SinhVien where MaSV = '" + txtMaSV.Text + "'";
                command.Connection = conn;
                int ret = command.ExecuteNonQuery();
                if (ret > 0)
                {
                    HienThiDuLieuLenListView();
                    MessageBox.Show("Đã xóa thành công");
                    txtHoTen.Text = "";
                    txtMaLop.Text = "";
                    txtMaSV.Text = "";
                    txtSTT.Text = "";
                    cbKhoa.Text = "";
                }
                else
                {
                    MessageBox.Show("Xóa thất bại");
                }
            }

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            HienThiDuLieuLenListView();
            txtHoTen.Text = "";
            txtMaLop.Text = "";
            txtMaSV.Text = "";
            txtSTT.Text = "";
            cbKhoa.Text = "";
        }

        private void btnLuuThongTinSV_Click(object sender, EventArgs e)
        {

        }

        private void linklabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if(open.ShowDialog() == DialogResult.OK)
            {
                pictureBoxSV.Image = Image.FromFile(open.FileName);
                this.Text = open.FileName;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaSV.Text != "")
                {
                    SaveFileDialog dlg = new SaveFileDialog();
                    dlg.Filter = "file *.txt|*.txt";
                    if (dlg.ShowDialog() == DialogResult.OK)
                    {
                        FileStream fs = new FileStream(dlg.FileName, FileMode.OpenOrCreate, FileAccess.Write);
                        StreamWriter sw = new StreamWriter(fs);
                        sw.Write("----------------------THÔNG TIN SINH VIÊN-----------------------------\r\n");
                        sw.Write("-----------Mã Sinh Viên     : " + txtMaSV.Text + "                          -----------\r\n");
                        sw.Write("-----------Tên Sinh Viên    : " + txtHoTen.Text + "                  -----------\r\n");
                        sw.Write("-----------Lớp    : " + txtMaLop.Text + "                                 -----------\r\n");
                        sw.Write("-----------Khoa    : " + cbKhoa.Text + "                     -----------\r\n");
                        sw.Write("-----------Chương Trình Quản Lý Đồ Án Tốt Nghiệp           ----------\r\n");
                        MessageBox.Show("Đã lưu file thành công");
                        sw.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Bạn chưa chọn sinh viên để lưu");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Có Lỗi Không Thể Lưu File");
            }
        }

        private void btnTimKiemSV_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTimKiem.Text != "")
                {
                    if (cbTimKiem.Text == "Tìm Theo Mã Sinh Viên")
                    {
                        KiemTraKetNoiServer();
                        SqlCommand com = new SqlCommand();
                        com.CommandType = CommandType.Text;
                        com.CommandText = "select SinhVien.MaSV, SinhVien.TenSV, SinhVien.MaLop, Khoa.TenKhoa, SinhVien.GioiTinh " +
                            " from SinhVien, Khoa, Lop, BoMon " + 
                            " where SinhVien.MaSV = '" + txtTimKiem.Text + "' and SinhVien.MaLop = Lop.MaLop and Lop.MaBoMon = BoMon.MaBoMon and Khoa.MaKhoa = BoMon.MaKhoa";
                        com.Connection = conn;

                        SqlDataReader reader = com.ExecuteReader();
                        lvDanhSachSinhVien.Items.Clear();
                        int i = 0;
                        while (reader.Read())
                        {
                            lvDanhSachSinhVien.Items.Add((i + 1).ToString());
                            lvDanhSachSinhVien.Items[i].SubItems.Add(reader[0].ToString());
                            lvDanhSachSinhVien.Items[i].SubItems.Add(reader[1].ToString());
                            lvDanhSachSinhVien.Items[i].SubItems.Add(reader[2].ToString());
                            lvDanhSachSinhVien.Items[i].SubItems.Add(reader[3].ToString());
                            lvDanhSachSinhVien.Items[i].SubItems.Add(reader[4].ToString());
                        }
                        reader.Close();
                    }
                    else if (cbTimKiem.Text == "Tìm Theo Tên Sinh Viên")
                    {

                        KiemTraKetNoiServer();
                        SqlCommand com = new SqlCommand();
                        com.CommandType = CommandType.Text;
                        com.CommandText = "select SinhVien.MaSV, SinhVien.TenSV, SinhVien.MaLop, Khoa.TenKhoa, SinhVien.GioiTinh " +
                            " from SinhVien, Khoa, Lop, BoMon " +
                            " where SinhVien.TenSV = N'" + txtTimKiem.Text + "' and SinhVien.MaLop = Lop.MaLop and Lop.MaBoMon = BoMon.MaBoMon and Khoa.MaKhoa = BoMon.MaKhoa";
                        com.Connection = conn;

                        SqlDataReader reader = com.ExecuteReader();
                        lvDanhSachSinhVien.Items.Clear();
                        int i = 0;
                        while (reader.Read())
                        {
                            lvDanhSachSinhVien.Items.Add((i + 1).ToString());
                            lvDanhSachSinhVien.Items[i].SubItems.Add(reader[0].ToString());
                            lvDanhSachSinhVien.Items[i].SubItems.Add(reader[1].ToString());
                            lvDanhSachSinhVien.Items[i].SubItems.Add(reader[2].ToString());
                            lvDanhSachSinhVien.Items[i].SubItems.Add(reader[3].ToString());
                            lvDanhSachSinhVien.Items[i].SubItems.Add(reader[4].ToString());
                        }
                        reader.Close();
                    }
                    else
                        MessageBox.Show("Vui Lòng Chọn Tìm Theo Mã Sinh Viên Hoặc Theo Tên Sinh Viên");
                }
                else
                    MessageBox.Show("Hãy Nhập Từ Khóa Cần Tìm !");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.Message);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void LoadHinhAnh()
        {
            try
            {
                MyDbContextDataContext myDb = new MyDbContextDataContext();
                SinhVien sv = myDb.SinhViens.Where(p => p.MaSV == txtMaSV.Text).FirstOrDefault();
                if (sv == null) return;
                MemoryStream me = new MemoryStream(sv.HinhAnh.ToArray());
                Image img = Image.FromStream(me);
                if (img == null) return;
                pictureBoxSV.Image = img;
            }
            catch (Exception)
            {

                MessageBox.Show("Lỗi Kết Nối !!!");
            }

        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
           
        }

        private void btnCapNhatAnhSinhVien_Click(object sender, EventArgs e)
        {
            try
            {
                MemoryStream streamm = new MemoryStream();
                pictureBoxSV.Image.Save(streamm, ImageFormat.Jpeg);

                MyDbContextDataContext myDb = new MyDbContextDataContext();
                SinhVien sv = new SinhVien();
                sv = myDb.SinhViens.Where(p => p.MaSV == txtMaSV.Text).Single();
                sv.MaSV = txtMaSV.Text;
                sv.TenSV = txtHoTen.Text;
                sv.MaLop = txtMaLop.Text;
                sv.HinhAnh = streamm.ToArray();
                if (rbNam.Checked == true)
                {
                    sv.GioiTinh = "Nam";
                }
                else
                {
                    sv.GioiTinh = "Nữ";
                }
                myDb.SubmitChanges();
                HienThiDuLieuLenListView();
                MessageBox.Show("Cập Nhật Thành Công");
            }
            catch (Exception)
            {

                MessageBox.Show("Cập Nhật Thất Bại!");
            }
        }
        private void loadDuLieuTenKhoaComboBox()
        {
            string str = "Data Source=DESKTOP-0GQGB3U;Initial Catalog=DemoQuanLyDoAnTotNghiep2;Integrated Security=True";
            SqlConnection CON = new SqlConnection();
            DataTable TB = new DataTable();
            CON.ConnectionString = str;
            try
            {
                CON.Open();
                str = "select * from Khoa";
                SqlCommand CMD = new SqlCommand(str, CON);
                SqlDataAdapter Adapt = new SqlDataAdapter(CMD);
                Adapt.Fill(TB);
                foreach (DataRow r in TB.Rows)
                {
                    str = r[1].ToString();
                    cbKhoa.Items.Add(str);
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
    }
}
