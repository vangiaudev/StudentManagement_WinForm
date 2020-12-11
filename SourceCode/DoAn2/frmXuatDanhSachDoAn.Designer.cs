namespace DoAn2
{
    partial class frmXuatDanhSachDoAn
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmXuatDanhSachDoAn));
            this.dgvXuatDanhSach = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.MaDoAn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDoAn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TomTatNoiDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TuKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.btnXuatFileExcel = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXuatDanhSach)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvXuatDanhSach
            // 
            this.dgvXuatDanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvXuatDanhSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDoAn,
            this.TenDoAn,
            this.TomTatNoiDung,
            this.TuKhoa,
            this.MaSV,
            this.MaGV});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvXuatDanhSach.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvXuatDanhSach.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvXuatDanhSach.Location = new System.Drawing.Point(-1, 57);
            this.dgvXuatDanhSach.Name = "dgvXuatDanhSach";
            this.dgvXuatDanhSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvXuatDanhSach.Size = new System.Drawing.Size(785, 219);
            this.dgvXuatDanhSach.TabIndex = 0;
            // 
            // MaDoAn
            // 
            this.MaDoAn.DataPropertyName = "MaDoAn";
            this.MaDoAn.HeaderText = "Mã Đồ Án";
            this.MaDoAn.Name = "MaDoAn";
            // 
            // TenDoAn
            // 
            this.TenDoAn.DataPropertyName = "TenDoAn";
            this.TenDoAn.HeaderText = "Tên Đồ Án";
            this.TenDoAn.Name = "TenDoAn";
            this.TenDoAn.Width = 200;
            // 
            // TomTatNoiDung
            // 
            this.TomTatNoiDung.DataPropertyName = "TomTatNoiDung";
            this.TomTatNoiDung.HeaderText = "Tóm Tắt Nội Dung";
            this.TomTatNoiDung.Name = "TomTatNoiDung";
            this.TomTatNoiDung.Width = 200;
            // 
            // TuKhoa
            // 
            this.TuKhoa.DataPropertyName = "TuKhoa";
            this.TuKhoa.HeaderText = "Từ Khóa";
            this.TuKhoa.Name = "TuKhoa";
            this.TuKhoa.Width = 80;
            // 
            // MaSV
            // 
            this.MaSV.DataPropertyName = "MaSV";
            this.MaSV.HeaderText = "Mã Sinh Viên";
            this.MaSV.Name = "MaSV";
            this.MaSV.Width = 80;
            // 
            // MaGV
            // 
            this.MaGV.DataPropertyName = "MaGV";
            this.MaGV.HeaderText = "Mã Giảng Viên";
            this.MaGV.Name = "MaGV";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(144, 12);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(497, 39);
            this.labelX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.labelX1.TabIndex = 1;
            this.labelX1.Text = "BẢNG TỔNG HỢP DANH SÁCH ĐỒ ÁN SINH VIÊN";
            // 
            // btnXuatFileExcel
            // 
            this.btnXuatFileExcel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnXuatFileExcel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnXuatFileExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnXuatFileExcel.Image")));
            this.btnXuatFileExcel.Location = new System.Drawing.Point(295, 298);
            this.btnXuatFileExcel.Name = "btnXuatFileExcel";
            this.btnXuatFileExcel.Size = new System.Drawing.Size(171, 48);
            this.btnXuatFileExcel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnXuatFileExcel.TabIndex = 3;
            this.btnXuatFileExcel.Text = "Export Excel";
            this.btnXuatFileExcel.Click += new System.EventHandler(this.btnXuatFileExcel_Click);
            // 
            // frmXuatDanhSachDoAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(782, 373);
            this.Controls.Add(this.btnXuatFileExcel);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.dgvXuatDanhSach);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.Name = "frmXuatDanhSachDoAn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh Sách Đồ Án";
            this.Load += new System.EventHandler(this.frmXuatDanhSachDoAn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvXuatDanhSach)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dgvXuatDanhSach;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.ButtonX btnXuatFileExcel;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDoAn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDoAn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TomTatNoiDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn TuKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaGV;
    }
}