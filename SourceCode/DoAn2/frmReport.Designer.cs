namespace DoAn2
{
    partial class frmReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.DoAnBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DemoQuanLyDoAnTotNghiep2DataSet3 = new DoAn2.DemoQuanLyDoAnTotNghiep2DataSet3();
            this.DoAnTableAdapter = new DoAn2.DemoQuanLyDoAnTotNghiep2DataSet3TableAdapters.DoAnTableAdapter();
            this.demoQuanLyDoAnTotNghiep2DataSet2 = new DoAn2.DemoQuanLyDoAnTotNghiep2DataSet2();
            this.doAnBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.doAnTableAdapter1 = new DoAn2.DemoQuanLyDoAnTotNghiep2DataSet2TableAdapters.DoAnTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.DoAnBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DemoQuanLyDoAnTotNghiep2DataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.demoQuanLyDoAnTotNghiep2DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doAnBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // DoAnBindingSource
            // 
            this.DoAnBindingSource.DataMember = "DoAn";
            this.DoAnBindingSource.DataSource = this.DemoQuanLyDoAnTotNghiep2DataSet3;
            // 
            // DemoQuanLyDoAnTotNghiep2DataSet3
            // 
            this.DemoQuanLyDoAnTotNghiep2DataSet3.DataSetName = "DemoQuanLyDoAnTotNghiep2DataSet3";
            this.DemoQuanLyDoAnTotNghiep2DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DoAnTableAdapter
            // 
            this.DoAnTableAdapter.ClearBeforeFill = true;
            // 
            // demoQuanLyDoAnTotNghiep2DataSet2
            // 
            this.demoQuanLyDoAnTotNghiep2DataSet2.DataSetName = "DemoQuanLyDoAnTotNghiep2DataSet2";
            this.demoQuanLyDoAnTotNghiep2DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // doAnBindingSource1
            // 
            this.doAnBindingSource1.DataMember = "DoAn";
            this.doAnBindingSource1.DataSource = this.demoQuanLyDoAnTotNghiep2DataSet2;
            // 
            // doAnTableAdapter1
            // 
            this.doAnTableAdapter1.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.DoAnBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DoAn2.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(855, 523);
            this.reportViewer1.TabIndex = 0;
            // 
            // frmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 523);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo Cáo";
            this.Load += new System.EventHandler(this.frmReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DoAnBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DemoQuanLyDoAnTotNghiep2DataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.demoQuanLyDoAnTotNghiep2DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doAnBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource DoAnBindingSource;
        private DemoQuanLyDoAnTotNghiep2DataSet3 DemoQuanLyDoAnTotNghiep2DataSet3;
        private DemoQuanLyDoAnTotNghiep2DataSet3TableAdapters.DoAnTableAdapter DoAnTableAdapter;
        private DemoQuanLyDoAnTotNghiep2DataSet2 demoQuanLyDoAnTotNghiep2DataSet2;
        private System.Windows.Forms.BindingSource doAnBindingSource1;
        private DemoQuanLyDoAnTotNghiep2DataSet2TableAdapters.DoAnTableAdapter doAnTableAdapter1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}