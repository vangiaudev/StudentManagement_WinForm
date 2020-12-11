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
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }
        public static bool DNTC = false;
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-0GQGB3U;Initial Catalog=DemoQuanLyDoAnTotNghiep2;Integrated Security=True");
            if (txtTaiKhoan.Text == "")
            {
                MessageBox.Show("Tên Đăng Nhập không được để trống");
            }
            else if (txtMatKhau.Text == "")
            {
                MessageBox.Show("Mật khẩu không được để trống");
            }
            else
            {
                try
                {
                    conn.Open();
                    string tk = txtTaiKhoan.Text;
                    string mk = txtMatKhau.Text;
                    string sql = "select * from NguoiDung where TaiKhoan = '" + tk + "' and MatKhau = '" + mk + "'";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        MessageBox.Show("ĐĂNG NHẬP THÀNH CÔNG !");
                        DNTC = true;
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("SAI TÊN TÀI KHOẢN HOẶC MẬT KHẨU");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Lỗi kết nối");
                }
            }
        }
 
        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            if (DNTC) { Close(); }
        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
