namespace GUI.form
{
    partial class SanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SanPham));
            this.dgv_SanPham = new System.Windows.Forms.DataGridView();
            this.coll_MaSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coll_TenSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coll_MaLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coll_DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coll_SoLuongTon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coll_DonViTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coll_MaNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coll_NgayHetHan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coll_trangThai = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbb_donVi = new System.Windows.Forms.ComboBox();
            this.btn_taiAnh = new System.Windows.Forms.Button();
            this.dt_ngayHetHan = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_maSP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pb_anhSP = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_soLuongTon = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_donGia = new System.Windows.Forms.TextBox();
            this.txt_tenSanPham = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_tienGuiTra = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsb_themSanPham = new System.Windows.Forms.ToolStripButton();
            this.ts_1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmenu_luuSP = new System.Windows.Forms.ToolStripButton();
            this.ts_2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsb_xoaSanPham = new System.Windows.Forms.ToolStripButton();
            this.ts_3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsb_suaSanPham = new System.Windows.Forms.ToolStripButton();
            this.ts_4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsb_xoaPhieuNhap = new System.Windows.Forms.ToolStripButton();
            this.ts_5 = new System.Windows.Forms.ToolStripSeparator();
            this.ts_lamMoiDS = new System.Windows.Forms.ToolStripButton();
            this.ts_6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.tscbb_loaiThongTin = new System.Windows.Forms.ToolStripComboBox();
            this.tsTxt_nhapThongTin = new System.Windows.Forms.ToolStripTextBox();
            this.tsb_timSP = new System.Windows.Forms.ToolStripButton();
            this.ts_7 = new System.Windows.Forms.ToolStripSeparator();
            this.tscbb_maNCC = new System.Windows.Forms.ToolStripComboBox();
            this.tscbb_maLoai = new System.Windows.Forms.ToolStripComboBox();
            this.loadAnh = new System.Windows.Forms.OpenFileDialog();
            this.lb_ncc = new System.Windows.Forms.ToolStripLabel();
            this.lb_maLoai = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SanPham)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_anhSP)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_SanPham
            // 
            this.dgv_SanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_SanPham.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgv_SanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_SanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.coll_MaSanPham,
            this.coll_TenSanPham,
            this.coll_MaLoai,
            this.coll_DonGia,
            this.coll_SoLuongTon,
            this.coll_DonViTinh,
            this.coll_MaNCC,
            this.coll_NgayHetHan,
            this.coll_trangThai});
            this.dgv_SanPham.Location = new System.Drawing.Point(12, 286);
            this.dgv_SanPham.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_SanPham.Name = "dgv_SanPham";
            this.dgv_SanPham.RowHeadersWidth = 51;
            this.dgv_SanPham.RowTemplate.Height = 24;
            this.dgv_SanPham.Size = new System.Drawing.Size(1363, 226);
            this.dgv_SanPham.TabIndex = 38;
            this.dgv_SanPham.SelectionChanged += new System.EventHandler(this.dgv_SanPham_SelectionChanged);
            // 
            // coll_MaSanPham
            // 
            this.coll_MaSanPham.HeaderText = "Mã Sản Phẩm";
            this.coll_MaSanPham.MinimumWidth = 6;
            this.coll_MaSanPham.Name = "coll_MaSanPham";
            // 
            // coll_TenSanPham
            // 
            this.coll_TenSanPham.HeaderText = "Tên Sản Phẩm ";
            this.coll_TenSanPham.MinimumWidth = 6;
            this.coll_TenSanPham.Name = "coll_TenSanPham";
            // 
            // coll_MaLoai
            // 
            this.coll_MaLoai.HeaderText = "Mã Loại";
            this.coll_MaLoai.MinimumWidth = 6;
            this.coll_MaLoai.Name = "coll_MaLoai";
            // 
            // coll_DonGia
            // 
            this.coll_DonGia.HeaderText = "Đơn Giá";
            this.coll_DonGia.MinimumWidth = 6;
            this.coll_DonGia.Name = "coll_DonGia";
            // 
            // coll_SoLuongTon
            // 
            this.coll_SoLuongTon.HeaderText = "Số Lượng Tồn";
            this.coll_SoLuongTon.MinimumWidth = 6;
            this.coll_SoLuongTon.Name = "coll_SoLuongTon";
            // 
            // coll_DonViTinh
            // 
            this.coll_DonViTinh.HeaderText = "Đơn Vị Tính";
            this.coll_DonViTinh.MinimumWidth = 6;
            this.coll_DonViTinh.Name = "coll_DonViTinh";
            // 
            // coll_MaNCC
            // 
            this.coll_MaNCC.HeaderText = "Mã Nhà Cung Cấp";
            this.coll_MaNCC.MinimumWidth = 6;
            this.coll_MaNCC.Name = "coll_MaNCC";
            // 
            // coll_NgayHetHan
            // 
            this.coll_NgayHetHan.HeaderText = "Ngày Hết Hạn";
            this.coll_NgayHetHan.MinimumWidth = 6;
            this.coll_NgayHetHan.Name = "coll_NgayHetHan";
            // 
            // coll_trangThai
            // 
            this.coll_trangThai.HeaderText = "Trạng Thái";
            this.coll_trangThai.MinimumWidth = 6;
            this.coll_trangThai.Name = "coll_trangThai";
            this.coll_trangThai.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightBlue;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.cbb_donVi);
            this.panel2.Controls.Add(this.btn_taiAnh);
            this.panel2.Controls.Add(this.dt_ngayHetHan);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txt_maSP);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.pb_anhSP);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txt_soLuongTon);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.txt_donGia);
            this.panel2.Controls.Add(this.txt_tenSanPham);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txt_tienGuiTra);
            this.panel2.Location = new System.Drawing.Point(12, 59);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1362, 220);
            this.panel2.TabIndex = 37;
            // 
            // cbb_donVi
            // 
            this.cbb_donVi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_donVi.FormattingEnabled = true;
            this.cbb_donVi.Location = new System.Drawing.Point(720, 98);
            this.cbb_donVi.Margin = new System.Windows.Forms.Padding(4);
            this.cbb_donVi.Name = "cbb_donVi";
            this.cbb_donVi.Size = new System.Drawing.Size(233, 24);
            this.cbb_donVi.TabIndex = 54;
            // 
            // btn_taiAnh
            // 
            this.btn_taiAnh.Font = new System.Drawing.Font("Times New Roman", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_taiAnh.Location = new System.Drawing.Point(1141, 186);
            this.btn_taiAnh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_taiAnh.Name = "btn_taiAnh";
            this.btn_taiAnh.Size = new System.Drawing.Size(117, 30);
            this.btn_taiAnh.TabIndex = 53;
            this.btn_taiAnh.Text = "Tải ảnh";
            this.btn_taiAnh.UseVisualStyleBackColor = true;
            this.btn_taiAnh.Click += new System.EventHandler(this.btn_taiAnh_Click);
            // 
            // dt_ngayHetHan
            // 
            this.dt_ngayHetHan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_ngayHetHan.Location = new System.Drawing.Point(256, 162);
            this.dt_ngayHetHan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dt_ngayHetHan.Name = "dt_ngayHetHan";
            this.dt_ngayHetHan.Size = new System.Drawing.Size(125, 22);
            this.dt_ngayHetHan.TabIndex = 52;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(85, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 19);
            this.label4.TabIndex = 51;
            this.label4.Text = "Ngày Hết Hạn";
            // 
            // txt_maSP
            // 
            this.txt_maSP.Enabled = false;
            this.txt_maSP.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_maSP.Location = new System.Drawing.Point(219, 23);
            this.txt_maSP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_maSP.Multiline = true;
            this.txt_maSP.Name = "txt_maSP";
            this.txt_maSP.ReadOnly = true;
            this.txt_maSP.Size = new System.Drawing.Size(231, 27);
            this.txt_maSP.TabIndex = 50;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(69, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 19);
            this.label3.TabIndex = 49;
            this.label3.Text = "Mã Sản Phẩm:";
            // 
            // pb_anhSP
            // 
            this.pb_anhSP.BackColor = System.Drawing.Color.LightCyan;
            this.pb_anhSP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_anhSP.Location = new System.Drawing.Point(1119, 1);
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
            this.label1.Location = new System.Drawing.Point(552, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 19);
            this.label1.TabIndex = 44;
            this.label1.Text = "Số Lượng Tồn";
            // 
            // txt_soLuongTon
            // 
            this.txt_soLuongTon.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_soLuongTon.Location = new System.Drawing.Point(720, 151);
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
            this.label15.Location = new System.Drawing.Point(627, 98);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(64, 19);
            this.label15.TabIndex = 42;
            this.label15.Text = "Đơn Vị ";
            // 
            // txt_donGia
            // 
            this.txt_donGia.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_donGia.Location = new System.Drawing.Point(723, 30);
            this.txt_donGia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_donGia.Multiline = true;
            this.txt_donGia.Name = "txt_donGia";
            this.txt_donGia.Size = new System.Drawing.Size(231, 27);
            this.txt_donGia.TabIndex = 37;
            this.txt_donGia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_donGia_KeyPress);
            // 
            // txt_tenSanPham
            // 
            this.txt_tenSanPham.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tenSanPham.Location = new System.Drawing.Point(219, 96);
            this.txt_tenSanPham.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_tenSanPham.Multiline = true;
            this.txt_tenSanPham.Name = "txt_tenSanPham";
            this.txt_tenSanPham.Size = new System.Drawing.Size(231, 27);
            this.txt_tenSanPham.TabIndex = 36;
            this.txt_tenSanPham.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_tenSanPham_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(613, 23);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 19);
            this.label12.TabIndex = 34;
            this.label12.Text = "Đơn Giá:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(77, 103);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 19);
            this.label9.TabIndex = 35;
            this.label9.Text = "Tên Sản Phẩm:";
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
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_themSanPham,
            this.ts_1,
            this.tsmenu_luuSP,
            this.ts_2,
            this.tsb_xoaSanPham,
            this.ts_3,
            this.tsb_suaSanPham,
            this.ts_4,
            this.tsb_xoaPhieuNhap,
            this.ts_5,
            this.ts_lamMoiDS,
            this.ts_6,
            this.toolStripTextBox2,
            this.tscbb_loaiThongTin,
            this.tsTxt_nhapThongTin,
            this.tsb_timSP,
            this.ts_7,
            this.tscbb_maNCC,
            this.lb_ncc,
            this.toolStripSeparator1,
            this.tscbb_maLoai,
            this.lb_maLoai});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1405, 28);
            this.toolStrip1.TabIndex = 39;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsb_themSanPham
            // 
            this.tsb_themSanPham.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_themSanPham.Image = ((System.Drawing.Image)(resources.GetObject("tsb_themSanPham.Image")));
            this.tsb_themSanPham.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_themSanPham.Name = "tsb_themSanPham";
            this.tsb_themSanPham.Size = new System.Drawing.Size(29, 25);
            this.tsb_themSanPham.Text = "&Thêm Sản Phẩm";
            this.tsb_themSanPham.Click += new System.EventHandler(this.tsb_themSanPham_Click);
            // 
            // ts_1
            // 
            this.ts_1.Name = "ts_1";
            this.ts_1.Size = new System.Drawing.Size(6, 28);
            // 
            // tsmenu_luuSP
            // 
            this.tsmenu_luuSP.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsmenu_luuSP.Image = ((System.Drawing.Image)(resources.GetObject("tsmenu_luuSP.Image")));
            this.tsmenu_luuSP.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmenu_luuSP.Name = "tsmenu_luuSP";
            this.tsmenu_luuSP.Size = new System.Drawing.Size(29, 25);
            this.tsmenu_luuSP.Text = "&Lưu Ảnh Sản Phẩm";
            this.tsmenu_luuSP.Click += new System.EventHandler(this.tsmenu_luuSP_Click);
            // 
            // ts_2
            // 
            this.ts_2.Name = "ts_2";
            this.ts_2.Size = new System.Drawing.Size(6, 28);
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
            this.tsb_xoaPhieuNhap.Click += new System.EventHandler(this.tsb_xoaPhieuNhap_Click);
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
            this.ts_lamMoiDS.Click += new System.EventHandler(this.ts_lamMoiDS_Click);
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
            // tsb_timSP
            // 
            this.tsb_timSP.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_timSP.Image = ((System.Drawing.Image)(resources.GetObject("tsb_timSP.Image")));
            this.tsb_timSP.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_timSP.Name = "tsb_timSP";
            this.tsb_timSP.Size = new System.Drawing.Size(29, 25);
            this.tsb_timSP.Text = "&Tìm Hóa Đơn";
            this.tsb_timSP.Click += new System.EventHandler(this.tsb_timSP_Click);
            // 
            // ts_7
            // 
            this.ts_7.Name = "ts_7";
            this.ts_7.Size = new System.Drawing.Size(6, 28);
            // 
            // tscbb_maNCC
            // 
            this.tscbb_maNCC.Name = "tscbb_maNCC";
            this.tscbb_maNCC.Size = new System.Drawing.Size(212, 28);
            this.tscbb_maNCC.Text = "Mã Nhà Cung Cấp";
            this.tscbb_maNCC.SelectedIndexChanged += new System.EventHandler(this.tscbb_maNCC_SelectedIndexChanged);
            this.tscbb_maNCC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tscbb_maNCC_KeyPress);
            // 
            // tscbb_maLoai
            // 
            this.tscbb_maLoai.Name = "tscbb_maLoai";
            this.tscbb_maLoai.Size = new System.Drawing.Size(121, 28);
            this.tscbb_maLoai.Text = "Mã Loại";
            this.tscbb_maLoai.SelectedIndexChanged += new System.EventHandler(this.tscbb_maLoai_SelectedIndexChanged);
            this.tscbb_maLoai.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tscbb_maLoai_KeyPress);
            // 
            // loadAnh
            // 
            this.loadAnh.FileName = "tai anh";
            // 
            // lb_ncc
            // 
            this.lb_ncc.Name = "lb_ncc";
            this.lb_ncc.Size = new System.Drawing.Size(0, 28);
            // 
            // lb_maLoai
            // 
            this.lb_maLoai.Name = "lb_maLoai";
            this.lb_maLoai.Size = new System.Drawing.Size(0, 28);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 28);
            // 
            // SanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1405, 566);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgv_SanPham);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SanPham";
            this.Text = "SanPham";
            this.Load += new System.EventHandler(this.SanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SanPham)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_anhSP)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_SanPham;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_tienGuiTra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_soLuongTon;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txt_donGia;
        private System.Windows.Forms.TextBox txt_tenSanPham;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pb_anhSP;
        private System.Windows.Forms.TextBox txt_maSP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dt_ngayHetHan;
        private System.Windows.Forms.Label label4;
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
        private System.Windows.Forms.ToolStripTextBox tsTxt_nhapThongTin;
        private System.Windows.Forms.ToolStripButton tsb_timSP;
        private System.Windows.Forms.ToolStripSeparator ts_7;
        private System.Windows.Forms.ToolStripComboBox tscbb_loaiThongTin;
        private System.Windows.Forms.ToolStripComboBox tscbb_maNCC;
        private System.Windows.Forms.ToolStripComboBox tscbb_maLoai;
        private System.Windows.Forms.Button btn_taiAnh;
        private System.Windows.Forms.OpenFileDialog loadAnh;
        private System.Windows.Forms.ComboBox cbb_donVi;
        private System.Windows.Forms.ToolStripButton tsmenu_luuSP;
        private System.Windows.Forms.ToolStripSeparator ts_2;
        private System.Windows.Forms.DataGridViewTextBoxColumn coll_MaSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn coll_TenSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn coll_MaLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn coll_DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn coll_SoLuongTon;
        private System.Windows.Forms.DataGridViewTextBoxColumn coll_DonViTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn coll_MaNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn coll_NgayHetHan;
        private System.Windows.Forms.DataGridViewComboBoxColumn coll_trangThai;
        private System.Windows.Forms.ToolStripLabel lb_ncc;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel lb_maLoai;
    }
}