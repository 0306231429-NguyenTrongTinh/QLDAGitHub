namespace GUI.form
{
    partial class NhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NhanVien));
            this.dgv_nhanVien = new System.Windows.Forms.DataGridView();
            this.coll_MaNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coll_HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coll_NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coll_GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coll_SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coll_ChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coll_Luong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coll_TrangThai = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dt_ngaySinh = new System.Windows.Forms.DateTimePicker();
            this.cbb_chucVu = new System.Windows.Forms.ComboBox();
            this.cbb_gioiTinh = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_luong = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_sdt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_tienGuiTra = new System.Windows.Forms.TextBox();
            this.txt_hoTen = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsb_themNhanVien = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.tsb_xoaNhanVien = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsb_suaNhanVien = new System.Windows.Forms.ToolStripButton();
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
            this.tstxt_maNhanVien = new System.Windows.Forms.ToolStripTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nhanVien)).BeginInit();
            this.panel2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_nhanVien
            // 
            this.dgv_nhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_nhanVien.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgv_nhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_nhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.coll_MaNhanVien,
            this.coll_HoTen,
            this.coll_NgaySinh,
            this.coll_GioiTinh,
            this.coll_SDT,
            this.coll_ChucVu,
            this.coll_Luong,
            this.coll_TrangThai});
            this.dgv_nhanVien.Location = new System.Drawing.Point(101, 287);
            this.dgv_nhanVien.Name = "dgv_nhanVien";
            this.dgv_nhanVien.RowHeadersWidth = 51;
            this.dgv_nhanVien.RowTemplate.Height = 24;
            this.dgv_nhanVien.Size = new System.Drawing.Size(1181, 200);
            this.dgv_nhanVien.TabIndex = 38;
            this.dgv_nhanVien.SelectionChanged += new System.EventHandler(this.dgv_nhanVien_SelectionChanged);
            // 
            // coll_MaNhanVien
            // 
            this.coll_MaNhanVien.HeaderText = "Mã Nhân Viên";
            this.coll_MaNhanVien.MinimumWidth = 6;
            this.coll_MaNhanVien.Name = "coll_MaNhanVien";
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
            // coll_SDT
            // 
            this.coll_SDT.HeaderText = "Số Điện Thoại";
            this.coll_SDT.MinimumWidth = 6;
            this.coll_SDT.Name = "coll_SDT";
            // 
            // coll_ChucVu
            // 
            this.coll_ChucVu.HeaderText = "Chức Vụ ";
            this.coll_ChucVu.MinimumWidth = 6;
            this.coll_ChucVu.Name = "coll_ChucVu";
            // 
            // coll_Luong
            // 
            this.coll_Luong.HeaderText = "Lương ";
            this.coll_Luong.MinimumWidth = 6;
            this.coll_Luong.Name = "coll_Luong";
            // 
            // coll_TrangThai
            // 
            this.coll_TrangThai.HeaderText = "Đang Làm";
            this.coll_TrangThai.MinimumWidth = 6;
            this.coll_TrangThai.Name = "coll_TrangThai";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightBlue;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dt_ngaySinh);
            this.panel2.Controls.Add(this.cbb_chucVu);
            this.panel2.Controls.Add(this.cbb_gioiTinh);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txt_luong);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.txt_sdt);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txt_tienGuiTra);
            this.panel2.Controls.Add(this.txt_hoTen);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(106, 61);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1176, 220);
            this.panel2.TabIndex = 37;
            // 
            // dt_ngaySinh
            // 
            this.dt_ngaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_ngaySinh.Location = new System.Drawing.Point(849, 22);
            this.dt_ngaySinh.Name = "dt_ngaySinh";
            this.dt_ngaySinh.Size = new System.Drawing.Size(200, 22);
            this.dt_ngaySinh.TabIndex = 33;
            // 
            // cbb_chucVu
            // 
            this.cbb_chucVu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_chucVu.FormattingEnabled = true;
            this.cbb_chucVu.Location = new System.Drawing.Point(181, 166);
            this.cbb_chucVu.Name = "cbb_chucVu";
            this.cbb_chucVu.Size = new System.Drawing.Size(121, 24);
            this.cbb_chucVu.TabIndex = 23;
            // 
            // cbb_gioiTinh
            // 
            this.cbb_gioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_gioiTinh.FormattingEnabled = true;
            this.cbb_gioiTinh.Location = new System.Drawing.Point(181, 94);
            this.cbb_gioiTinh.Name = "cbb_gioiTinh";
            this.cbb_gioiTinh.Size = new System.Drawing.Size(121, 24);
            this.cbb_gioiTinh.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(78, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 19);
            this.label2.TabIndex = 21;
            this.label2.Text = "Giói Tính:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(703, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 19);
            this.label1.TabIndex = 20;
            this.label1.Text = "Lương";
            // 
            // txt_luong
            // 
            this.txt_luong.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_luong.Location = new System.Drawing.Point(849, 168);
            this.txt_luong.Multiline = true;
            this.txt_luong.Name = "txt_luong";
            this.txt_luong.Size = new System.Drawing.Size(216, 27);
            this.txt_luong.TabIndex = 19;
            this.txt_luong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_luong_KeyPress);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(657, 100);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(118, 19);
            this.label15.TabIndex = 18;
            this.label15.Text = "Số Điện Thoại:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(686, 25);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(89, 19);
            this.label14.TabIndex = 17;
            this.label14.Text = "Ngày Sinh:";
            // 
            // txt_sdt
            // 
            this.txt_sdt.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sdt.Location = new System.Drawing.Point(849, 91);
            this.txt_sdt.Multiline = true;
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.Size = new System.Drawing.Size(216, 27);
            this.txt_sdt.TabIndex = 16;
            this.txt_sdt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_sdt_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(825, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Tiền gửi trả";
            // 
            // txt_tienGuiTra
            // 
            this.txt_tienGuiTra.Location = new System.Drawing.Point(942, 243);
            this.txt_tienGuiTra.Name = "txt_tienGuiTra";
            this.txt_tienGuiTra.Size = new System.Drawing.Size(100, 22);
            this.txt_tienGuiTra.TabIndex = 10;
            // 
            // txt_hoTen
            // 
            this.txt_hoTen.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_hoTen.Location = new System.Drawing.Point(181, 25);
            this.txt_hoTen.Multiline = true;
            this.txt_hoTen.Name = "txt_hoTen";
            this.txt_hoTen.Size = new System.Drawing.Size(216, 27);
            this.txt_hoTen.TabIndex = 10;
            this.txt_hoTen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_hoTen_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(98, 29);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 19);
            this.label12.TabIndex = 5;
            this.label12.Text = "Họ Tên:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(94, 171);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 19);
            this.label8.TabIndex = 4;
            this.label8.Text = "Chức Vụ";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_themNhanVien,
            this.toolStripSeparator,
            this.tsb_xoaNhanVien,
            this.toolStripSeparator2,
            this.tsb_suaNhanVien,
            this.toolStripSeparator3,
            this.tsb_xoaPhieuNhap,
            this.toolStripSeparator1,
            this.ts_lamMoiDS,
            this.toolStripSeparator6,
            this.toolStripTextBox2,
            this.tscbb_loaiThongTin,
            this.tsTxt_nhapThongTin,
            this.tsb_timHD,
            this.toolStripSeparator5,
            this.tstxt_maNhanVien});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1410, 31);
            this.toolStrip1.TabIndex = 40;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsb_themNhanVien
            // 
            this.tsb_themNhanVien.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_themNhanVien.Image = ((System.Drawing.Image)(resources.GetObject("tsb_themNhanVien.Image")));
            this.tsb_themNhanVien.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_themNhanVien.Name = "tsb_themNhanVien";
            this.tsb_themNhanVien.Size = new System.Drawing.Size(29, 28);
            this.tsb_themNhanVien.Text = "&Thêm Nhân Viên";
            this.tsb_themNhanVien.Click += new System.EventHandler(this.tsb_themNhanVien_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 28);
            // 
            // tsb_xoaNhanVien
            // 
            this.tsb_xoaNhanVien.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_xoaNhanVien.Image = ((System.Drawing.Image)(resources.GetObject("tsb_xoaNhanVien.Image")));
            this.tsb_xoaNhanVien.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_xoaNhanVien.Name = "tsb_xoaNhanVien";
            this.tsb_xoaNhanVien.Size = new System.Drawing.Size(29, 25);
            this.tsb_xoaNhanVien.Text = "&Xóa Nhân Viên";
            this.tsb_xoaNhanVien.Click += new System.EventHandler(this.tsb_xoaNhanVien_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 28);
            // 
            // tsb_suaNhanVien
            // 
            this.tsb_suaNhanVien.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_suaNhanVien.Image = ((System.Drawing.Image)(resources.GetObject("tsb_suaNhanVien.Image")));
            this.tsb_suaNhanVien.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_suaNhanVien.Name = "tsb_suaNhanVien";
            this.tsb_suaNhanVien.Size = new System.Drawing.Size(29, 25);
            this.tsb_suaNhanVien.Text = "&Sửa Nhân Viên";
            this.tsb_suaNhanVien.Click += new System.EventHandler(this.tsb_suaNhanVien_Click);
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
            // tstxt_maNhanVien
            // 
            this.tstxt_maNhanVien.Enabled = false;
            this.tstxt_maNhanVien.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tstxt_maNhanVien.Name = "tstxt_maNhanVien";
            this.tstxt_maNhanVien.Size = new System.Drawing.Size(100, 28);
            // 
            // NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1410, 683);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgv_nhanVien);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NhanVien";
            this.Text = "NhanVien";
            this.Load += new System.EventHandler(this.NhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nhanVien)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_nhanVien;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dt_ngaySinh;
        private System.Windows.Forms.ComboBox cbb_chucVu;
        private System.Windows.Forms.ComboBox cbb_gioiTinh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_luong;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_sdt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_tienGuiTra;
        private System.Windows.Forms.TextBox txt_hoTen;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsb_themNhanVien;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton tsb_xoaNhanVien;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsb_suaNhanVien;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsb_xoaPhieuNhap;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton ts_lamMoiDS;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private System.Windows.Forms.ToolStripComboBox tscbb_loaiThongTin;
        private System.Windows.Forms.ToolStripTextBox tsTxt_nhapThongTin;
        private System.Windows.Forms.ToolStripButton tsb_timHD;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.DataGridViewTextBoxColumn coll_MaNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn coll_HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn coll_NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn coll_GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn coll_SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn coll_ChucVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn coll_Luong;
        private System.Windows.Forms.DataGridViewCheckBoxColumn coll_TrangThai;
        private System.Windows.Forms.ToolStripTextBox tstxt_maNhanVien;
    }
}