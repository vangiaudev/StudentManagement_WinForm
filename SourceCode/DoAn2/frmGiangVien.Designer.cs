namespace DoAn2
{
    partial class frmGiangVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGiangVien));
            this.gpTimKiemGV = new System.Windows.Forms.GroupBox();
            this.btnTimKiemGV = new DevComponents.DotNetBar.ButtonX();
            this.cbTimKiemGV = new System.Windows.Forms.ComboBox();
            this.txtTimKiemGV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenGV = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtMaGV = new System.Windows.Forms.TextBox();
            this.lvThongTinGiangVien = new System.Windows.Forms.ListView();
            this.columnHeaderSTT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderMãGiảngViên = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTênGiảngViên = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderMãBộMôn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.cbMaBoMon = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gpTimKiemGV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gpTimKiemGV
            // 
            this.gpTimKiemGV.BackColor = System.Drawing.Color.Transparent;
            this.gpTimKiemGV.Controls.Add(this.btnTimKiemGV);
            this.gpTimKiemGV.Controls.Add(this.cbTimKiemGV);
            this.gpTimKiemGV.Controls.Add(this.txtTimKiemGV);
            this.gpTimKiemGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpTimKiemGV.ForeColor = System.Drawing.Color.Black;
            this.gpTimKiemGV.Location = new System.Drawing.Point(294, 76);
            this.gpTimKiemGV.Name = "gpTimKiemGV";
            this.gpTimKiemGV.Size = new System.Drawing.Size(268, 100);
            this.gpTimKiemGV.TabIndex = 54;
            this.gpTimKiemGV.TabStop = false;
            this.gpTimKiemGV.Text = "Tìm Kiếm Giảng Viên";
            // 
            // btnTimKiemGV
            // 
            this.btnTimKiemGV.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnTimKiemGV.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnTimKiemGV.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiemGV.Image")));
            this.btnTimKiemGV.Location = new System.Drawing.Point(183, 38);
            this.btnTimKiemGV.Name = "btnTimKiemGV";
            this.btnTimKiemGV.Size = new System.Drawing.Size(79, 37);
            this.btnTimKiemGV.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnTimKiemGV.TabIndex = 64;
            this.btnTimKiemGV.Text = "Tìm Kiếm";
            this.btnTimKiemGV.Click += new System.EventHandler(this.btnTimKiemGV_Click);
            // 
            // cbTimKiemGV
            // 
            this.cbTimKiemGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTimKiemGV.FormattingEnabled = true;
            this.cbTimKiemGV.Items.AddRange(new object[] {
            "[--Chọn Một--]",
            "Tìm Theo Mã Giảng Viên",
            "Tìm Theo Tên Giảng Viên"});
            this.cbTimKiemGV.Location = new System.Drawing.Point(18, 30);
            this.cbTimKiemGV.Name = "cbTimKiemGV";
            this.cbTimKiemGV.Size = new System.Drawing.Size(145, 21);
            this.cbTimKiemGV.TabIndex = 43;
            this.cbTimKiemGV.Text = "[--Chọn Một--]";
            // 
            // txtTimKiemGV
            // 
            this.txtTimKiemGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiemGV.Location = new System.Drawing.Point(18, 68);
            this.txtTimKiemGV.Name = "txtTimKiemGV";
            this.txtTimKiemGV.Size = new System.Drawing.Size(145, 20);
            this.txtTimKiemGV.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(16, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 52;
            this.label1.Text = "Mã Bộ Môn";
            // 
            // txtTenGV
            // 
            this.txtTenGV.Location = new System.Drawing.Point(117, 111);
            this.txtTenGV.Name = "txtTenGV";
            this.txtTenGV.Size = new System.Drawing.Size(157, 20);
            this.txtTenGV.TabIndex = 50;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label14.Location = new System.Drawing.Point(16, 114);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(95, 13);
            this.label14.TabIndex = 49;
            this.label14.Text = "Tên Giảng Viên";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label16.Location = new System.Drawing.Point(16, 79);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(90, 13);
            this.label16.TabIndex = 47;
            this.label16.Text = "Mã Giảng Viên";
            // 
            // txtMaGV
            // 
            this.txtMaGV.Location = new System.Drawing.Point(116, 76);
            this.txtMaGV.Name = "txtMaGV";
            this.txtMaGV.Size = new System.Drawing.Size(158, 20);
            this.txtMaGV.TabIndex = 46;
            // 
            // lvThongTinGiangVien
            // 
            this.lvThongTinGiangVien.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderSTT,
            this.columnHeaderMãGiảngViên,
            this.columnHeaderTênGiảngViên,
            this.columnHeaderMãBộMôn});
            this.lvThongTinGiangVien.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lvThongTinGiangVien.FullRowSelect = true;
            this.lvThongTinGiangVien.Location = new System.Drawing.Point(0, 246);
            this.lvThongTinGiangVien.MultiSelect = false;
            this.lvThongTinGiangVien.Name = "lvThongTinGiangVien";
            this.lvThongTinGiangVien.Size = new System.Drawing.Size(575, 160);
            this.lvThongTinGiangVien.TabIndex = 55;
            this.lvThongTinGiangVien.UseCompatibleStateImageBehavior = false;
            this.lvThongTinGiangVien.View = System.Windows.Forms.View.Details;
            this.lvThongTinGiangVien.SelectedIndexChanged += new System.EventHandler(this.lvThongTinGiangVien_SelectedIndexChanged);
            // 
            // columnHeaderSTT
            // 
            this.columnHeaderSTT.Text = "STT";
            // 
            // columnHeaderMãGiảngViên
            // 
            this.columnHeaderMãGiảngViên.Text = "Mã Giảng Viên";
            this.columnHeaderMãGiảngViên.Width = 140;
            // 
            // columnHeaderTênGiảngViên
            // 
            this.columnHeaderTênGiảngViên.Text = "Tên Giảng Viên";
            this.columnHeaderTênGiảngViên.Width = 213;
            // 
            // columnHeaderMãBộMôn
            // 
            this.columnHeaderMãBộMôn.Text = "Mã Bộ Môn";
            this.columnHeaderMãBộMôn.Width = 152;
            // 
            // btnHuy
            // 
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.Image")));
            this.btnHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuy.Location = new System.Drawing.Point(393, 195);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(84, 34);
            this.btnHuy.TabIndex = 56;
            this.btnHuy.Text = "   Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(284, 195);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(84, 34);
            this.btnXoa.TabIndex = 58;
            this.btnXoa.Text = "   Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(182, 195);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(84, 34);
            this.btnSua.TabIndex = 59;
            this.btnSua.Text = "    Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(79, 195);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(84, 34);
            this.btnThem.TabIndex = 60;
            this.btnThem.Text = "   Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // cbMaBoMon
            // 
            this.cbMaBoMon.FormattingEnabled = true;
            this.cbMaBoMon.Location = new System.Drawing.Point(116, 144);
            this.cbMaBoMon.Name = "cbMaBoMon";
            this.cbMaBoMon.Size = new System.Drawing.Size(158, 21);
            this.cbMaBoMon.TabIndex = 61;
            this.cbMaBoMon.SelectedIndexChanged += new System.EventHandler(this.cbMaBoMon_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(80, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(495, 30);
            this.label2.TabIndex = 62;
            this.label2.Text = "THÔNG TIN GIẢNG VIÊN HƯỚNG DẪN";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(19, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 66);
            this.pictureBox1.TabIndex = 63;
            this.pictureBox1.TabStop = false;
            // 
            // frmGiangVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(575, 406);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbMaBoMon);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.lvThongTinGiangVien);
            this.Controls.Add(this.gpTimKiemGV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTenGV);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtMaGV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmGiangVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông Tin Giảng Viên";
            this.Load += new System.EventHandler(this.frmGiangVien_Load);
            this.gpTimKiemGV.ResumeLayout(false);
            this.gpTimKiemGV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpTimKiemGV;
        private System.Windows.Forms.TextBox txtTimKiemGV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenGV;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtMaGV;
        private System.Windows.Forms.ListView lvThongTinGiangVien;
        private System.Windows.Forms.ColumnHeader columnHeaderSTT;
        private System.Windows.Forms.ColumnHeader columnHeaderMãGiảngViên;
        private System.Windows.Forms.ColumnHeader columnHeaderTênGiảngViên;
        private System.Windows.Forms.ColumnHeader columnHeaderMãBộMôn;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ComboBox cbMaBoMon;
        private System.Windows.Forms.ComboBox cbTimKiemGV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevComponents.DotNetBar.ButtonX btnTimKiemGV;
    }
}