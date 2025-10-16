namespace GUI.form
{
    partial class KhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KhachHang));
            this.dgv_khachHang = new System.Windows.Forms.DataGridView();
            this.coll_MaKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coll_HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coll_NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coll_GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coll_DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coll_SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coll_DiemTichLuy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coll_ThanhVien = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.nud_diemTL = new System.Windows.Forms.NumericUpDown();
            this.dt_ngaySinh = new System.Windows.Forms.DateTimePicker();
            this.cbb_loaiKH = new System.Windows.Forms.ComboBox();
            this.cbb_gioiTinh = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_diaChi = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_sdt = new System.Windows.Forms.TextBox();
            this.txt_hoTenKH = new System.Windows.Forms.TextBox();
            this.txt_maKhachHang = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsb_themKhachHang = new System.Windows.Forms.ToolStripButton();
            this.ts_1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsb_xoaKH = new System.Windows.Forms.ToolStripButton();
            this.ts_2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsb_suaKH = new System.Windows.Forms.ToolStripButton();
            this.ts_3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsb_xoaPhieuNhap = new System.Windows.Forms.ToolStripButton();
            this.ts_4 = new System.Windows.Forms.ToolStripSeparator();
            this.ts_lamMoiDS = new System.Windows.Forms.ToolStripButton();
            this.ts_5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.tscbb_loaiThongTin = new System.Windows.Forms.ToolStripComboBox();
            this.tsTxt_nhapThongTin = new System.Windows.Forms.ToolStripTextBox();
            this.tsb_timKH = new System.Windows.Forms.ToolStripButton();
            this.ts_6 = new System.Windows.Forms.ToolStripSeparator();
            this.tsb_themKHfroNV = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_khachHang)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_diemTL)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_khachHang
            // 
            this.dgv_khachHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_khachHang.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgv_khachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_khachHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.coll_MaKhachHang,
            this.coll_HoTen,
            this.coll_NgaySinh,
            this.coll_GioiTinh,
            this.coll_DiaChi,
            this.coll_SDT,
            this.coll_DiemTichLuy,
            this.coll_ThanhVien});
            this.dgv_khachHang.Location = new System.Drawing.Point(17, 292);
            this.dgv_khachHang.Name = "dgv_khachHang";
            this.dgv_khachHang.RowHeadersWidth = 51;
            this.dgv_khachHang.RowTemplate.Height = 24;
            this.dgv_khachHang.Size = new System.Drawing.Size(1361, 200);
            this.dgv_khachHang.TabIndex = 35;
            this.dgv_khachHang.SelectionChanged += new System.EventHandler(this.dgv_khachHang_SelectionChanged);
            // 
            // coll_MaKhachHang
            // 
            this.coll_MaKhachHang.HeaderText = "Mã Khách Hàng";
            this.coll_MaKhachHang.MinimumWidth = 6;
            this.coll_MaKhachHang.Name = "coll_MaKhachHang";
            // 
            // coll_HoTen
            // 
            this.coll_HoTen.HeaderText = "Họ Tên ";
            this.coll_HoTen.MinimumWidth = 6;
            this.coll_HoTen.Name = "coll_HoTen";
            // 
            // coll_NgaySinh
            // 
            this.coll_NgaySinh.HeaderText = "Ngày Sinh";
            this.coll_NgaySinh.MinimumWidth = 6;
            this.coll_NgaySinh.Name = "coll_NgaySinh";
            // 
            // coll_GioiTinh
            // 
            this.coll_GioiTinh.HeaderText = "Giới Tính";
            this.coll_GioiTinh.MinimumWidth = 6;
            this.coll_GioiTinh.Name = "coll_GioiTinh";
            // 
            // coll_DiaChi
            // 
            this.coll_DiaChi.HeaderText = "Địa Chỉ";
            this.coll_DiaChi.MinimumWidth = 6;
            this.coll_DiaChi.Name = "coll_DiaChi";
            // 
            // coll_SDT
            // 
            this.coll_SDT.HeaderText = "Số Điện Thoại";
            this.coll_SDT.MinimumWidth = 6;
            this.coll_SDT.Name = "coll_SDT";
            // 
            // coll_DiemTichLuy
            // 
            this.coll_DiemTichLuy.HeaderText = "Điểm Tích Lũy";
            this.coll_DiemTichLuy.MinimumWidth = 6;
            this.coll_DiemTichLuy.Name = "coll_DiemTichLuy";
            // 
            // coll_ThanhVien
            // 
            this.coll_ThanhVien.HeaderText = "Thành Viên";
            this.coll_ThanhVien.MinimumWidth = 6;
            this.coll_ThanhVien.Name = "coll_ThanhVien";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightBlue;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.nud_diemTL);
            this.panel2.Controls.Add(this.dt_ngaySinh);
            this.panel2.Controls.Add(this.cbb_loaiKH);
            this.panel2.Controls.Add(this.cbb_gioiTinh);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txt_diaChi);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.txt_sdt);
            this.panel2.Controls.Add(this.txt_hoTenKH);
            this.panel2.Controls.Add(this.txt_maKhachHang);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Location = new System.Drawing.Point(17, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1361, 223);
            this.panel2.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1072, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 19);
            this.label3.TabIndex = 35;
            this.label3.Text = "Điểm Tích Lũy:";
            // 
            // nud_diemTL
            // 
            this.nud_diemTL.Enabled = false;
            this.nud_diemTL.Location = new System.Drawing.Point(1076, 169);
            this.nud_diemTL.Name = "nud_diemTL";
            this.nud_diemTL.Size = new System.Drawing.Size(120, 22);
            this.nud_diemTL.TabIndex = 34;
            // 
            // dt_ngaySinh
            // 
            this.dt_ngaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_ngaySinh.Location = new System.Drawing.Point(710, 73);
            this.dt_ngaySinh.Name = "dt_ngaySinh";
            this.dt_ngaySinh.Size = new System.Drawing.Size(200, 22);
            this.dt_ngaySinh.TabIndex = 33;
            // 
            // cbb_loaiKH
            // 
            this.cbb_loaiKH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_loaiKH.FormattingEnabled = true;
            this.cbb_loaiKH.Location = new System.Drawing.Point(429, 167);
            this.cbb_loaiKH.Name = "cbb_loaiKH";
            this.cbb_loaiKH.Size = new System.Drawing.Size(121, 24);
            this.cbb_loaiKH.TabIndex = 23;
            // 
            // cbb_gioiTinh
            // 
            this.cbb_gioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_gioiTinh.FormattingEnabled = true;
            this.cbb_gioiTinh.Location = new System.Drawing.Point(429, 71);
            this.cbb_gioiTinh.Name = "cbb_gioiTinh";
            this.cbb_gioiTinh.Size = new System.Drawing.Size(121, 24);
            this.cbb_gioiTinh.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(425, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 19);
            this.label2.TabIndex = 21;
            this.label2.Text = "Giói Tính:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1072, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 19);
            this.label1.TabIndex = 20;
            this.label1.Text = "Địa Chỉ:";
            // 
            // txt_diaChi
            // 
            this.txt_diaChi.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_diaChi.Location = new System.Drawing.Point(1076, 68);
            this.txt_diaChi.Multiline = true;
            this.txt_diaChi.Name = "txt_diaChi";
            this.txt_diaChi.Size = new System.Drawing.Size(216, 27);
            this.txt_diaChi.TabIndex = 19;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(706, 132);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(118, 19);
            this.label15.TabIndex = 18;
            this.label15.Text = "Số Điện Thoại:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(706, 39);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(89, 19);
            this.label14.TabIndex = 17;
            this.label14.Text = "Ngày Sinh:";
            // 
            // txt_sdt
            // 
            this.txt_sdt.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sdt.Location = new System.Drawing.Point(710, 164);
            this.txt_sdt.Multiline = true;
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.Size = new System.Drawing.Size(216, 27);
            this.txt_sdt.TabIndex = 16;
            this.txt_sdt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_sdt_KeyPress);
            // 
            // txt_hoTenKH
            // 
            this.txt_hoTenKH.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_hoTenKH.Location = new System.Drawing.Point(71, 164);
            this.txt_hoTenKH.Multiline = true;
            this.txt_hoTenKH.Name = "txt_hoTenKH";
            this.txt_hoTenKH.Size = new System.Drawing.Size(216, 27);
            this.txt_hoTenKH.TabIndex = 10;
            this.txt_hoTenKH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_hoTenKH_KeyPress);
            // 
            // txt_maKhachHang
            // 
            this.txt_maKhachHang.Enabled = false;
            this.txt_maKhachHang.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_maKhachHang.Location = new System.Drawing.Point(71, 68);
            this.txt_maKhachHang.Multiline = true;
            this.txt_maKhachHang.Name = "txt_maKhachHang";
            this.txt_maKhachHang.ReadOnly = true;
            this.txt_maKhachHang.Size = new System.Drawing.Size(216, 27);
            this.txt_maKhachHang.TabIndex = 8;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(71, 132);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 19);
            this.label12.TabIndex = 5;
            this.label12.Text = "Họ Tên:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(425, 132);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 19);
            this.label8.TabIndex = 4;
            this.label8.Text = "Loại Khách Hàng:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(67, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 19);
            this.label9.TabIndex = 5;
            this.label9.Text = "Mã Khách Hàng:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_themKhachHang,
            this.ts_1,
            this.tsb_xoaKH,
            this.ts_2,
            this.tsb_suaKH,
            this.ts_3,
            this.tsb_xoaPhieuNhap,
            this.ts_4,
            this.ts_lamMoiDS,
            this.ts_5,
            this.toolStripTextBox2,
            this.tscbb_loaiThongTin,
            this.tsTxt_nhapThongTin,
            this.tsb_timKH,
            this.ts_6,
            this.tsb_themKHfroNV});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1410, 28);
            this.toolStrip1.TabIndex = 38;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsb_themKhachHang
            // 
            this.tsb_themKhachHang.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_themKhachHang.Image = ((System.Drawing.Image)(resources.GetObject("tsb_themKhachHang.Image")));
            this.tsb_themKhachHang.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_themKhachHang.Name = "tsb_themKhachHang";
            this.tsb_themKhachHang.Size = new System.Drawing.Size(29, 25);
            this.tsb_themKhachHang.Text = "&Thêm Khách Hàng";
            this.tsb_themKhachHang.Click += new System.EventHandler(this.tsb_themKhachHang_Click);
            // 
            // ts_1
            // 
            this.ts_1.Name = "ts_1";
            this.ts_1.Size = new System.Drawing.Size(6, 28);
            // 
            // tsb_xoaKH
            // 
            this.tsb_xoaKH.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_xoaKH.Image = ((System.Drawing.Image)(resources.GetObject("tsb_xoaKH.Image")));
            this.tsb_xoaKH.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_xoaKH.Name = "tsb_xoaKH";
            this.tsb_xoaKH.Size = new System.Drawing.Size(29, 25);
            this.tsb_xoaKH.Text = "&Xóa Khách Hàng";
            this.tsb_xoaKH.Click += new System.EventHandler(this.tsb_xoaKH_Click);
            // 
            // ts_2
            // 
            this.ts_2.Name = "ts_2";
            this.ts_2.Size = new System.Drawing.Size(6, 28);
            // 
            // tsb_suaKH
            // 
            this.tsb_suaKH.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_suaKH.Image = ((System.Drawing.Image)(resources.GetObject("tsb_suaKH.Image")));
            this.tsb_suaKH.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_suaKH.Name = "tsb_suaKH";
            this.tsb_suaKH.Size = new System.Drawing.Size(29, 25);
            this.tsb_suaKH.Text = "&Sửa Thông Tin Khách Hàng ";
            this.tsb_suaKH.Click += new System.EventHandler(this.tsb_suaKH_Click);
            // 
            // ts_3
            // 
            this.ts_3.Name = "ts_3";
            this.ts_3.Size = new System.Drawing.Size(6, 28);
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
            // ts_4
            // 
            this.ts_4.Name = "ts_4";
            this.ts_4.Size = new System.Drawing.Size(6, 28);
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
            // ts_5
            // 
            this.ts_5.Name = "ts_5";
            this.ts_5.Size = new System.Drawing.Size(6, 28);
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
            // tsb_timKH
            // 
            this.tsb_timKH.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_timKH.Image = ((System.Drawing.Image)(resources.GetObject("tsb_timKH.Image")));
            this.tsb_timKH.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_timKH.Name = "tsb_timKH";
            this.tsb_timKH.Size = new System.Drawing.Size(29, 25);
            this.tsb_timKH.Text = "&Tìm Khách Hàng";
            this.tsb_timKH.Click += new System.EventHandler(this.tsb_timKH_Click);
            // 
            // ts_6
            // 
            this.ts_6.Name = "ts_6";
            this.ts_6.Size = new System.Drawing.Size(6, 28);
            // 
            // tsb_themKHfroNV
            // 
            this.tsb_themKHfroNV.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_themKHfroNV.Image = ((System.Drawing.Image)(resources.GetObject("tsb_themKHfroNV.Image")));
            this.tsb_themKHfroNV.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_themKHfroNV.Name = "tsb_themKHfroNV";
            this.tsb_themKHfroNV.Size = new System.Drawing.Size(29, 25);
            this.tsb_themKHfroNV.Text = "&Thêm Khách Hàng";
            this.tsb_themKHfroNV.Click += new System.EventHandler(this.tsb_themKHfroNV_Click);
            // 
            // KhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1410, 683);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgv_khachHang);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "KhachHang";
            this.Text = "KhachHang";
            this.Load += new System.EventHandler(this.KhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_khachHang)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_diemTL)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_khachHang;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_diaChi;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_sdt;
        private System.Windows.Forms.TextBox txt_hoTenKH;
        private System.Windows.Forms.TextBox txt_maKhachHang;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbb_loaiKH;
        private System.Windows.Forms.ComboBox cbb_gioiTinh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dt_ngaySinh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nud_diemTL;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsb_themKhachHang;
        private System.Windows.Forms.ToolStripSeparator ts_1;
        private System.Windows.Forms.ToolStripButton tsb_xoaKH;
        private System.Windows.Forms.ToolStripSeparator ts_2;
        private System.Windows.Forms.ToolStripButton tsb_suaKH;
        private System.Windows.Forms.ToolStripSeparator ts_3;
        private System.Windows.Forms.ToolStripButton tsb_xoaPhieuNhap;
        private System.Windows.Forms.ToolStripSeparator ts_4;
        private System.Windows.Forms.ToolStripButton ts_lamMoiDS;
        private System.Windows.Forms.ToolStripSeparator ts_5;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private System.Windows.Forms.ToolStripComboBox tscbb_loaiThongTin;
        private System.Windows.Forms.ToolStripTextBox tsTxt_nhapThongTin;
        private System.Windows.Forms.ToolStripButton tsb_timKH;
        private System.Windows.Forms.ToolStripSeparator ts_6;
        private System.Windows.Forms.DataGridViewTextBoxColumn coll_MaKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn coll_HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn coll_NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn coll_GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn coll_DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn coll_SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn coll_DiemTichLuy;
        private System.Windows.Forms.DataGridViewCheckBoxColumn coll_ThanhVien;
        private System.Windows.Forms.ToolStripButton tsb_themKHfroNV;
    }
}