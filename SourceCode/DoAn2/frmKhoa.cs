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
    public partial class frmKhoa : Form
    {
        public frmKhoa()
        {
            InitializeComponent();
        }
        SqlConnection conn = null;
        string strConn = "Data Source=DESKTOP-0GQGB3U; Database=DemoQuanLyDoAnTotNghiep2; Integrated Security = True";
        private void frmKhoa_Load(object sender, EventArgs e)
        {
            if (conn == null)
            {
                conn = new SqlConnection(strConn);
            }
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            string sql = "select * from Khoa";
            DataSet ds = new DataSet();
            SqlDataAdapter adapt = new SqlDataAdapter(sql, conn);
            adapt.Fill(ds);
            dgvKhoa.DataSource = ds.Tables[0];

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgvKhoa.Refresh();
        }

        private void dgvKhoa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
