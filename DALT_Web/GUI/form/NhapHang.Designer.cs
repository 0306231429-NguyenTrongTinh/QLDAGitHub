namespace GUI.form
{
    partial class NhapHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NhapHang));
            this.label10 = new System.Windows.Forms.Label();
            this.dgv_qlNhapHang = new System.Windows.Forms.DataGridView();
            this.coll_MaPhieuNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coll_NgayNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coll_MaNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coll_MaNhaCungCap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coll_TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coll_TrangThai = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_maNV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbb_mNCC = new System.Windows.Forms.ComboBox();
            this.cbb_trangThai = new System.Windows.Forms.ComboBox();
            this.dt_ngayNhap = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_tongTien = new System.Windows.Forms.TextBox();
            this.txt_maPN = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.tscbb_loaiThongTin = new System.Windows.Forms.ToolStripComboBox();
            this.tsTxt_nhapThongTin = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsb_themPN = new System.Windows.Forms.ToolStripButton();
            this.tsb_xoaPN = new System.Windows.Forms.ToolStripButton();
            this.tsb_suaPN = new System.Windows.Forms.ToolStripButton();
            this.tsb_xoaPhieuNhap = new System.Windows.Forms.ToolStripButton();
            this.ts_lamMoiDS = new System.Windows.Forms.ToolStripButton();
            this.tsb_timPN = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_qlNhapHang)).BeginInit();
            this.panel2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(-134, -40);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(192, 32);
            this.label10.TabIndex = 32;
            this.label10.Text = "Tìm Sản Phẩm";
            // 
            // dgv_qlNhapHang
            // 
            this.dgv_qlNhapHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_qlNhapHang.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgv_qlNhapHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_qlNhapHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.coll_MaPhieuNhap,
            this.coll_NgayNhap,
            this.coll_MaNhanVien,
            this.coll_MaNhaCungCap,
            this.coll_TongTien,
            this.coll_TrangThai});
            this.dgv_qlNhapHang.Location = new System.Drawing.Point(13, 198);
            this.dgv_qlNhapHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_qlNhapHang.Name = "dgv_qlNhapHang";
            this.dgv_qlNhapHang.RowHeadersWidth = 51;
            this.dgv_qlNhapHang.RowTemplate.Height = 24;
            this.dgv_qlNhapHang.Size = new System.Drawing.Size(1368, 284);
            this.dgv_qlNhapHang.TabIndex = 39;
            this.dgv_qlNhapHang.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_qlNhapHang_CellDoubleClick);
            this.dgv_qlNhapHang.SelectionChanged += new System.EventHandler(this.dgv_qlHoaDon_SelectionChanged);
            // 
            // coll_MaPhieuNhap
            // 
            this.coll_MaPhieuNhap.HeaderText = "Mã Phiếu Nhập";
            this.coll_MaPhieuNhap.MinimumWidth = 6;
            this.coll_MaPhieuNhap.Name = "coll_MaPhieuNhap";
            // 
            // coll_NgayNhap
            // 
            this.coll_NgayNhap.HeaderText = "Ngày Nhập";
            this.coll_NgayNhap.MinimumWidth = 6;
            this.coll_NgayNhap.Name = "coll_NgayNhap";
            // 
            // coll_MaNhanVien
            // 
            this.coll_MaNhanVien.HeaderText = "Mã Nhân Viên";
            this.coll_MaNhanVien.MinimumWidth = 6;
            this.coll_MaNhanVien.Name = "coll_MaNhanVien";
            // 
            // coll_MaNhaCungCap
            // 
            this.coll_MaNhaCungCap.HeaderText = "Mã Nhà Cung Cấp";
            this.coll_MaNhaCungCap.MinimumWidth = 6;
            this.coll_MaNhaCungCap.Name = "coll_MaNhaCungCap";
            // 
            // coll_TongTien
            // 
            this.coll_TongTien.HeaderText = "Tổng Tiền ";
            this.coll_TongTien.MinimumWidth = 6;
            this.coll_TongTien.Name = "coll_TongTien";
            // 
            // coll_TrangThai
            // 
            this.coll_TrangThai.HeaderText = "Trạng Thái";
            this.coll_TrangThai.MinimumWidth = 6;
            this.coll_TrangThai.Name = "coll_TrangThai";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightBlue;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txt_maNV);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.cbb_mNCC);
            this.panel2.Controls.Add(this.cbb_trangThai);
            this.panel2.Controls.Add(this.dt_ngayNhap);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txt_tongTien);
            this.panel2.Controls.Add(this.txt_maPN);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Location = new System.Drawing.Point(13, 38);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1367, 156);
            this.panel2.TabIndex = 38;
            // 
            // txt_maNV
            // 
            this.txt_maNV.Location = new System.Drawing.Point(653, 28);
            this.txt_maNV.Multiline = true;
            this.txt_maNV.Name = "txt_maNV";
            this.txt_maNV.Size = new System.Drawing.Size(180, 26);
            this.txt_maNV.TabIndex = 29;
            this.txt_maNV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_maNV_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(922, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 23);
            this.label3.TabIndex = 28;
            this.label3.Text = "Mã Nhà Cung Cấp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(499, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 23);
            this.label2.TabIndex = 27;
            this.label2.Text = "Mã Nhân Viên";
            // 
            // cbb_mNCC
            // 
            this.cbb_mNCC.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_mNCC.FormattingEnabled = true;
            this.cbb_mNCC.Location = new System.Drawing.Point(1135, 28);
            this.cbb_mNCC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbb_mNCC.Name = "cbb_mNCC";
            this.cbb_mNCC.Size = new System.Drawing.Size(180, 27);
            this.cbb_mNCC.TabIndex = 26;
            // 
            // cbb_trangThai
            // 
            this.cbb_trangThai.FormattingEnabled = true;
            this.cbb_trangThai.Location = new System.Drawing.Point(653, 103);
            this.cbb_trangThai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbb_trangThai.Name = "cbb_trangThai";
            this.cbb_trangThai.Size = new System.Drawing.Size(180, 24);
            this.cbb_trangThai.TabIndex = 22;
            // 
            // dt_ngayNhap
            // 
            this.dt_ngayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_ngayNhap.Location = new System.Drawing.Point(217, 105);
            this.dt_ngayNhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dt_ngayNhap.Name = "dt_ngayNhap";
            this.dt_ngayNhap.Size = new System.Drawing.Size(125, 22);
            this.dt_ngayNhap.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(509, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 23);
            this.label1.TabIndex = 20;
            this.label1.Text = "Trạng Thái";
            // 
            // txt_tongTien
            // 
            this.txt_tongTien.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tongTien.Location = new System.Drawing.Point(1135, 94);
            this.txt_tongTien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_tongTien.Multiline = true;
            this.txt_tongTien.Name = "txt_tongTien";
            this.txt_tongTien.Size = new System.Drawing.Size(180, 34);
            this.txt_tongTien.TabIndex = 10;
            this.txt_tongTien.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_tongTien_KeyPress);
            // 
            // txt_maPN
            // 
            this.txt_maPN.Enabled = false;
            this.txt_maPN.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_maPN.Location = new System.Drawing.Point(215, 17);
            this.txt_maPN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_maPN.Multiline = true;
            this.txt_maPN.Name = "txt_maPN";
            this.txt_maPN.ReadOnly = true;
            this.txt_maPN.Size = new System.Drawing.Size(180, 34);
            this.txt_maPN.TabIndex = 8;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(66, 105);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(103, 23);
            this.label12.TabIndex = 5;
            this.label12.Text = "Ngày Nhập";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(991, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 23);
            this.label8.TabIndex = 4;
            this.label8.Text = "Tổng Tiền";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(51, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(144, 23);
            this.label9.TabIndex = 5;
            this.label9.Text = "Mã Phiếu Nhập ";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.Enabled = false;
            this.toolStripTextBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.ReadOnly = true;
            this.toolStripTextBox2.Size = new System.Drawing.Size(100, 31);
            this.toolStripTextBox2.Text = "Search";
            // 
            // tscbb_loaiThongTin
            // 
            this.tscbb_loaiThongTin.Name = "tscbb_loaiThongTin";
            this.tscbb_loaiThongTin.Size = new System.Drawing.Size(140, 31);
            this.tscbb_loaiThongTin.Text = "Loại Thông Tin";
            this.tscbb_loaiThongTin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tscbb_loaiThongTin_KeyPress);
            // 
            // tsTxt_nhapThongTin
            // 
            this.tsTxt_nhapThongTin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tsTxt_nhapThongTin.Name = "tsTxt_nhapThongTin";
            this.tsTxt_nhapThongTin.Size = new System.Drawing.Size(100, 31);
            this.tsTxt_nhapThongTin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tsTxt_nhapThongTin_KeyPress);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_themPN,
            this.toolStripSeparator,
            this.tsb_xoaPN,
            this.toolStripSeparator2,
            this.tsb_suaPN,
            this.toolStripSeparator3,
            this.tsb_xoaPhieuNhap,
            this.toolStripSeparator1,
            this.ts_lamMoiDS,
            this.toolStripSeparator6,
            this.toolStripTextBox2,
            this.tscbb_loaiThongTin,
            this.tsTxt_nhapThongTin,
            this.tsb_timPN,
            this.toolStripSeparator5});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1411, 31);
            this.toolStrip1.TabIndex = 40;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsb_themPN
            // 
            this.tsb_themPN.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_themPN.Image = ((System.Drawing.Image)(resources.GetObject("tsb_themPN.Image")));
            this.tsb_themPN.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_themPN.Name = "tsb_themPN";
            this.tsb_themPN.Size = new System.Drawing.Size(29, 28);
            this.tsb_themPN.Text = "&Thêm Phiếu Nhập";
            this.tsb_themPN.Click += new System.EventHandler(this.tsb_themPN_Click);
            // 
            // tsb_xoaPN
            // 
            this.tsb_xoaPN.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_xoaPN.Image = ((System.Drawing.Image)(resources.GetObject("tsb_xoaPN.Image")));
            this.tsb_xoaPN.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_xoaPN.Name = "tsb_xoaPN";
            this.tsb_xoaPN.Size = new System.Drawing.Size(29, 28);
            this.tsb_xoaPN.Text = "&Xóa Phiếu Nhập";
            this.tsb_xoaPN.Click += new System.EventHandler(this.tsb_xoaPN_Click);
            // 
            // tsb_suaPN
            // 
            this.tsb_suaPN.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_suaPN.Image = ((System.Drawing.Image)(resources.GetObject("tsb_suaPN.Image")));
            this.tsb_suaPN.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_suaPN.Name = "tsb_suaPN";
            this.tsb_suaPN.Size = new System.Drawing.Size(29, 28);
            this.tsb_suaPN.Text = "&Sửa Phiếu Nhập";
            this.tsb_suaPN.Click += new System.EventHandler(this.tsb_suaPN_Click);
            // 
            // tsb_xoaPhieuNhap
            // 
            this.tsb_xoaPhieuNhap.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_xoaPhieuNhap.Image = ((System.Drawing.Image)(resources.GetObject("tsb_xoaPhieuNhap.Image")));
            this.tsb_xoaPhieuNhap.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_xoaPhieuNhap.Name = "tsb_xoaPhieuNhap";
            this.tsb_xoaPhieuNhap.Size = new System.Drawing.Size(29, 28);
            this.tsb_xoaPhieuNhap.Text = "&Xóa Phiếu Nhập";
            this.tsb_xoaPhieuNhap.Click += new System.EventHandler(this.tsb_xoaPhieuNhap_Click);
            // 
            // ts_lamMoiDS
            // 
            this.ts_lamMoiDS.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ts_lamMoiDS.Image = ((System.Drawing.Image)(resources.GetObject("ts_lamMoiDS.Image")));
            this.ts_lamMoiDS.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_lamMoiDS.Name = "ts_lamMoiDS";
            this.ts_lamMoiDS.Size = new System.Drawing.Size(29, 28);
            this.ts_lamMoiDS.Text = "&Làm Mới Danh Sách";
            this.ts_lamMoiDS.Click += new System.EventHandler(this.ts_lamMoiDS_Click);
            // 
            // tsb_timPN
            // 
            this.tsb_timPN.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_timPN.Image = ((System.Drawing.Image)(resources.GetObject("tsb_timPN.Image")));
            this.tsb_timPN.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_timPN.Name = "tsb_timPN";
            this.tsb_timPN.Size = new System.Drawing.Size(29, 28);
            this.tsb_timPN.Text = "&Tìm Phiếu Nhập";
            this.tsb_timPN.Click += new System.EventHandler(this.tsb_timPN_Click);
            // 
            // NhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1411, 683);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgv_qlNhapHang);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label10);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NhapHang";
            this.Text = "NhapHang";
            this.Load += new System.EventHandler(this.NhapHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_qlNhapHang)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgv_qlNhapHang;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbb_trangThai;
        private System.Windows.Forms.DateTimePicker dt_ngayNhap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_tongTien;
        private System.Windows.Forms.TextBox txt_maPN;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbb_mNCC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn coll_MaPhieuNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn coll_NgayNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn coll_MaNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn coll_MaNhaCungCap;
        private System.Windows.Forms.DataGridViewTextBoxColumn coll_TongTien;
        private System.Windows.Forms.DataGridViewComboBoxColumn coll_TrangThai;
        private System.Windows.Forms.ToolStripButton tsb_themPN;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton tsb_xoaPN;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsb_suaPN;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsb_xoaPhieuNhap;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton ts_lamMoiDS;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private System.Windows.Forms.ToolStripComboBox tscbb_loaiThongTin;
        private System.Windows.Forms.ToolStripTextBox tsTxt_nhapThongTin;
        private System.Windows.Forms.ToolStripButton tsb_timPN;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.TextBox txt_maNV;
    }
}