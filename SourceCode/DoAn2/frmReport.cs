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
    public partial class frmReport : Form
    {
        public frmReport()
        {
            InitializeComponent();
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'demoQuanLyDoAnTotNghiep2DataSet2.DoAn' table. You can move, or remove it, as needed.
            this.doAnTableAdapter1.Fill(this.demoQuanLyDoAnTotNghiep2DataSet2.DoAn);
            // TODO: This line of code loads data into the 'DemoQuanLyDoAnTotNghiep2DataSet3.DoAn' table. You can move, or remove it, as needed.
            this.DoAnTableAdapter.Fill(this.DemoQuanLyDoAnTotNghiep2DataSet3.DoAn);

            this.reportViewer1.RefreshReport();
        }
    }
}
