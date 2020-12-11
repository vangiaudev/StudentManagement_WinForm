using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn2
{
    public partial class frmTrangChu : Form
    {
        public frmTrangChu()
        {
            InitializeComponent();
        }

        private void frmTrangChu_Load(object sender, EventArgs e)
        {
            menuSinhVien.Enabled = false;
            menuDoAn.Enabled = false;
            menuKhoa.Enabled = false;
            menuBoMon.Enabled = false;
            menuGiangVien.Enabled = false;
            menuDanhSachDA.Enabled = false;
            menuDanhSachSV.Enabled = false;
            menuGiangVienHuongDan.Enabled = false;
            báoCáoToolStripMenuItem.Enabled = false;
        }

        private void menuDangNhap_Click(object sender, EventArgs e)
        {
            frmDangNhap DN = new frmDangNhap();
            DN.ShowDialog();
            if (frmDangNhap.DNTC == true)
            {
                menuSinhVien.Enabled = true;
                menuDoAn.Enabled = true;
                menuKhoa.Enabled = true;
                menuBoMon.Enabled = true;
                menuGiangVien.Enabled = true;
                menuGiangVienHuongDan.Enabled = true;
                menuDanhSachDA.Enabled = true;
                menuDanhSachSV.Enabled = true;
                menuDangNhap.Enabled = false;
                báoCáoToolStripMenuItem.Enabled = true;
            }
        }

        private void menuThoat_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Muốn thoát chương trình hả thím ?", "Hỏi thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ret == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void menuSinhVien_Click(object sender, EventArgs e)
        {
            frmThongTinSinhVien ttsv = new frmThongTinSinhVien();
            ttsv.Show();
        }

        private void menuDoAn_Click(object sender, EventArgs e)
        {
            frmThongTinDoAn ttda = new frmThongTinDoAn();
            ttda.Show();
        }

        private void menuDangXuat_Click(object sender, EventArgs e)
        {
            if(frmDangNhap.DNTC == false)
            {
                MessageBox.Show("Bạn chưa đăng nhập");
            }
            else
            {
                DialogResult ret = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất ?", "Xác nhân", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (ret == DialogResult.OK)
                {
                    menuSinhVien.Enabled = false;
                    menuDoAn.Enabled = false;
                    menuKhoa.Enabled = false;
                    menuBoMon.Enabled = false;
                    menuGiangVien.Enabled = false;
                    menuGiangVienHuongDan.Enabled = false;
                    menuDangNhap.Enabled = true;
                }
            }
           
        }
        int x;
        private void timer1_Tick(object sender, EventArgs e)
        {
            x = lblTenPhanMem.Location.X;
            x--;
            lblTenPhanMem.Location = new Point(x, lblTenPhanMem.Location.Y);

            if (x == 0)
            {
                frmTrangChu fr = new frmTrangChu();
                x = fr.Size.Width;
                lblTenPhanMem.Location = new Point(fr.Size.Width, lblTenPhanMem.Location.Y);
            }
        }

        private void menuGiangVienHuongDan_Click(object sender, EventArgs e)
        {
            frmThongKeGiangVienHuongDan frm = new frmThongKeGiangVienHuongDan();
            frm.Show();
        }

        private void menuKhoa_Click(object sender, EventArgs e)
        {
            frmKhoa frm = new frmKhoa();
            frm.Show();
        }

        private void menuThongTinPhanMem_Click(object sender, EventArgs e)
        {
            frmThanhVienThucHien frm = new frmThanhVienThucHien();
            frm.Show();
        }

        private void menuBoMon_Click(object sender, EventArgs e)
        {
            frmBoMon frm = new frmBoMon();
            frm.Show();
        }

        private void menuHuongDanSuDung_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đang cập nhật...");
        }

        private void menuGiangVien_Click(object sender, EventArgs e)
        {
            frmGiangVien frm = new frmGiangVien();
            frm.Show();
        }

        private void menuDoiMatKhau_Click(object sender, EventArgs e)
        {
            frmDoiMatKhau frm = new frmDoiMatKhau();
            frm.Show();
        }

        private void menuDanhSachDA_Click(object sender, EventArgs e)
        {
            frmXuatDanhSachDoAn frm = new frmXuatDanhSachDoAn();
            frm.Show();
        }

        private void menuDanhSachSV_Click(object sender, EventArgs e)
        {
            frmXuatDanhSachSinhVien frm = new frmXuatDanhSachSinhVien();
            frm.Show();
        }

        private void báoCáoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReport frm = new frmReport();
            frm.Show();
        }


        private void menuHeThong_Click(object sender, EventArgs e)
        {

        }
    }
}
