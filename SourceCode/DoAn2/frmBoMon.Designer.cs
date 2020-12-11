namespace DoAn2
{
    partial class frmBoMon
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
            this.lvThongTinBoMon = new System.Windows.Forms.ListView();
            this.columnHeaderSTT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderMaBM = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTenBM = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderKhoa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtTenBoMon = new System.Windows.Forms.TextBox();
            this.txtMaBoMon = new System.Windows.Forms.TextBox();
            this.labelMãKhoa = new System.Windows.Forms.Label();
            this.labelTênBộMôn = new System.Windows.Forms.Label();
            this.labelMãBộMôn = new System.Windows.Forms.Label();
            this.cbKhoa = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lvThongTinBoMon
            // 
            this.lvThongTinBoMon.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderSTT,
            this.columnHeaderMaBM,
            this.columnHeaderTenBM,
            this.columnHeaderKhoa});
            this.lvThongTinBoMon.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lvThongTinBoMon.FullRowSelect = true;
            this.lvThongTinBoMon.GridLines = true;
            this.lvThongTinBoMon.HideSelection = false;
            this.lvThongTinBoMon.Location = new System.Drawing.Point(0, 221);
            this.lvThongTinBoMon.Name = "lvThongTinBoMon";
            this.lvThongTinBoMon.Size = new System.Drawing.Size(639, 202);
            this.lvThongTinBoMon.TabIndex = 22;
            this.lvThongTinBoMon.UseCompatibleStateImageBehavior = false;
            this.lvThongTinBoMon.View = System.Windows.Forms.View.Details;
            this.lvThongTinBoMon.SelectedIndexChanged += new System.EventHandler(this.lvThongTinBoMon_SelectedIndexChanged);
            // 
            // columnHeaderSTT
            // 
            this.columnHeaderSTT.Text = "STT";
            this.columnHeaderSTT.Width = 80;
            // 
            // columnHeaderMaBM
            // 
            this.columnHeaderMaBM.Text = "Mã Bộ Môn";
            this.columnHeaderMaBM.Width = 160;
            // 
            // columnHeaderTenBM
            // 
            this.columnHeaderTenBM.Text = "Tên Bộ Môn";
            this.columnHeaderTenBM.Width = 230;
            // 
            // columnHeaderKhoa
            // 
            this.columnHeaderKhoa.Text = "Mã Khoa";
            this.columnHeaderKhoa.Width = 160;
            // 
            // btnHuy
            // 
            this.btnHuy.BackgroundImage = global::DoAn2.Properties.Resources.cancel;
            this.btnHuy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnHuy.Location = new System.Drawing.Point(546, 162);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(71, 31);
            this.btnHuy.TabIndex = 17;
            this.btnHuy.Text = "     Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackgroundImage = global::DoAn2.Properties.Resources.dustbin;
            this.btnXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnXoa.Location = new System.Drawing.Point(437, 162);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(71, 31);
            this.btnXoa.TabIndex = 19;
            this.btnXoa.Text = "     Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackgroundImage = global::DoAn2.Properties.Resources.pencil__1_;
            this.btnSua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSua.Location = new System.Drawing.Point(546, 95);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(71, 31);
            this.btnSua.TabIndex = 20;
            this.btnSua.Text = "     Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnThem.BackgroundImage = global::DoAn2.Properties.Resources.add__2_;
            this.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnThem.CausesValidation = false;
            this.btnThem.Location = new System.Drawing.Point(437, 95);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(71, 31);
            this.btnThem.TabIndex = 21;
            this.btnThem.Text = "      Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtTenBoMon
            // 
            this.txtTenBoMon.Location = new System.Drawing.Point(118, 130);
            this.txtTenBoMon.Name = "txtTenBoMon";
            this.txtTenBoMon.Size = new System.Drawing.Size(287, 20);
            this.txtTenBoMon.TabIndex = 14;
            // 
            // txtMaBoMon
            // 
            this.txtMaBoMon.Location = new System.Drawing.Point(118, 95);
            this.txtMaBoMon.Name = "txtMaBoMon";
            this.txtMaBoMon.Size = new System.Drawing.Size(287, 20);
            this.txtMaBoMon.TabIndex = 15;
            // 
            // labelMãKhoa
            // 
            this.labelMãKhoa.AutoSize = true;
            this.labelMãKhoa.BackColor = System.Drawing.Color.Transparent;
            this.labelMãKhoa.Location = new System.Drawing.Point(6, 172);
            this.labelMãKhoa.Name = "labelMãKhoa";
            this.labelMãKhoa.Size = new System.Drawing.Size(50, 13);
            this.labelMãKhoa.TabIndex = 13;
            this.labelMãKhoa.Text = "Mã Khoa";
            // 
            // labelTênBộMôn
            // 
            this.labelTênBộMôn.AutoSize = true;
            this.labelTênBộMôn.BackColor = System.Drawing.Color.Transparent;
            this.labelTênBộMôn.Location = new System.Drawing.Point(6, 133);
            this.labelTênBộMôn.Name = "labelTênBộMôn";
            this.labelTênBộMôn.Size = new System.Drawing.Size(66, 13);
            this.labelTênBộMôn.TabIndex = 12;
            this.labelTênBộMôn.Text = "Tên Bộ Môn";
            // 
            // labelMãBộMôn
            // 
            this.labelMãBộMôn.AutoSize = true;
            this.labelMãBộMôn.BackColor = System.Drawing.Color.Transparent;
            this.labelMãBộMôn.Location = new System.Drawing.Point(6, 98);
            this.labelMãBộMôn.Name = "labelMãBộMôn";
            this.labelMãBộMôn.Size = new System.Drawing.Size(62, 13);
            this.labelMãBộMôn.TabIndex = 11;
            this.labelMãBộMôn.Text = "Mã Bộ Môn";
            // 
            // cbKhoa
            // 
            this.cbKhoa.FormattingEnabled = true;
            this.cbKhoa.Location = new System.Drawing.Point(118, 172);
            this.cbKhoa.Name = "cbKhoa";
            this.cbKhoa.Size = new System.Drawing.Size(287, 21);
            this.cbKhoa.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(194, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 31);
            this.label1.TabIndex = 24;
            this.label1.Text = "Thông Tin Bộ Môn";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::DoAn2.Properties.Resources.language1;
            this.pictureBox1.Location = new System.Drawing.Point(153, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 31);
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::DoAn2.Properties.Resources.language1;
            this.pictureBox2.Location = new System.Drawing.Point(437, 24);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 31);
            this.pictureBox2.TabIndex = 26;
            this.pictureBox2.TabStop = false;
            // 
            // frmBoMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DoAn2.Properties.Resources.gettyimages_1144937599_640x640;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(639, 423);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbKhoa);
            this.Controls.Add(this.lvThongTinBoMon);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtTenBoMon);
            this.Controls.Add(this.txtMaBoMon);
            this.Controls.Add(this.labelMãKhoa);
            this.Controls.Add(this.labelTênBộMôn);
            this.Controls.Add(this.labelMãBộMôn);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmBoMon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Thông Tin Bộ Môn";
            this.Load += new System.EventHandler(this.frmBoMon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvThongTinBoMon;
        private System.Windows.Forms.ColumnHeader columnHeaderSTT;
        private System.Windows.Forms.ColumnHeader columnHeaderMaBM;
        private System.Windows.Forms.ColumnHeader columnHeaderTenBM;
        private System.Windows.Forms.ColumnHeader columnHeaderKhoa;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtTenBoMon;
        private System.Windows.Forms.TextBox txtMaBoMon;
        private System.Windows.Forms.Label labelMãKhoa;
        private System.Windows.Forms.Label labelTênBộMôn;
        private System.Windows.Forms.Label labelMãBộMôn;
        private System.Windows.Forms.ComboBox cbKhoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}