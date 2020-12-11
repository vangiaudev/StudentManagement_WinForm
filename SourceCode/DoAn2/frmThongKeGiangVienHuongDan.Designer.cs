namespace DoAn2
{
    partial class frmThongKeGiangVienHuongDan
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lvDanhSachGiangVienHuongDan = new System.Windows.Forms.ListView();
            this.columnHeaderSTT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderMãSinhViên = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTênĐồÁn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderHọTên = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnLocDL = new DevComponents.DotNetBar.ButtonX();
            this.cbMaGiangVien = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.columnHeaderMãGV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTênGV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(634, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh Sách Sinh Viên Được Hướng Dẫn Bởi Cùng Một Giảng Viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Giảng Viên:";
            // 
            // lvDanhSachGiangVienHuongDan
            // 
            this.lvDanhSachGiangVienHuongDan.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderSTT,
            this.columnHeaderMãSinhViên,
            this.columnHeaderTênĐồÁn,
            this.columnHeaderHọTên,
            this.columnHeaderMãGV,
            this.columnHeaderTênGV});
            this.lvDanhSachGiangVienHuongDan.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lvDanhSachGiangVienHuongDan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvDanhSachGiangVienHuongDan.FullRowSelect = true;
            this.lvDanhSachGiangVienHuongDan.Location = new System.Drawing.Point(0, 118);
            this.lvDanhSachGiangVienHuongDan.MultiSelect = false;
            this.lvDanhSachGiangVienHuongDan.Name = "lvDanhSachGiangVienHuongDan";
            this.lvDanhSachGiangVienHuongDan.Size = new System.Drawing.Size(694, 222);
            this.lvDanhSachGiangVienHuongDan.TabIndex = 53;
            this.lvDanhSachGiangVienHuongDan.UseCompatibleStateImageBehavior = false;
            this.lvDanhSachGiangVienHuongDan.View = System.Windows.Forms.View.Details;
            this.lvDanhSachGiangVienHuongDan.SelectedIndexChanged += new System.EventHandler(this.lvDanhSachGiangVienHuongDan_SelectedIndexChanged);
            // 
            // columnHeaderSTT
            // 
            this.columnHeaderSTT.Text = "STT";
            this.columnHeaderSTT.Width = 40;
            // 
            // columnHeaderMãSinhViên
            // 
            this.columnHeaderMãSinhViên.Text = "Mã Sinh Viên";
            this.columnHeaderMãSinhViên.Width = 100;
            // 
            // columnHeaderTênĐồÁn
            // 
            this.columnHeaderTênĐồÁn.DisplayIndex = 5;
            this.columnHeaderTênĐồÁn.Text = "Tên Đồ Án";
            this.columnHeaderTênĐồÁn.Width = 160;
            // 
            // columnHeaderHọTên
            // 
            this.columnHeaderHọTên.DisplayIndex = 2;
            this.columnHeaderHọTên.Text = "Họ Tên Sinh Viên";
            this.columnHeaderHọTên.Width = 140;
            // 
            // btnLocDL
            // 
            this.btnLocDL.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnLocDL.BackColor = System.Drawing.Color.Transparent;
            this.btnLocDL.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnLocDL.Image = global::DoAn2.Properties.Resources.rgb;
            this.btnLocDL.Location = new System.Drawing.Point(530, 46);
            this.btnLocDL.Name = "btnLocDL";
            this.btnLocDL.Shape = new DevComponents.DotNetBar.EllipticalShapeDescriptor();
            this.btnLocDL.Size = new System.Drawing.Size(105, 52);
            this.btnLocDL.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnLocDL.TabIndex = 55;
            this.btnLocDL.Text = "Lọc Dữ Liệu";
            this.btnLocDL.Click += new System.EventHandler(this.btnLocDL_Click);
            // 
            // cbMaGiangVien
            // 
            this.cbMaGiangVien.DisplayMember = "Text";
            this.cbMaGiangVien.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbMaGiangVien.FormattingEnabled = true;
            this.cbMaGiangVien.ItemHeight = 14;
            this.cbMaGiangVien.Location = new System.Drawing.Point(163, 60);
            this.cbMaGiangVien.Name = "cbMaGiangVien";
            this.cbMaGiangVien.Size = new System.Drawing.Size(335, 20);
            this.cbMaGiangVien.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.cbMaGiangVien.TabIndex = 56;
            // 
            // columnHeaderMãGV
            // 
            this.columnHeaderMãGV.DisplayIndex = 3;
            this.columnHeaderMãGV.Text = "Mã Giảng Viên";
            this.columnHeaderMãGV.Width = 100;
            // 
            // columnHeaderTênGV
            // 
            this.columnHeaderTênGV.DisplayIndex = 4;
            this.columnHeaderTênGV.Text = "Tên Giảng Viên";
            this.columnHeaderTênGV.Width = 140;
            // 
            // frmThongKeGiangVienHuongDan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(694, 340);
            this.Controls.Add(this.cbMaGiangVien);
            this.Controls.Add(this.btnLocDL);
            this.Controls.Add(this.lvDanhSachGiangVienHuongDan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmThongKeGiangVienHuongDan";
            this.Text = "Thống Kê";
            this.Load += new System.EventHandler(this.frmThongKeGiangVienHuongDan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lvDanhSachGiangVienHuongDan;
        private System.Windows.Forms.ColumnHeader columnHeaderSTT;
        private System.Windows.Forms.ColumnHeader columnHeaderMãSinhViên;
        private System.Windows.Forms.ColumnHeader columnHeaderTênĐồÁn;
        private System.Windows.Forms.ColumnHeader columnHeaderHọTên;
        private DevComponents.DotNetBar.ButtonX btnLocDL;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbMaGiangVien;
        private System.Windows.Forms.ColumnHeader columnHeaderMãGV;
        private System.Windows.Forms.ColumnHeader columnHeaderTênGV;
    }
}