namespace GUI.form
{
    partial class QuanLyHoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLyHoaDon));
            this.dgv_qlHoaDon = new System.Windows.Forms.DataGridView();
            this.coll_MaHoaDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coll_NgayLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coll_MaNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coll_MaKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coll_TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coll_HinhThucTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coll_TrangThai = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbb_mkh = new System.Windows.Forms.ComboBox();
            this.cbb_mnv = new System.Windows.Forms.ComboBox();
            this.cbb_hinhThuc = new System.Windows.Forms.ComboBox();
            this.dt_ngayLap = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_tongTien = new System.Windows.Forms.TextBox();
            this.txt_maHoaDon = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsb_themHoaDon = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.tsb_xoaHoaDon = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsb_suaHoaDon = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsb_xoaPhieuNhap = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ts_lamMoiDS = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.tscbb_loaiThongTin = new System.Windows.Forms.ToolStripComboBox();
            this.tsTxt_nhapThongTin = new System.Windows.Forms.ToolStripTextBox();
            this.tsb_timHD = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_qlHoaDon)).BeginInit();
            this.panel2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_qlHoaDon
            // 
            this.dgv_qlHoaDon.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgv_qlHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_qlHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.coll_MaHoaDon,
            this.coll_NgayLap,
            this.coll_MaNhanVien,
            this.coll_MaKhachHang,
            this.coll_TongTien,
            this.coll_HinhThucTT,
            this.coll_TrangThai});
            this.dgv_qlHoaDon.Location = new System.Drawing.Point(13, 208);
            this.dgv_qlHoaDon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_qlHoaDon.Name = "dgv_qlHoaDon";
            this.dgv_qlHoaDon.RowHeadersWidth = 51;
            this.dgv_qlHoaDon.RowTemplate.Height = 24;
            this.dgv_qlHoaDon.Size = new System.Drawing.Size(1368, 321);
            this.dgv_qlHoaDon.TabIndex = 35;
            this.dgv_qlHoaDon.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_qlHoaDon_CellDoubleClick);
            this.dgv_qlHoaDon.SelectionChanged += new System.EventHandler(this.dgv_qlHoaDon_SelectionChanged);
            // 
            // coll_MaHoaDon
            // 
            this.coll_MaHoaDon.HeaderText = "Mã Hóa Đơn";
            this.coll_MaHoaDon.MinimumWidth = 6;
            this.coll_MaHoaDon.Name = "coll_MaHoaDon";
            this.coll_MaHoaDon.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.coll_MaHoaDon.Width = 130;
            // 
            // coll_NgayLap
            // 
            this.coll_NgayLap.HeaderText = "Ngày Lập";
            this.coll_NgayLap.MinimumWidth = 6;
            this.coll_NgayLap.Name = "coll_NgayLap";
            this.coll_NgayLap.Width = 150;
            // 
            // coll_MaNhanVien
            // 
            this.coll_MaNhanVien.HeaderText = "Mã Nhân Viên";
            this.coll_MaNhanVien.MinimumWidth = 6;
            this.coll_MaNhanVien.Name = "coll_MaNhanVien";
            this.coll_MaNhanVien.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.coll_MaNhanVien.Width = 120;
            // 
            // coll_MaKhachHang
            // 
            this.coll_MaKhachHang.HeaderText = "Mã Khách Hàng";
            this.coll_MaKhachHang.MinimumWidth = 6;
            this.coll_MaKhachHang.Name = "coll_MaKhachHang";
            this.coll_MaKhachHang.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.coll_MaKhachHang.Width = 120;
            // 
            // coll_TongTien
            // 
            this.coll_TongTien.HeaderText = "Tổng Tiền ";
            this.coll_TongTien.MinimumWidth = 6;
            this.coll_TongTien.Name = "coll_TongTien";
            this.coll_TongTien.Width = 120;
            // 
            // coll_HinhThucTT
            // 
            this.coll_HinhThucTT.HeaderText = "Hình Thức Thanh Toán";
            this.coll_HinhThucTT.MinimumWidth = 6;
            this.coll_HinhThucTT.Name = "coll_HinhThucTT";
            this.coll_HinhThucTT.Width = 160;
            // 
            // coll_TrangThai
            // 
            this.coll_TrangThai.HeaderText = "Đã Thanh Toán";
            this.coll_TrangThai.MinimumWidth = 6;
            this.coll_TrangThai.Name = "coll_TrangThai";
            this.coll_TrangThai.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.coll_TrangThai.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.coll_TrangThai.Width = 150;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightBlue;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.cbb_mkh);
            this.panel2.Controls.Add(this.cbb_mnv);
            this.panel2.Controls.Add(this.cbb_hinhThuc);
            this.panel2.Controls.Add(this.dt_ngayLap);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.txt_tongTien);
            this.panel2.Controls.Add(this.txt_maHoaDon);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Location = new System.Drawing.Point(13, 36);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1367, 169);
            this.panel2.TabIndex = 30;
            // 
            // cbb_mkh
            // 
            this.cbb_mkh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_mkh.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_mkh.FormattingEnabled = true;
            this.cbb_mkh.Location = new System.Drawing.Point(1141, 31);
            this.cbb_mkh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbb_mkh.Name = "cbb_mkh";
            this.cbb_mkh.Size = new System.Drawing.Size(180, 27);
            this.cbb_mkh.TabIndex = 24;
            // 
            // cbb_mnv
            // 
            this.cbb_mnv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_mnv.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_mnv.FormattingEnabled = true;
            this.cbb_mnv.Location = new System.Drawing.Point(675, 28);
            this.cbb_mnv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbb_mnv.Name = "cbb_mnv";
            this.cbb_mnv.Size = new System.Drawing.Size(180, 27);
            this.cbb_mnv.TabIndex = 23;
            // 
            // cbb_hinhThuc
            // 
            this.cbb_hinhThuc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_hinhThuc.FormattingEnabled = true;
            this.cbb_hinhThuc.Location = new System.Drawing.Point(216, 113);
            this.cbb_hinhThuc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbb_hinhThuc.Name = "cbb_hinhThuc";
            this.cbb_hinhThuc.Size = new System.Drawing.Size(180, 24);
            this.cbb_hinhThuc.TabIndex = 22;
            // 
            // dt_ngayLap
            // 
            this.dt_ngayLap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_ngayLap.Location = new System.Drawing.Point(697, 112);
            this.dt_ngayLap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dt_ngayLap.Name = "dt_ngayLap";
            this.dt_ngayLap.Size = new System.Drawing.Size(125, 22);
            this.dt_ngayLap.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 20;
            this.label1.Text = "Hình Thức";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(975, 32);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(146, 23);
            this.label15.TabIndex = 18;
            this.label15.Text = "Mã Khách Hàng";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(507, 28);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(129, 23);
            this.label14.TabIndex = 17;
            this.label14.Text = "Mã Nhân Viên";
            // 
            // txt_tongTien
            // 
            this.txt_tongTien.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tongTien.Location = new System.Drawing.Point(1143, 108);
            this.txt_tongTien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_tongTien.Multiline = true;
            this.txt_tongTien.Name = "txt_tongTien";
            this.txt_tongTien.Size = new System.Drawing.Size(180, 34);
            this.txt_tongTien.TabIndex = 10;
            this.txt_tongTien.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_tongTien_KeyPress);
            // 
            // txt_maHoaDon
            // 
            this.txt_maHoaDon.Enabled = false;
            this.txt_maHoaDon.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_maHoaDon.Location = new System.Drawing.Point(216, 28);
            this.txt_maHoaDon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_maHoaDon.Multiline = true;
            this.txt_maHoaDon.Name = "txt_maHoaDon";
            this.txt_maHoaDon.ReadOnly = true;
            this.txt_maHoaDon.Size = new System.Drawing.Size(180, 34);
            this.txt_maHoaDon.TabIndex = 8;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(577, 111);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 23);
            this.label12.TabIndex = 5;
            this.label12.Text = "Ngày Lập";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(987, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 23);
            this.label8.TabIndex = 4;
            this.label8.Text = "Tổng Tiền";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(59, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 23);
            this.label9.TabIndex = 5;
            this.label9.Text = "Mã Hóa Đơn ";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_themHoaDon,
            this.toolStripSeparator,
            this.tsb_xoaHoaDon,
            this.toolStripSeparator2,
            this.tsb_suaHoaDon,
            this.toolStripSeparator3,
            this.tsb_xoaPhieuNhap,
            this.toolStripSeparator1,
            this.ts_lamMoiDS,
            this.toolStripSeparator6,
            this.toolStripTextBox2,
            this.tscbb_loaiThongTin,
            this.tsTxt_nhapThongTin,
            this.tsb_timHD,
            this.toolStripSeparator5});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1411, 31);
            this.toolStrip1.TabIndex = 37;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsb_themHoaDon
            // 
            this.tsb_themHoaDon.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_themHoaDon.Image = ((System.Drawing.Image)(resources.GetObject("tsb_themHoaDon.Image")));
            this.tsb_themHoaDon.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_themHoaDon.Name = "tsb_themHoaDon";
            this.tsb_themHoaDon.Size = new System.Drawing.Size(29, 28);
            this.tsb_themHoaDon.Text = "&Thêm Hóa Đơn";
            this.tsb_themHoaDon.Click += new System.EventHandler(this.tsb_themHoaDon_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 28);
            // 
            // tsb_xoaHoaDon
            // 
            this.tsb_xoaHoaDon.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_xoaHoaDon.Image = ((System.Drawing.Image)(resources.GetObject("tsb_xoaHoaDon.Image")));
            this.tsb_xoaHoaDon.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_xoaHoaDon.Name = "tsb_xoaHoaDon";
            this.tsb_xoaHoaDon.Size = new System.Drawing.Size(29, 25);
            this.tsb_xoaHoaDon.Text = "&Xóa Hóa Đơn";
            this.tsb_xoaHoaDon.Click += new System.EventHandler(this.tsb_xoaHoaDon_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 28);
            // 
            // tsb_suaHoaDon
            // 
            this.tsb_suaHoaDon.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_suaHoaDon.Image = ((System.Drawing.Image)(resources.GetObject("tsb_suaHoaDon.Image")));
            this.tsb_suaHoaDon.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_suaHoaDon.Name = "tsb_suaHoaDon";
            this.tsb_suaHoaDon.Size = new System.Drawing.Size(29, 25);
            this.tsb_suaHoaDon.Text = "&Sửa Hóa Đơn";
            this.tsb_suaHoaDon.Click += new System.EventHandler(this.tsb_suaHoaDon_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 28);
            // 
            // tsb_xoaPhieuNhap
            // 
            this.tsb_xoaPhieuNhap.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_xoaPhieuNhap.Image = ((System.Drawing.Image)(resources.GetObject("tsb_xoaPhieuNhap.Image")));
            this.tsb_xoaPhieuNhap.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_xoaPhieuNhap.Name = "tsb_xoaPhieuNhap";
            this.tsb_xoaPhieuNhap.Size = new System.Drawing.Size(29, 25);
            this.tsb_xoaPhieuNhap.Text = "&Xóa Phiếu Nhập";
            this.tsb_xoaPhieuNhap.Click += new System.EventHandler(this.tsb_xoaPhieuNhap_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 28);
            // 
            // ts_lamMoiDS
            // 
            this.ts_lamMoiDS.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ts_lamMoiDS.Image = ((System.Drawing.Image)(resources.GetObject("ts_lamMoiDS.Image")));
            this.ts_lamMoiDS.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_lamMoiDS.Name = "ts_lamMoiDS";
            this.ts_lamMoiDS.Size = new System.Drawing.Size(29, 25);
            this.ts_lamMoiDS.Text = "&Làm Mới Danh Sách";
            this.ts_lamMoiDS.Click += new System.EventHandler(this.ts_lamMoiDS_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 28);
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.Enabled = false;
            this.toolStripTextBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.ReadOnly = true;
            this.toolStripTextBox2.Size = new System.Drawing.Size(100, 28);
            this.toolStripTextBox2.Text = "Search";
            // 
            // tscbb_loaiThongTin
            // 
            this.tscbb_loaiThongTin.Name = "tscbb_loaiThongTin";
            this.tscbb_loaiThongTin.Size = new System.Drawing.Size(140, 28);
            this.tscbb_loaiThongTin.Text = "Loại Thông Tin";
            this.tscbb_loaiThongTin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tscbb_loaiThongTin_KeyPress);
            // 
            // tsTxt_nhapThongTin
            // 
            this.tsTxt_nhapThongTin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tsTxt_nhapThongTin.Name = "tsTxt_nhapThongTin";
            this.tsTxt_nhapThongTin.Size = new System.Drawing.Size(100, 28);
            this.tsTxt_nhapThongTin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tsTxt_nhapThongTin_KeyPress);
            // 
            // tsb_timHD
            // 
            this.tsb_timHD.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_timHD.Image = ((System.Drawing.Image)(resources.GetObject("tsb_timHD.Image")));
            this.tsb_timHD.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_timHD.Name = "tsb_timHD";
            this.tsb_timHD.Size = new System.Drawing.Size(29, 25);
            this.tsb_timHD.Text = "&Tìm Hóa Đơn";
            this.tsb_timHD.Click += new System.EventHandler(this.tsb_timHD_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 28);
            // 
            // QuanLyHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1411, 683);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgv_qlHoaDon);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "QuanLyHoaDon";
            this.Text = "QuanLyHoaDon";
            this.Load += new System.EventHandler(this.QuanLyHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_qlHoaDon)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_qlHoaDon;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_tongTien;
        private System.Windows.Forms.TextBox txt_maHoaDon;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dt_ngayLap;
        private System.Windows.Forms.ComboBox cbb_hinhThuc;
        private System.Windows.Forms.ComboBox cbb_mnv;
        private System.Windows.Forms.ComboBox cbb_mkh;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsb_themHoaDon;
        private System.Windows.Forms.ToolStripButton tsb_xoaHoaDon;
        private System.Windows.Forms.ToolStripButton tsb_suaHoaDon;
        private System.Windows.Forms.ToolStripButton tsb_xoaPhieuNhap;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripComboBox tscbb_loaiThongTin;
        private System.Windows.Forms.ToolStripTextBox tsTxt_nhapThongTin;
        private System.Windows.Forms.ToolStripButton tsb_timHD;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton ts_lamMoiDS;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.DataGridViewTextBoxColumn coll_MaHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn coll_NgayLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn coll_MaNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn coll_MaKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn coll_TongTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn coll_HinhThucTT;
        private System.Windows.Forms.DataGridViewCheckBoxColumn coll_TrangThai;
    }
}