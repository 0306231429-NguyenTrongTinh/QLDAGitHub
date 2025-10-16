namespace GUI
{
    partial class ThanhToan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThanhToan));
            this.dgv_thanhToan = new System.Windows.Forms.DataGridView();
            this.coll_MaHoaDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coll_MaSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coll_SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coll_DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coll_ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_maKH = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_sdt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_tenKH = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_tienTra = new System.Windows.Forms.TextBox();
            this.btn_tinhTienHD = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_tienNhan = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_ttHoaDon = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_soLuongTon = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_donVi = new System.Windows.Forms.TextBox();
            this.txt_maLoai = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_tienGuiTra = new System.Windows.Forms.TextBox();
            this.nud_soLuong = new System.Windows.Forms.NumericUpDown();
            this.txt_tongTien = new System.Windows.Forms.TextBox();
            this.txt_donGia = new System.Windows.Forms.TextBox();
            this.txt_tenSanPham = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsb_taoHoaDon = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsb_themKH = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.tsb_themCTHD = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsb_xoaSanPham = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsb_xoaPhieuNhap = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.ts_lamMoiDS = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.tscbb_maSanPham = new System.Windows.Forms.ToolStripComboBox();
            this.tsTxt_nhapMaSp = new System.Windows.Forms.ToolStripTextBox();
            this.tsb_timSP = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tscbb_maKhachHang = new System.Windows.Forms.ToolStripComboBox();
            this.tscbb_maHoaDon = new System.Windows.Forms.ToolStripComboBox();
            this.tscbb_hinhThuc = new System.Windows.Forms.ToolStripComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_thanhToan)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_soLuong)).BeginInit();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_thanhToan
            // 
            this.dgv_thanhToan.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgv_thanhToan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_thanhToan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.coll_MaHoaDon,
            this.coll_MaSanPham,
            this.coll_SoLuong,
            this.coll_DonGia,
            this.coll_ThanhTien});
            this.dgv_thanhToan.Location = new System.Drawing.Point(12, 242);
            this.dgv_thanhToan.Name = "dgv_thanhToan";
            this.dgv_thanhToan.RowHeadersWidth = 51;
            this.dgv_thanhToan.RowTemplate.Height = 24;
            this.dgv_thanhToan.Size = new System.Drawing.Size(1357, 192);
            this.dgv_thanhToan.TabIndex = 28;
            this.dgv_thanhToan.SelectionChanged += new System.EventHandler(this.dgv_thanhToan_SelectionChanged);
            // 
            // coll_MaHoaDon
            // 
            this.coll_MaHoaDon.HeaderText = "Mã Hóa Đơn";
            this.coll_MaHoaDon.MinimumWidth = 6;
            this.coll_MaHoaDon.Name = "coll_MaHoaDon";
            this.coll_MaHoaDon.Width = 190;
            // 
            // coll_MaSanPham
            // 
            this.coll_MaSanPham.HeaderText = "Mã Sản Phẩm";
            this.coll_MaSanPham.MinimumWidth = 6;
            this.coll_MaSanPham.Name = "coll_MaSanPham";
            this.coll_MaSanPham.Width = 195;
            // 
            // coll_SoLuong
            // 
            this.coll_SoLuong.HeaderText = "Số Lượng";
            this.coll_SoLuong.MinimumWidth = 6;
            this.coll_SoLuong.Name = "coll_SoLuong";
            this.coll_SoLuong.Width = 195;
            // 
            // coll_DonGia
            // 
            this.coll_DonGia.HeaderText = "Đơn Giá";
            this.coll_DonGia.MinimumWidth = 6;
            this.coll_DonGia.Name = "coll_DonGia";
            this.coll_DonGia.Width = 195;
            // 
            // coll_ThanhTien
            // 
            this.coll_ThanhTien.HeaderText = "Thành Tiền";
            this.coll_ThanhTien.MinimumWidth = 6;
            this.coll_ThanhTien.Name = "coll_ThanhTien";
            this.coll_ThanhTien.Width = 195;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "MaKH";
            // 
            // txt_maKH
            // 
            this.txt_maKH.Enabled = false;
            this.txt_maKH.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_maKH.Location = new System.Drawing.Point(147, 15);
            this.txt_maKH.Multiline = true;
            this.txt_maKH.Name = "txt_maKH";
            this.txt_maKH.ReadOnly = true;
            this.txt_maKH.Size = new System.Drawing.Size(188, 27);
            this.txt_maKH.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "TenKH";
            // 
            // txt_sdt
            // 
            this.txt_sdt.Enabled = false;
            this.txt_sdt.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sdt.Location = new System.Drawing.Point(147, 143);
            this.txt_sdt.Multiline = true;
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.ReadOnly = true;
            this.txt_sdt.Size = new System.Drawing.Size(188, 27);
            this.txt_sdt.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(61, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 23);
            this.label4.TabIndex = 2;
            this.label4.Text = "SDT";
            // 
            // txt_tenKH
            // 
            this.txt_tenKH.Enabled = false;
            this.txt_tenKH.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tenKH.Location = new System.Drawing.Point(150, 81);
            this.txt_tenKH.Multiline = true;
            this.txt_tenKH.Name = "txt_tenKH";
            this.txt_tenKH.ReadOnly = true;
            this.txt_tenKH.Size = new System.Drawing.Size(185, 27);
            this.txt_tenKH.TabIndex = 8;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.LightBlue;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.label13);
            this.panel6.Controls.Add(this.txt_tienTra);
            this.panel6.Controls.Add(this.btn_tinhTienHD);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Controls.Add(this.txt_tienNhan);
            this.panel6.Location = new System.Drawing.Point(1172, 44);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(197, 196);
            this.panel6.TabIndex = 26;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(56, 76);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 19);
            this.label13.TabIndex = 11;
            this.label13.Text = "Tiền Trả ";
            // 
            // txt_tienTra
            // 
            this.txt_tienTra.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tienTra.Location = new System.Drawing.Point(23, 103);
            this.txt_tienTra.Multiline = true;
            this.txt_tienTra.Name = "txt_tienTra";
            this.txt_tienTra.Size = new System.Drawing.Size(155, 33);
            this.txt_tienTra.TabIndex = 10;
            this.txt_tienTra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_tienTra_KeyPress);
            // 
            // btn_tinhTienHD
            // 
            this.btn_tinhTienHD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_tinhTienHD.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tinhTienHD.Location = new System.Drawing.Point(60, 153);
            this.btn_tinhTienHD.Name = "btn_tinhTienHD";
            this.btn_tinhTienHD.Size = new System.Drawing.Size(81, 31);
            this.btn_tinhTienHD.TabIndex = 5;
            this.btn_tinhTienHD.Text = "Tính tiền";
            this.btn_tinhTienHD.UseVisualStyleBackColor = true;
            this.btn_tinhTienHD.Click += new System.EventHandler(this.btn_tinhTien_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(46, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 19);
            this.label5.TabIndex = 3;
            this.label5.Text = "Tiền Nhận";
            // 
            // txt_tienNhan
            // 
            this.txt_tienNhan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tienNhan.Location = new System.Drawing.Point(23, 30);
            this.txt_tienNhan.Multiline = true;
            this.txt_tienNhan.Name = "txt_tienNhan";
            this.txt_tienNhan.Size = new System.Drawing.Size(155, 34);
            this.txt_tienNhan.TabIndex = 9;
            this.txt_tienNhan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_tienNhan_KeyPress);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightBlue;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txt_ttHoaDon);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txt_soLuongTon);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.txt_donVi);
            this.panel2.Controls.Add(this.txt_maLoai);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txt_tienGuiTra);
            this.panel2.Controls.Add(this.nud_soLuong);
            this.panel2.Controls.Add(this.txt_tongTien);
            this.panel2.Controls.Add(this.txt_donGia);
            this.panel2.Controls.Add(this.txt_tenSanPham);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Location = new System.Drawing.Point(12, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(769, 196);
            this.panel2.TabIndex = 23;
            // 
            // txt_ttHoaDon
            // 
            this.txt_ttHoaDon.Enabled = false;
            this.txt_ttHoaDon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ttHoaDon.Location = new System.Drawing.Point(595, 139);
            this.txt_ttHoaDon.Multiline = true;
            this.txt_ttHoaDon.Name = "txt_ttHoaDon";
            this.txt_ttHoaDon.ReadOnly = true;
            this.txt_ttHoaDon.Size = new System.Drawing.Size(113, 33);
            this.txt_ttHoaDon.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(414, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(155, 19);
            this.label7.TabIndex = 21;
            this.label7.Text = "Tổng Tiền Hóa Đơn ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(432, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 19);
            this.label1.TabIndex = 20;
            this.label1.Text = "Số Lượng Tồn";
            // 
            // txt_soLuongTon
            // 
            this.txt_soLuongTon.Enabled = false;
            this.txt_soLuongTon.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_soLuongTon.Location = new System.Drawing.Point(582, 95);
            this.txt_soLuongTon.Multiline = true;
            this.txt_soLuongTon.Name = "txt_soLuongTon";
            this.txt_soLuongTon.ReadOnly = true;
            this.txt_soLuongTon.Size = new System.Drawing.Size(111, 27);
            this.txt_soLuongTon.TabIndex = 19;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(459, 59);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(44, 19);
            this.label15.TabIndex = 18;
            this.label15.Text = "Kiểu";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(459, 15);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(75, 19);
            this.label14.TabIndex = 17;
            this.label14.Text = "Mã Loại ";
            // 
            // txt_donVi
            // 
            this.txt_donVi.Enabled = false;
            this.txt_donVi.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_donVi.Location = new System.Drawing.Point(582, 56);
            this.txt_donVi.Multiline = true;
            this.txt_donVi.Name = "txt_donVi";
            this.txt_donVi.ReadOnly = true;
            this.txt_donVi.Size = new System.Drawing.Size(125, 27);
            this.txt_donVi.TabIndex = 16;
            // 
            // txt_maLoai
            // 
            this.txt_maLoai.Enabled = false;
            this.txt_maLoai.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_maLoai.Location = new System.Drawing.Point(582, 10);
            this.txt_maLoai.Multiline = true;
            this.txt_maLoai.Name = "txt_maLoai";
            this.txt_maLoai.ReadOnly = true;
            this.txt_maLoai.Size = new System.Drawing.Size(125, 27);
            this.txt_maLoai.TabIndex = 15;
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
            // nud_soLuong
            // 
            this.nud_soLuong.Location = new System.Drawing.Point(217, 103);
            this.nud_soLuong.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_soLuong.Name = "nud_soLuong";
            this.nud_soLuong.Size = new System.Drawing.Size(78, 22);
            this.nud_soLuong.TabIndex = 14;
            this.nud_soLuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_soLuong.ValueChanged += new System.EventHandler(this.nud_soLuong_ValueChanged);
            // 
            // txt_tongTien
            // 
            this.txt_tongTien.Enabled = false;
            this.txt_tongTien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tongTien.Location = new System.Drawing.Point(251, 144);
            this.txt_tongTien.Multiline = true;
            this.txt_tongTien.Name = "txt_tongTien";
            this.txt_tongTien.ReadOnly = true;
            this.txt_tongTien.Size = new System.Drawing.Size(113, 33);
            this.txt_tongTien.TabIndex = 11;
            // 
            // txt_donGia
            // 
            this.txt_donGia.Enabled = false;
            this.txt_donGia.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_donGia.Location = new System.Drawing.Point(217, 54);
            this.txt_donGia.Multiline = true;
            this.txt_donGia.Name = "txt_donGia";
            this.txt_donGia.ReadOnly = true;
            this.txt_donGia.Size = new System.Drawing.Size(125, 27);
            this.txt_donGia.TabIndex = 10;
            this.txt_donGia.TextChanged += new System.EventHandler(this.txt_donGia_TextChanged);
            // 
            // txt_tenSanPham
            // 
            this.txt_tenSanPham.Enabled = false;
            this.txt_tenSanPham.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tenSanPham.Location = new System.Drawing.Point(217, 9);
            this.txt_tenSanPham.Multiline = true;
            this.txt_tenSanPham.Name = "txt_tenSanPham";
            this.txt_tenSanPham.ReadOnly = true;
            this.txt_tenSanPham.Size = new System.Drawing.Size(125, 27);
            this.txt_tenSanPham.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label11.Location = new System.Drawing.Point(70, 158);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(159, 19);
            this.label11.TabIndex = 4;
            this.label11.Text = "Tổng Tiền Sản Phẩm";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(76, 58);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 19);
            this.label12.TabIndex = 5;
            this.label12.Text = "Đơn Giá";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(76, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 19);
            this.label8.TabIndex = 4;
            this.label8.Text = "Số Lượng";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(70, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 19);
            this.label9.TabIndex = 5;
            this.label9.Text = "Tên Sản Phẩm";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_maKH);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_tenKH);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txt_sdt);
            this.panel1.Location = new System.Drawing.Point(785, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(381, 196);
            this.panel1.TabIndex = 22;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_taoHoaDon,
            this.toolStripSeparator3,
            this.tsb_themKH,
            this.toolStripSeparator,
            this.tsb_themCTHD,
            this.toolStripSeparator2,
            this.tsb_xoaSanPham,
            this.toolStripSeparator4,
            this.tsb_xoaPhieuNhap,
            this.toolStripSeparator6,
            this.ts_lamMoiDS,
            this.toolStripSeparator7,
            this.toolStripTextBox2,
            this.tscbb_maSanPham,
            this.tsTxt_nhapMaSp,
            this.tsb_timSP,
            this.toolStripSeparator5,
            this.tscbb_maKhachHang,
            this.tscbb_maHoaDon,
            this.tscbb_hinhThuc});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1410, 31);
            this.toolStrip1.TabIndex = 38;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsb_taoHoaDon
            // 
            this.tsb_taoHoaDon.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_taoHoaDon.Image = ((System.Drawing.Image)(resources.GetObject("tsb_taoHoaDon.Image")));
            this.tsb_taoHoaDon.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_taoHoaDon.Name = "tsb_taoHoaDon";
            this.tsb_taoHoaDon.Size = new System.Drawing.Size(29, 28);
            this.tsb_taoHoaDon.Text = "&Tạo Hóa Đơn";
            this.tsb_taoHoaDon.Click += new System.EventHandler(this.tsb_taoHoaDon_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 31);
            // 
            // tsb_themKH
            // 
            this.tsb_themKH.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_themKH.Image = ((System.Drawing.Image)(resources.GetObject("tsb_themKH.Image")));
            this.tsb_themKH.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_themKH.Name = "tsb_themKH";
            this.tsb_themKH.Size = new System.Drawing.Size(29, 28);
            this.tsb_themKH.Text = "&Thêm Khách Hàng";
            this.tsb_themKH.Click += new System.EventHandler(this.tsb_themKH_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // tsb_themCTHD
            // 
            this.tsb_themCTHD.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_themCTHD.Image = ((System.Drawing.Image)(resources.GetObject("tsb_themCTHD.Image")));
            this.tsb_themCTHD.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_themCTHD.Name = "tsb_themCTHD";
            this.tsb_themCTHD.Size = new System.Drawing.Size(29, 28);
            this.tsb_themCTHD.Text = "&Thêm Sản Phẩm ";
            this.tsb_themCTHD.Click += new System.EventHandler(this.tsb_themCTHD_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // tsb_xoaSanPham
            // 
            this.tsb_xoaSanPham.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_xoaSanPham.Image = ((System.Drawing.Image)(resources.GetObject("tsb_xoaSanPham.Image")));
            this.tsb_xoaSanPham.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_xoaSanPham.Name = "tsb_xoaSanPham";
            this.tsb_xoaSanPham.Size = new System.Drawing.Size(29, 28);
            this.tsb_xoaSanPham.Text = "&Xóa Sản Phẩm";
            this.tsb_xoaSanPham.Click += new System.EventHandler(this.tsb_xoaSanPham_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 31);
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
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 31);
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
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 31);
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
            // tscbb_maSanPham
            // 
            this.tscbb_maSanPham.Name = "tscbb_maSanPham";
            this.tscbb_maSanPham.Size = new System.Drawing.Size(140, 31);
            this.tscbb_maSanPham.Text = "Mã Sản Phẩm";
            this.tscbb_maSanPham.SelectedIndexChanged += new System.EventHandler(this.tscbb_maSanPham_SelectedIndexChanged);
            this.tscbb_maSanPham.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tscbb_maSanPham_KeyPress);
            // 
            // tsTxt_nhapMaSp
            // 
            this.tsTxt_nhapMaSp.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tsTxt_nhapMaSp.Name = "tsTxt_nhapMaSp";
            this.tsTxt_nhapMaSp.Size = new System.Drawing.Size(100, 31);
            this.tsTxt_nhapMaSp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tsTxt_nhapMaSp_KeyPress);
            this.tsTxt_nhapMaSp.TextChanged += new System.EventHandler(this.tsTxt_nhapMaSp_TextChanged);
            // 
            // tsb_timSP
            // 
            this.tsb_timSP.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_timSP.Image = ((System.Drawing.Image)(resources.GetObject("tsb_timSP.Image")));
            this.tsb_timSP.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_timSP.Name = "tsb_timSP";
            this.tsb_timSP.Size = new System.Drawing.Size(29, 28);
            this.tsb_timSP.Text = "&Tìm Hóa Đơn";
            this.tsb_timSP.Click += new System.EventHandler(this.tsb_timSP_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 31);
            // 
            // tscbb_maKhachHang
            // 
            this.tscbb_maKhachHang.Name = "tscbb_maKhachHang";
            this.tscbb_maKhachHang.Size = new System.Drawing.Size(140, 31);
            this.tscbb_maKhachHang.Text = "Mã Khách Hàng";
            this.tscbb_maKhachHang.SelectedIndexChanged += new System.EventHandler(this.tscbb_maKhachHang_SelectedIndexChanged);
            this.tscbb_maKhachHang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tscbb_maKhachHang_KeyPress);
            // 
            // tscbb_maHoaDon
            // 
            this.tscbb_maHoaDon.Name = "tscbb_maHoaDon";
            this.tscbb_maHoaDon.Size = new System.Drawing.Size(140, 31);
            this.tscbb_maHoaDon.Text = "Mã Hóa Đơn";
            this.tscbb_maHoaDon.SelectedIndexChanged += new System.EventHandler(this.tscbb_maHoaDon_SelectedIndexChanged);
            this.tscbb_maHoaDon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tscbb_maHoaDon_KeyPress);
            // 
            // tscbb_hinhThuc
            // 
            this.tscbb_hinhThuc.Name = "tscbb_hinhThuc";
            this.tscbb_hinhThuc.Size = new System.Drawing.Size(190, 31);
            this.tscbb_hinhThuc.Text = "Hình Thức Thanh Toán";
            this.tscbb_hinhThuc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tscbb_hinhThuc_KeyPress);
            // 
            // ThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1410, 683);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgv_thanhToan);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ThanhToan";
            this.Text = "Bán Hàng";
            this.Load += new System.EventHandler(this.SanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_thanhToan)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_soLuong)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_thanhToan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_maKH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_sdt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_tenKH;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_tienTra;
        private System.Windows.Forms.Button btn_tinhTienHD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_tienNhan;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_soLuongTon;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_donVi;
        private System.Windows.Forms.TextBox txt_maLoai;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_tienGuiTra;
        private System.Windows.Forms.NumericUpDown nud_soLuong;
        private System.Windows.Forms.TextBox txt_tongTien;
        private System.Windows.Forms.TextBox txt_donGia;
        private System.Windows.Forms.TextBox txt_tenSanPham;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsb_taoHoaDon;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton tsb_themCTHD;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsb_themKH;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsb_xoaSanPham;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton ts_lamMoiDS;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private System.Windows.Forms.ToolStripComboBox tscbb_maSanPham;
        private System.Windows.Forms.ToolStripTextBox tsTxt_nhapMaSp;
        private System.Windows.Forms.ToolStripButton tsb_timSP;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripComboBox tscbb_maKhachHang;
        private System.Windows.Forms.ToolStripComboBox tscbb_maHoaDon;
        private System.Windows.Forms.ToolStripButton tsb_xoaPhieuNhap;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.TextBox txt_ttHoaDon;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolStripComboBox tscbb_hinhThuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn coll_MaHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn coll_MaSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn coll_SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn coll_DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn coll_ThanhTien;
    }
}