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
    public partial class frmDoiMatKhau : Form
    {
        public frmDoiMatKhau()
        {
            InitializeComponent();
        }
        string strConn = "Data Source=DESKTOP-0GQGB3U;Initial Catalog=DemoQuanLyDoAnTotNghiep2;Integrated Security=True";
        private void btnthaydoi_Click(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtTaiKhoan, "");
            errorProvider1.SetError(txtMatKhauCu, "");
            errorProvider1.SetError(txtMatKhauMoi, "");
           
            if (txtTaiKhoan.Text == "")
            {
                errorProvider1.SetError(txtTaiKhoan, "Bạn chưa nhập tên tài khoản");
            }
            else if (txtMatKhauCu.Text == "")
            {
                errorProvider1.SetError(txtMatKhauCu, "Bạn chưa nhập mật khẩu hiện tại");
            }
            else if (txtMatKhauMoi.Text == "")
            {
                errorProvider1.SetError(txtMatKhauMoi, "Bạn chưa nhập mật khẩu mới");
            }
            else
            {
                string s = "Data Source=DESKTOP-0GQGB3U; Database=DemoQuanLyDoAnTotNghiep2; Integrated Security = True";
                SqlConnection CON = new SqlConnection();
                CON.ConnectionString = strConn;
                CON.Open();
                s = "select * from NguoiDung where TaiKhoan = '"+txtTaiKhoan.Text+"'";
                SqlCommand CMD = new SqlCommand(s, CON);
                SqlDataAdapter Adapt = new SqlDataAdapter(CMD);
                DataTable TB = new DataTable();
                Adapt.Fill(TB);
               
                if (TB.Rows.Count > 0 && txtMatKhauMoi.Text == txtXacNhanMatKhau.Text)
                {
                    string sql = "update NguoiDung set MatKhau = @MatKhau where TaiKhoan = @TaiKhoan";
                    SqlCommand command = new SqlCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText = sql;
                    command.Connection = CON;
                    command.Parameters.Add("@MatKhau", SqlDbType.NVarChar).Value = txtMatKhauMoi.Text;
                    command.Parameters.Add("@TaiKhoan", SqlDbType.NVarChar).Value = txtTaiKhoan.Text;
                    int ret = command.ExecuteNonQuery();
                                   
                    if(ret > 0)
                    {
                        MessageBox.Show("Thay đổi mật khẩu thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Đổi mật khẩu thất bại!");
                    }
                    
                }
                else { MessageBox.Show("Sai thông tin tài khoản hoặc mật khẩu vui lòng nhập lại"); }


            }
        }

        private void frmDoiMatKhau_Load(object sender, EventArgs e)
        {
            
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
