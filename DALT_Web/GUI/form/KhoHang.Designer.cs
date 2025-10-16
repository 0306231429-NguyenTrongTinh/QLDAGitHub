namespace GUI.form
{
    partial class KhoHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KhoHang));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsb_themSanPham = new System.Windows.Forms.ToolStripButton();
            this.ts_1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsb_xoaSanPham = new System.Windows.Forms.ToolStripButton();
            this.ts_3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsb_suaSanPham = new System.Windows.Forms.ToolStripButton();
            this.ts_4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsb_xoaPhieuNhap = new System.Windows.Forms.ToolStripButton();
            this.ts_5 = new System.Windows.Forms.ToolStripSeparator();
            this.ts_lamMoiDS = new System.Windows.Forms.ToolStripButton();
            this.ts_6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.tscbb_maSP = new System.Windows.Forms.ToolStripComboBox();
            this.tsTxt_maSP = new System.Windows.Forms.ToolStripTextBox();
            this.tsb_timSP = new System.Windows.Forms.ToolStripButton();
            this.ts_7 = new System.Windows.Forms.ToolStripSeparator();
            this.dgv_KhoHang = new System.Windows.Forms.DataGridView();
            this.coll_MaSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coll_SoLuongTon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coll_SoLuongNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coll_GiaNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coll_GiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coll_NgayCapNhat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_giaBan = new System.Windows.Forms.TextBox();
            this.dt_ngayNhap = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_ghiChu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pb_anhSP = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_soLuongTon = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_soLuongNhap = new System.Windows.Forms.TextBox();
            this.txt_giaNhap = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_tienGuiTra = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_KhoHang)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_anhSP)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_themSanPham,
            this.ts_1,
            this.tsb_xoaSanPham,
            this.ts_3,
            this.tsb_suaSanPham,
            this.ts_4,
            this.tsb_xoaPhieuNhap,
            this.ts_5,
            this.ts_lamMoiDS,
            this.ts_6,
            this.toolStripTextBox2,
            this.tscbb_maSP,
            this.tsTxt_maSP,
            this.tsb_timSP,
            this.ts_7});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1410, 31);
            this.toolStrip1.TabIndex = 42;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsb_themSanPham
            // 
            this.tsb_themSanPham.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_themSanPham.Image = ((System.Drawing.Image)(resources.GetObject("tsb_themSanPham.Image")));
            this.tsb_themSanPham.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_themSanPham.Name = "tsb_themSanPham";
            this.tsb_themSanPham.Size = new System.Drawing.Size(29, 28);
            this.tsb_themSanPham.Text = "&Thêm Sản Phẩm";
            // 
            // ts_1
            // 
            this.ts_1.Name = "ts_1";
            this.ts_1.Size = new System.Drawing.Size(6, 28);
            // 
            // tsb_xoaSanPham
            // 
            this.tsb_xoaSanPham.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_xoaSanPham.Image = ((System.Drawing.Image)(resources.GetObject("tsb_xoaSanPham.Image")));
            this.tsb_xoaSanPham.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_xoaSanPham.Name = "tsb_xoaSanPham";
            this.tsb_xoaSanPham.Size = new System.Drawing.Size(29, 25);
            this.tsb_xoaSanPham.Text = "&Xóa Sản Phẩm";
            this.tsb_xoaSanPham.Click += new System.EventHandler(this.tsb_xoaSanPham_Click);
            // 
            // ts_3
            // 
            this.ts_3.Name = "ts_3";
            this.ts_3.Size = new System.Drawing.Size(6, 28);
            // 
            // tsb_suaSanPham
            // 
            this.tsb_suaSanPham.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_suaSanPham.Image = ((System.Drawing.Image)(resources.GetObject("tsb_suaSanPham.Image")));
            this.tsb_suaSanPham.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_suaSanPham.Name = "tsb_suaSanPham";
            this.tsb_suaSanPham.Size = new System.Drawing.Size(29, 25);
            this.tsb_suaSanPham.Text = "&Sửa Sản Phẩm";
            this.tsb_suaSanPham.Click += new System.EventHandler(this.tsb_suaSanPham_Click);
            // 
            // ts_4
            // 
            this.ts_4.Name = "ts_4";
            this.ts_4.Size = new System.Drawing.Size(6, 28);
            // 
            // tsb_xoaPhieuNhap
            // 
            this.tsb_xoaPhieuNhap.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_xoaPhieuNhap.Image = ((System.Drawing.Image)(resources.GetObject("tsb_xoaPhieuNhap.Image")));
            this.tsb_xoaPhieuNhap.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_xoaPhieuNhap.Name = "tsb_xoaPhieuNhap";
            this.tsb_xoaPhieuNhap.Size = new System.Drawing.Size(29, 25);
            this.tsb_xoaPhieuNhap.Text = "&Xóa Phiếu Nhập";
            // 
            // ts_5
            // 
            this.ts_5.Name = "ts_5";
            this.ts_5.Size = new System.Drawing.Size(6, 28);
            // 
            // ts_lamMoiDS
            // 
            this.ts_lamMoiDS.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ts_lamMoiDS.Image = ((System.Drawing.Image)(resources.GetObject("ts_lamMoiDS.Image")));
            this.ts_lamMoiDS.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_lamMoiDS.Name = "ts_lamMoiDS";
            this.ts_lamMoiDS.Size = new System.Drawing.Size(29, 25);
            this.ts_lamMoiDS.Text = "&Làm Mới Danh Sách";
            // 
            // ts_6
            // 
            this.ts_6.Name = "ts_6";
            this.ts_6.Size = new System.Drawing.Size(6, 28);
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
            // tscbb_maSP
            // 
            this.tscbb_maSP.Name = "tscbb_maSP";
            this.tscbb_maSP.Size = new System.Drawing.Size(140, 28);
            this.tscbb_maSP.Text = "Mã Sản Phẩm";
            this.tscbb_maSP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tscbb_maSP_KeyPress);
            // 
            // tsTxt_maSP
            // 
            this.tsTxt_maSP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tsTxt_maSP.Name = "tsTxt_maSP";
            this.tsTxt_maSP.Size = new System.Drawing.Size(100, 28);
            this.tsTxt_maSP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tsTxt_maSP_KeyPress);
            // 
            // tsb_timSP
            // 
            this.tsb_timSP.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_timSP.Image = ((System.Drawing.Image)(resources.GetObject("tsb_timSP.Image")));
            this.tsb_timSP.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_timSP.Name = "tsb_timSP";
            this.tsb_timSP.Size = new System.Drawing.Size(29, 25);
            this.tsb_timSP.Text = "&Tìm Hóa Đơn";
            // 
            // ts_7
            // 
            this.ts_7.Name = "ts_7";
            this.ts_7.Size = new System.Drawing.Size(6, 28);
            // 
            // dgv_KhoHang
            // 
            this.dgv_KhoHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_KhoHang.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgv_KhoHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_KhoHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.coll_MaSanPham,
            this.coll_SoLuongTon,
            this.coll_SoLuongNhap,
            this.coll_GiaNhap,
            this.coll_GiaBan,
            this.coll_NgayCapNhat});
            this.dgv_KhoHang.Location = new System.Drawing.Point(12, 290);
            this.dgv_KhoHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_KhoHang.Name = "dgv_KhoHang";
            this.dgv_KhoHang.RowHeadersWidth = 51;
            this.dgv_KhoHang.RowTemplate.Height = 24;
            this.dgv_KhoHang.Size = new System.Drawing.Size(1363, 226);
            this.dgv_KhoHang.TabIndex = 41;
            this.dgv_KhoHang.SelectionChanged += new System.EventHandler(this.dgv_KhoHang_SelectionChanged);
            // 
            // coll_MaSanPham
            // 
            this.coll_MaSanPham.HeaderText = "Mã Sản Phẩm";
            this.coll_MaSanPham.MinimumWidth = 6;
            this.coll_MaSanPham.Name = "coll_MaSanPham";
            // 
            // coll_SoLuongTon
            // 
            this.coll_SoLuongTon.HeaderText = "Số Lượng Tồn";
            this.coll_SoLuongTon.MinimumWidth = 6;
            this.coll_SoLuongTon.Name = "coll_SoLuongTon";
            // 
            // coll_SoLuongNhap
            // 
            this.coll_SoLuongNhap.HeaderText = "Số Lượng Nhập";
            this.coll_SoLuongNhap.MinimumWidth = 6;
            this.coll_SoLuongNhap.Name = "coll_SoLuongNhap";
            // 
            // coll_GiaNhap
            // 
            this.coll_GiaNhap.HeaderText = "Giá Nhập";
            this.coll_GiaNhap.MinimumWidth = 6;
            this.coll_GiaNhap.Name = "coll_GiaNhap";
            // 
            // coll_GiaBan
            // 
            this.coll_GiaBan.HeaderText = "Giá Bán";
            this.coll_GiaBan.MinimumWidth = 6;
            this.coll_GiaBan.Name = "coll_GiaBan";
            // 
            // coll_NgayCapNhat
            // 
            this.coll_NgayCapNhat.HeaderText = "Ngày Cập Nhật";
            this.coll_NgayCapNhat.MinimumWidth = 6;
            this.coll_NgayCapNhat.Name = "coll_NgayCapNhat";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightBlue;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txt_giaBan);
            this.panel2.Controls.Add(this.dt_ngayNhap);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txt_ghiChu);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.pb_anhSP);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txt_soLuongTon);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.txt_soLuongNhap);
            this.panel2.Controls.Add(this.txt_giaNhap);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txt_tienGuiTra);
            this.panel2.Location = new System.Drawing.Point(12, 63);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1362, 220);
            this.panel2.TabIndex = 40;
            // 
            // txt_giaBan
            // 
            this.txt_giaBan.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_giaBan.Location = new System.Drawing.Point(796, 90);
            this.txt_giaBan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_giaBan.Multiline = true;
            this.txt_giaBan.Name = "txt_giaBan";
            this.txt_giaBan.Size = new System.Drawing.Size(231, 27);
            this.txt_giaBan.TabIndex = 54;
            this.txt_giaBan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_giaBan_KeyPress);
            // 
            // dt_ngayNhap
            // 
            this.dt_ngayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_ngayNhap.Location = new System.Drawing.Point(289, 162);
            this.dt_ngayNhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dt_ngayNhap.Name = "dt_ngayNhap";
            this.dt_ngayNhap.Size = new System.Drawing.Size(125, 22);
            this.dt_ngayNhap.TabIndex = 52;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(118, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 19);
            this.label4.TabIndex = 51;
            this.label4.Text = "Ngày Nhập";
            // 
            // txt_ghiChu
            // 
            this.txt_ghiChu.Enabled = false;
            this.txt_ghiChu.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ghiChu.Location = new System.Drawing.Point(796, 148);
            this.txt_ghiChu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_ghiChu.Multiline = true;
            this.txt_ghiChu.Name = "txt_ghiChu";
            this.txt_ghiChu.ReadOnly = true;
            this.txt_ghiChu.Size = new System.Drawing.Size(231, 27);
            this.txt_ghiChu.TabIndex = 50;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(102, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 19);
            this.label3.TabIndex = 49;
            this.label3.Text = "Số Lượng Tồn";
            // 
            // pb_anhSP
            // 
            this.pb_anhSP.BackColor = System.Drawing.Color.LightCyan;
            this.pb_anhSP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_anhSP.Location = new System.Drawing.Point(1149, 23);
            this.pb_anhSP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pb_anhSP.Name = "pb_anhSP";
            this.pb_anhSP.Size = new System.Drawing.Size(181, 178);
            this.pb_anhSP.TabIndex = 48;
            this.pb_anhSP.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(628, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 19);
            this.label1.TabIndex = 44;
            this.label1.Text = "Ghi Chú ";
            // 
            // txt_soLuongTon
            // 
            this.txt_soLuongTon.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_soLuongTon.Location = new System.Drawing.Point(252, 15);
            this.txt_soLuongTon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_soLuongTon.Multiline = true;
            this.txt_soLuongTon.Name = "txt_soLuongTon";
            this.txt_soLuongTon.Size = new System.Drawing.Size(231, 27);
            this.txt_soLuongTon.TabIndex = 43;
            this.txt_soLuongTon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_soLuongTon_KeyPress);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(703, 98);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(70, 19);
            this.label15.TabIndex = 42;
            this.label15.Text = "Giá Bán";
            // 
            // txt_soLuongNhap
            // 
            this.txt_soLuongNhap.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_soLuongNhap.Location = new System.Drawing.Point(799, 30);
            this.txt_soLuongNhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_soLuongNhap.Multiline = true;
            this.txt_soLuongNhap.Name = "txt_soLuongNhap";
            this.txt_soLuongNhap.Size = new System.Drawing.Size(231, 27);
            this.txt_soLuongNhap.TabIndex = 37;
            this.txt_soLuongNhap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_soLuongNhap_KeyPress);
            // 
            // txt_giaNhap
            // 
            this.txt_giaNhap.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_giaNhap.Location = new System.Drawing.Point(252, 96);
            this.txt_giaNhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_giaNhap.Multiline = true;
            this.txt_giaNhap.Name = "txt_giaNhap";
            this.txt_giaNhap.Size = new System.Drawing.Size(231, 27);
            this.txt_giaNhap.TabIndex = 36;
            this.txt_giaNhap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_giaNhap_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(646, 23);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(121, 19);
            this.label12.TabIndex = 34;
            this.label12.Text = "Số Lượng Nhập";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(110, 103);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 19);
            this.label9.TabIndex = 35;
            this.label9.Text = "Giá Nhập";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(825, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Tiền gửi trả";
            // 
            // txt_tienGuiTra
            // 
            this.txt_tienGuiTra.Location = new System.Drawing.Point(941, 242);
            this.txt_tienGuiTra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_tienGuiTra.Name = "txt_tienGuiTra";
            this.txt_tienGuiTra.Size = new System.Drawing.Size(100, 22);
            this.txt_tienGuiTra.TabIndex = 10;
            // 
            // KhoHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1410, 569);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgv_KhoHang);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "KhoHang";
            this.Text = "KhoHang";
            this.Load += new System.EventHandler(this.KhoHang_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_KhoHang)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_anhSP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsb_themSanPham;
        private System.Windows.Forms.ToolStripSeparator ts_1;
        private System.Windows.Forms.ToolStripButton tsb_xoaSanPham;
        private System.Windows.Forms.ToolStripSeparator ts_3;
        private System.Windows.Forms.ToolStripButton tsb_suaSanPham;
        private System.Windows.Forms.ToolStripSeparator ts_4;
        private System.Windows.Forms.ToolStripButton tsb_xoaPhieuNhap;
        private System.Windows.Forms.ToolStripSeparator ts_5;
        private System.Windows.Forms.ToolStripButton ts_lamMoiDS;
        private System.Windows.Forms.ToolStripSeparator ts_6;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private System.Windows.Forms.ToolStripTextBox tsTxt_maSP;
        private System.Windows.Forms.ToolStripButton tsb_timSP;
        private System.Windows.Forms.ToolStripSeparator ts_7;
        private System.Windows.Forms.DataGridView dgv_KhoHang;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dt_ngayNhap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_ghiChu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pb_anhSP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_soLuongTon;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txt_soLuongNhap;
        private System.Windows.Forms.TextBox txt_giaNhap;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_tienGuiTra;
        private System.Windows.Forms.ToolStripComboBox tscbb_maSP;
        private System.Windows.Forms.TextBox txt_giaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn coll_MaSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn coll_SoLuongTon;
        private System.Windows.Forms.DataGridViewTextBoxColumn coll_SoLuongNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn coll_GiaNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn coll_GiaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn coll_NgayCapNhat;
    }
}