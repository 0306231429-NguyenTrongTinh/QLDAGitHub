namespace GUI.form
{
    partial class ChiTietNhapHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChiTietNhapHang));
            this.dgv_nhapHang = new System.Windows.Forms.DataGridView();
            this.coll_MaSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coll_MaPhieuNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coll_SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coll_DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coll_ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_tienTra = new System.Windows.Forms.TextBox();
            this.btn_tinhTienPN = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_tienNhan = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_donGiaBan = new System.Windows.Forms.TextBox();
            this.txt_ttPhieuNhap = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_soLuongTon = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_tienGuiTra = new System.Windows.Forms.TextBox();
            this.nud_soLuongNhap = new System.Windows.Forms.NumericUpDown();
            this.txt_tongTien = new System.Windows.Forms.TextBox();
            this.txt_donGiaNhap = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_tenNCC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_sdt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_diaChi = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsb_themNCC = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.tsb_themSP = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsb_xoaSP = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsb_xoaPhieuNhap = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ts_lamMoiDS = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.tscbb_maSP = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tstxt_tenSP = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tscbb_maNCC = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tscbb_maPN = new System.Windows.Forms.ToolStripComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nhapHang)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_soLuongNhap)).BeginInit();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_nhapHang
            // 
            this.dgv_nhapHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_nhapHang.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgv_nhapHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_nhapHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.coll_MaSanPham,
            this.coll_MaPhieuNhap,
            this.coll_SoLuong,
            this.coll_DonGia,
            this.coll_ThanhTien});
            this.dgv_nhapHang.Location = new System.Drawing.Point(12, 244);
            this.dgv_nhapHang.Name = "dgv_nhapHang";
            this.dgv_nhapHang.RowHeadersWidth = 51;
            this.dgv_nhapHang.RowTemplate.Height = 24;
            this.dgv_nhapHang.Size = new System.Drawing.Size(1357, 192);
            this.dgv_nhapHang.TabIndex = 42;
            this.dgv_nhapHang.SelectionChanged += new System.EventHandler(this.dgv_nhapHang_SelectionChanged);
            // 
            // coll_MaSanPham
            // 
            this.coll_MaSanPham.HeaderText = "Mã Sản Phẩm";
            this.coll_MaSanPham.MinimumWidth = 6;
            this.coll_MaSanPham.Name = "coll_MaSanPham";
            // 
            // coll_MaPhieuNhap
            // 
            this.coll_MaPhieuNhap.HeaderText = "Mã Phiếu Nhập";
            this.coll_MaPhieuNhap.MinimumWidth = 6;
            this.coll_MaPhieuNhap.Name = "coll_MaPhieuNhap";
            // 
            // coll_SoLuong
            // 
            this.coll_SoLuong.HeaderText = "Số Lượng";
            this.coll_SoLuong.MinimumWidth = 6;
            this.coll_SoLuong.Name = "coll_SoLuong";
            // 
            // coll_DonGia
            // 
            this.coll_DonGia.HeaderText = "Đơn Giá";
            this.coll_DonGia.MinimumWidth = 6;
            this.coll_DonGia.Name = "coll_DonGia";
            // 
            // coll_ThanhTien
            // 
            this.coll_ThanhTien.HeaderText = "Thành Tiền ";
            this.coll_ThanhTien.MinimumWidth = 6;
            this.coll_ThanhTien.Name = "coll_ThanhTien";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.LightBlue;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.label13);
            this.panel6.Controls.Add(this.txt_tienTra);
            this.panel6.Controls.Add(this.btn_tinhTienPN);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Controls.Add(this.txt_tienNhan);
            this.panel6.Location = new System.Drawing.Point(1172, 46);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(197, 196);
            this.panel6.TabIndex = 41;
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
            // btn_tinhTienPN
            // 
            this.btn_tinhTienPN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_tinhTienPN.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tinhTienPN.Location = new System.Drawing.Point(60, 153);
            this.btn_tinhTienPN.Name = "btn_tinhTienPN";
            this.btn_tinhTienPN.Size = new System.Drawing.Size(81, 31);
            this.btn_tinhTienPN.TabIndex = 5;
            this.btn_tinhTienPN.Text = "Tính tiền";
            this.btn_tinhTienPN.UseVisualStyleBackColor = true;
            this.btn_tinhTienPN.Click += new System.EventHandler(this.btn_tinhTienPN_Click);
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
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.txt_donGiaBan);
            this.panel2.Controls.Add(this.txt_ttPhieuNhap);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txt_soLuongTon);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txt_tienGuiTra);
            this.panel2.Controls.Add(this.nud_soLuongNhap);
            this.panel2.Controls.Add(this.txt_tongTien);
            this.panel2.Controls.Add(this.txt_donGiaNhap);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(12, 46);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(769, 196);
            this.panel2.TabIndex = 40;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(52, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 19);
            this.label9.TabIndex = 24;
            this.label9.Text = "Đơn Giá Bán";
            // 
            // txt_donGiaBan
            // 
            this.txt_donGiaBan.Enabled = false;
            this.txt_donGiaBan.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_donGiaBan.Location = new System.Drawing.Point(216, 10);
            this.txt_donGiaBan.Multiline = true;
            this.txt_donGiaBan.Name = "txt_donGiaBan";
            this.txt_donGiaBan.ReadOnly = true;
            this.txt_donGiaBan.Size = new System.Drawing.Size(111, 27);
            this.txt_donGiaBan.TabIndex = 23;
            // 
            // txt_ttPhieuNhap
            // 
            this.txt_ttPhieuNhap.Enabled = false;
            this.txt_ttPhieuNhap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ttPhieuNhap.Location = new System.Drawing.Point(586, 142);
            this.txt_ttPhieuNhap.Multiline = true;
            this.txt_ttPhieuNhap.Name = "txt_ttPhieuNhap";
            this.txt_ttPhieuNhap.ReadOnly = true;
            this.txt_ttPhieuNhap.Size = new System.Drawing.Size(132, 31);
            this.txt_ttPhieuNhap.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(386, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(172, 19);
            this.label7.TabIndex = 21;
            this.label7.Text = "Tổng Tiền Phiếu Nhập";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(409, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 19);
            this.label1.TabIndex = 20;
            this.label1.Text = "Số Lượng Tồn";
            // 
            // txt_soLuongTon
            // 
            this.txt_soLuongTon.Enabled = false;
            this.txt_soLuongTon.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_soLuongTon.Location = new System.Drawing.Point(573, 68);
            this.txt_soLuongTon.Multiline = true;
            this.txt_soLuongTon.Name = "txt_soLuongTon";
            this.txt_soLuongTon.ReadOnly = true;
            this.txt_soLuongTon.Size = new System.Drawing.Size(111, 27);
            this.txt_soLuongTon.TabIndex = 19;
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
            // nud_soLuongNhap
            // 
            this.nud_soLuongNhap.Location = new System.Drawing.Point(220, 81);
            this.nud_soLuongNhap.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_soLuongNhap.Name = "nud_soLuongNhap";
            this.nud_soLuongNhap.Size = new System.Drawing.Size(78, 22);
            this.nud_soLuongNhap.TabIndex = 14;
            this.nud_soLuongNhap.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_soLuongNhap.ValueChanged += new System.EventHandler(this.nud_soLuong_ValueChanged);
            // 
            // txt_tongTien
            // 
            this.txt_tongTien.Enabled = false;
            this.txt_tongTien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tongTien.Location = new System.Drawing.Point(206, 149);
            this.txt_tongTien.Multiline = true;
            this.txt_tongTien.Name = "txt_tongTien";
            this.txt_tongTien.ReadOnly = true;
            this.txt_tongTien.Size = new System.Drawing.Size(136, 28);
            this.txt_tongTien.TabIndex = 11;
            // 
            // txt_donGiaNhap
            // 
            this.txt_donGiaNhap.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_donGiaNhap.Location = new System.Drawing.Point(559, 10);
            this.txt_donGiaNhap.Multiline = true;
            this.txt_donGiaNhap.Name = "txt_donGiaNhap";
            this.txt_donGiaNhap.Size = new System.Drawing.Size(125, 27);
            this.txt_donGiaNhap.TabIndex = 10;
            this.txt_donGiaNhap.TextChanged += new System.EventHandler(this.txt_donGia_TextChanged);
            this.txt_donGiaNhap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_donGiaNhap_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label11.Location = new System.Drawing.Point(21, 158);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(159, 19);
            this.label11.TabIndex = 4;
            this.label11.Text = "Tổng Tiền Sản Phẩm";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(407, 13);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(113, 19);
            this.label12.TabIndex = 5;
            this.label12.Text = "Đơn Giá Nhập";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(52, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 19);
            this.label8.TabIndex = 4;
            this.label8.Text = "Số Lượng Nhập";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_tenNCC);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_sdt);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txt_diaChi);
            this.panel1.Location = new System.Drawing.Point(785, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(381, 196);
            this.panel1.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên NCC";
            // 
            // txt_tenNCC
            // 
            this.txt_tenNCC.Enabled = false;
            this.txt_tenNCC.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tenNCC.Location = new System.Drawing.Point(147, 15);
            this.txt_tenNCC.Multiline = true;
            this.txt_tenNCC.Name = "txt_tenNCC";
            this.txt_tenNCC.ReadOnly = true;
            this.txt_tenNCC.Size = new System.Drawing.Size(188, 27);
            this.txt_tenNCC.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "SDT";
            // 
            // txt_sdt
            // 
            this.txt_sdt.Enabled = false;
            this.txt_sdt.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sdt.Location = new System.Drawing.Point(150, 81);
            this.txt_sdt.Multiline = true;
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.ReadOnly = true;
            this.txt_sdt.Size = new System.Drawing.Size(185, 27);
            this.txt_sdt.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 23);
            this.label4.TabIndex = 2;
            this.label4.Text = "Địa Chỉ";
            // 
            // txt_diaChi
            // 
            this.txt_diaChi.Enabled = false;
            this.txt_diaChi.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_diaChi.Location = new System.Drawing.Point(147, 143);
            this.txt_diaChi.Multiline = true;
            this.txt_diaChi.Name = "txt_diaChi";
            this.txt_diaChi.ReadOnly = true;
            this.txt_diaChi.Size = new System.Drawing.Size(188, 27);
            this.txt_diaChi.TabIndex = 7;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_themNCC,
            this.toolStripSeparator7,
            this.tsb_themSP,
            this.toolStripSeparator2,
            this.tsb_xoaSP,
            this.toolStripSeparator3,
            this.tsb_xoaPhieuNhap,
            this.toolStripSeparator1,
            this.ts_lamMoiDS,
            this.toolStripSeparator6,
            this.tscbb_maSP,
            this.toolStripSeparator8,
            this.toolStripLabel1,
            this.tstxt_tenSP,
            this.toolStripSeparator5,
            this.tscbb_maNCC,
            this.toolStripSeparator4,
            this.tscbb_maPN});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1410, 31);
            this.toolStrip1.TabIndex = 43;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsb_themNCC
            // 
            this.tsb_themNCC.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_themNCC.Image = ((System.Drawing.Image)(resources.GetObject("tsb_themNCC.Image")));
            this.tsb_themNCC.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_themNCC.Name = "tsb_themNCC";
            this.tsb_themNCC.Size = new System.Drawing.Size(29, 28);
            this.tsb_themNCC.Text = "&Thêm Nhà Cung Cấp";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 31);
            // 
            // tsb_themSP
            // 
            this.tsb_themSP.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_themSP.Image = ((System.Drawing.Image)(resources.GetObject("tsb_themSP.Image")));
            this.tsb_themSP.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_themSP.Name = "tsb_themSP";
            this.tsb_themSP.Size = new System.Drawing.Size(29, 28);
            this.tsb_themSP.Text = "&Thêm Sản Phẩm";
            this.tsb_themSP.Click += new System.EventHandler(this.tsb_themSP_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // tsb_xoaSP
            // 
            this.tsb_xoaSP.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_xoaSP.Image = ((System.Drawing.Image)(resources.GetObject("tsb_xoaSP.Image")));
            this.tsb_xoaSP.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_xoaSP.Name = "tsb_xoaSP";
            this.tsb_xoaSP.Size = new System.Drawing.Size(29, 28);
            this.tsb_xoaSP.Text = "&Xóa Sản Phẩm";
            this.tsb_xoaSP.Click += new System.EventHandler(this.tsb_xoaSP_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 31);
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
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
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
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 31);
            // 
            // tscbb_maSP
            // 
            this.tscbb_maSP.Name = "tscbb_maSP";
            this.tscbb_maSP.Size = new System.Drawing.Size(140, 31);
            this.tscbb_maSP.Text = "Mã Sản Phẩm";
            this.tscbb_maSP.SelectedIndexChanged += new System.EventHandler(this.tscbb_maSP_SelectedIndexChanged);
            this.tscbb_maSP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tscbb_maSP_KeyPress);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(101, 28);
            this.toolStripLabel1.Text = "Tên Sản Phẩm";
            // 
            // tstxt_tenSP
            // 
            this.tstxt_tenSP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tstxt_tenSP.Name = "tstxt_tenSP";
            this.tstxt_tenSP.Size = new System.Drawing.Size(100, 31);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 31);
            // 
            // tscbb_maNCC
            // 
            this.tscbb_maNCC.Name = "tscbb_maNCC";
            this.tscbb_maNCC.Size = new System.Drawing.Size(161, 31);
            this.tscbb_maNCC.Text = "Mã Nhà Cung Cấp";
            this.tscbb_maNCC.SelectedIndexChanged += new System.EventHandler(this.tscbb_maNCC_SelectedIndexChanged);
            this.tscbb_maNCC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tscbb_maNCC_KeyPress);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 31);
            // 
            // tscbb_maPN
            // 
            this.tscbb_maPN.Name = "tscbb_maPN";
            this.tscbb_maPN.Size = new System.Drawing.Size(160, 31);
            this.tscbb_maPN.Text = "Mã Phiếu Nhập";
            this.tscbb_maPN.SelectedIndexChanged += new System.EventHandler(this.tscbb_maPN_SelectedIndexChanged);
            this.tscbb_maPN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tscbb_maPN_KeyPress);
            // 
            // ChiTietNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1410, 683);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgv_nhapHang);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChiTietNhapHang";
            this.Text = "ChiTietNhapHang";
            this.Load += new System.EventHandler(this.ChiTietNhapHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nhapHang)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_soLuongNhap)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_nhapHang;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_tienTra;
        private System.Windows.Forms.Button btn_tinhTienPN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_tienNhan;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_ttPhieuNhap;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_soLuongTon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_tienGuiTra;
        private System.Windows.Forms.NumericUpDown nud_soLuongNhap;
        private System.Windows.Forms.TextBox txt_tongTien;
        private System.Windows.Forms.TextBox txt_donGiaNhap;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_tenNCC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_sdt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_diaChi;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsb_themSP;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsb_xoaSP;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsb_xoaPhieuNhap;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton ts_lamMoiDS;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripComboBox tscbb_maSP;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripComboBox tscbb_maPN;
        private System.Windows.Forms.ToolStripComboBox tscbb_maNCC;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton tsb_themNCC;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.DataGridViewTextBoxColumn coll_MaSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn coll_MaPhieuNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn coll_SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn coll_DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn coll_ThanhTien;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox tstxt_tenSP;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_donGiaBan;
    }
}