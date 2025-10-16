namespace GUI
{
    partial class homePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(homePage));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.coll_heThong = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_themTK = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_doiMatKhau = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_dangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_thoat = new System.Windows.Forms.ToolStripMenuItem();
            this.coll_quanLyBan = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_banHang = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_quanLyHoaDon = new System.Windows.Forms.ToolStripMenuItem();
            this.coll_quanLySanPham = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_dsSanPham = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_dsLoaiSanPham = new System.Windows.Forms.ToolStripMenuItem();
            this.coll_quanLyKhachHang = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_dsKhachHang = new System.Windows.Forms.ToolStripMenuItem();
            this.coll_nhapHang = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_dsNCC = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_nhapHangMoi = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_NhapHang = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_khoHang = new System.Windows.Forms.ToolStripMenuItem();
            this.coll_thongKeBaoCao = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_thongKeDoanhThu = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_tkSpBanChay = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_tkKhMuaNhieuNhat = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_baoCaoDoanhSo = new System.Windows.Forms.ToolStripMenuItem();
            this.coll_quanLyNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_dsNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_qlTK_PQ = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.coll_heThong,
            this.coll_quanLyBan,
            this.coll_quanLySanPham,
            this.coll_quanLyKhachHang,
            this.coll_nhapHang,
            this.coll_thongKeBaoCao,
            this.coll_quanLyNhanVien});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1392, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // coll_heThong
            // 
            this.coll_heThong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_themTK,
            this.menu_doiMatKhau,
            this.menu_dangXuat,
            this.menu_thoat});
            this.coll_heThong.Name = "coll_heThong";
            this.coll_heThong.Size = new System.Drawing.Size(88, 24);
            this.coll_heThong.Text = "Hệ Thống";
            // 
            // menu_themTK
            // 
            this.menu_themTK.Name = "menu_themTK";
            this.menu_themTK.Size = new System.Drawing.Size(226, 26);
            this.menu_themTK.Text = "🔹 Thêm Tài Khoản ";
            this.menu_themTK.Click += new System.EventHandler(this.menu_themTK_Click);
            // 
            // menu_doiMatKhau
            // 
            this.menu_doiMatKhau.Name = "menu_doiMatKhau";
            this.menu_doiMatKhau.Size = new System.Drawing.Size(226, 26);
            this.menu_doiMatKhau.Text = "🔹 Đổi mật khẩu";
            this.menu_doiMatKhau.Click += new System.EventHandler(this.menu_doiMatKhau_Click);
            // 
            // menu_dangXuat
            // 
            this.menu_dangXuat.Name = "menu_dangXuat";
            this.menu_dangXuat.Size = new System.Drawing.Size(226, 26);
            this.menu_dangXuat.Text = "🔹 Đăng xuất";
            this.menu_dangXuat.Click += new System.EventHandler(this.menu_dangXuat_Click);
            // 
            // menu_thoat
            // 
            this.menu_thoat.Name = "menu_thoat";
            this.menu_thoat.Size = new System.Drawing.Size(226, 26);
            this.menu_thoat.Text = "🔹 Thoát";
            this.menu_thoat.Click += new System.EventHandler(this.menu_thoat_Click);
            // 
            // coll_quanLyBan
            // 
            this.coll_quanLyBan.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_banHang,
            this.menu_quanLyHoaDon});
            this.coll_quanLyBan.Name = "coll_quanLyBan";
            this.coll_quanLyBan.Size = new System.Drawing.Size(106, 24);
            this.coll_quanLyBan.Text = "Quản lý bán ";
            // 
            // menu_banHang
            // 
            this.menu_banHang.Name = "menu_banHang";
            this.menu_banHang.Size = new System.Drawing.Size(226, 26);
            this.menu_banHang.Text = "🛒 Bán hàng";
            this.menu_banHang.Click += new System.EventHandler(this.menu_banHang_Click);
            // 
            // menu_quanLyHoaDon
            // 
            this.menu_quanLyHoaDon.Name = "menu_quanLyHoaDon";
            this.menu_quanLyHoaDon.Size = new System.Drawing.Size(226, 26);
            this.menu_quanLyHoaDon.Text = "📄 Quản lý hóa đơn";
            this.menu_quanLyHoaDon.Click += new System.EventHandler(this.menu_quanLyHoaDon_Click);
            // 
            // coll_quanLySanPham
            // 
            this.coll_quanLySanPham.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_dsSanPham,
            this.menu_dsLoaiSanPham});
            this.coll_quanLySanPham.Name = "coll_quanLySanPham";
            this.coll_quanLySanPham.Size = new System.Drawing.Size(145, 24);
            this.coll_quanLySanPham.Text = " Quản lý sản phẩm";
            // 
            // menu_dsSanPham
            // 
            this.menu_dsSanPham.Name = "menu_dsSanPham";
            this.menu_dsSanPham.Size = new System.Drawing.Size(282, 26);
            this.menu_dsSanPham.Text = "📦 Danh sách sản phẩm";
            this.menu_dsSanPham.Click += new System.EventHandler(this.menu_dsSanPham_Click);
            // 
            // menu_dsLoaiSanPham
            // 
            this.menu_dsLoaiSanPham.Name = "menu_dsLoaiSanPham";
            this.menu_dsLoaiSanPham.Size = new System.Drawing.Size(282, 26);
            this.menu_dsLoaiSanPham.Text = "📦 Danh sách loại sản phẩm";
            this.menu_dsLoaiSanPham.Click += new System.EventHandler(this.menu_dsLoaiSanPham_Click);
            // 
            // coll_quanLyKhachHang
            // 
            this.coll_quanLyKhachHang.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_dsKhachHang});
            this.coll_quanLyKhachHang.Name = "coll_quanLyKhachHang";
            this.coll_quanLyKhachHang.Size = new System.Drawing.Size(152, 24);
            this.coll_quanLyKhachHang.Text = "Quản lý khách hàng";
            // 
            // menu_dsKhachHang
            // 
            this.menu_dsKhachHang.Name = "menu_dsKhachHang";
            this.menu_dsKhachHang.Size = new System.Drawing.Size(264, 26);
            this.menu_dsKhachHang.Text = "👤 Danh sách khách hàng";
            this.menu_dsKhachHang.Click += new System.EventHandler(this.menu_dsKhachHang_Click);
            // 
            // coll_nhapHang
            // 
            this.coll_nhapHang.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_dsNCC,
            this.menu_nhapHangMoi,
            this.menu_NhapHang,
            this.menu_khoHang});
            this.coll_nhapHang.Name = "coll_nhapHang";
            this.coll_nhapHang.Size = new System.Drawing.Size(96, 24);
            this.coll_nhapHang.Text = "Nhập hàng";
            // 
            // menu_dsNCC
            // 
            this.menu_dsNCC.Name = "menu_dsNCC";
            this.menu_dsNCC.Size = new System.Drawing.Size(277, 26);
            this.menu_dsNCC.Text = "🏢 Danh sách nhà cung cấp";
            this.menu_dsNCC.Click += new System.EventHandler(this.menu_dsNCC_Click);
            // 
            // menu_nhapHangMoi
            // 
            this.menu_nhapHangMoi.Name = "menu_nhapHangMoi";
            this.menu_nhapHangMoi.Size = new System.Drawing.Size(277, 26);
            this.menu_nhapHangMoi.Text = "📥 Nhập hàng mới";
            this.menu_nhapHangMoi.Click += new System.EventHandler(this.menu_nhapHangMoi_Click);
            // 
            // menu_NhapHang
            // 
            this.menu_NhapHang.Name = "menu_NhapHang";
            this.menu_NhapHang.Size = new System.Drawing.Size(277, 26);
            this.menu_NhapHang.Text = "📝 Quản lý nhập hàng";
            this.menu_NhapHang.Click += new System.EventHandler(this.menu_lsNhapHang_Click);
            // 
            // menu_khoHang
            // 
            this.menu_khoHang.Name = "menu_khoHang";
            this.menu_khoHang.Size = new System.Drawing.Size(277, 26);
            this.menu_khoHang.Text = "📦 Kho Hàng";
            this.menu_khoHang.Click += new System.EventHandler(this.menu_khoHang_Click);
            // 
            // coll_thongKeBaoCao
            // 
            this.coll_thongKeBaoCao.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_thongKeDoanhThu,
            this.menu_tkSpBanChay,
            this.menu_tkKhMuaNhieuNhat,
            this.menu_baoCaoDoanhSo});
            this.coll_thongKeBaoCao.Name = "coll_thongKeBaoCao";
            this.coll_thongKeBaoCao.Size = new System.Drawing.Size(146, 24);
            this.coll_thongKeBaoCao.Text = "Thống kê & Báo cáo";
            // 
            // menu_thongKeDoanhThu
            // 
            this.menu_thongKeDoanhThu.Name = "menu_thongKeDoanhThu";
            this.menu_thongKeDoanhThu.Size = new System.Drawing.Size(385, 26);
            this.menu_thongKeDoanhThu.Text = "📊 Thống kê doanh thu";
            this.menu_thongKeDoanhThu.Click += new System.EventHandler(this.menu_thongKeDoanhThu_Click);
            // 
            // menu_tkSpBanChay
            // 
            this.menu_tkSpBanChay.Name = "menu_tkSpBanChay";
            this.menu_tkSpBanChay.Size = new System.Drawing.Size(385, 26);
            this.menu_tkSpBanChay.Text = "📦 Thống kê sản phẩm bán chạy";
            this.menu_tkSpBanChay.Click += new System.EventHandler(this.menu_tkSpBanChay_Click);
            // 
            // menu_tkKhMuaNhieuNhat
            // 
            this.menu_tkKhMuaNhieuNhat.Name = "menu_tkKhMuaNhieuNhat";
            this.menu_tkKhMuaNhieuNhat.Size = new System.Drawing.Size(385, 26);
            this.menu_tkKhMuaNhieuNhat.Text = "🛍️ Thống kê khách hàng mua nhiều nhất";
            this.menu_tkKhMuaNhieuNhat.Click += new System.EventHandler(this.menu_tkKhMuaNhieuNhat_Click);
            // 
            // menu_baoCaoDoanhSo
            // 
            this.menu_baoCaoDoanhSo.Name = "menu_baoCaoDoanhSo";
            this.menu_baoCaoDoanhSo.Size = new System.Drawing.Size(385, 26);
            this.menu_baoCaoDoanhSo.Text = "📆 Báo cáo doanh số theo ngày/tháng/năm";
            this.menu_baoCaoDoanhSo.Click += new System.EventHandler(this.menu_baoCaoDoanhSo_Click);
            // 
            // coll_quanLyNhanVien
            // 
            this.coll_quanLyNhanVien.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_dsNhanVien,
            this.menu_qlTK_PQ});
            this.coll_quanLyNhanVien.Name = "coll_quanLyNhanVien";
            this.coll_quanLyNhanVien.Size = new System.Drawing.Size(140, 24);
            this.coll_quanLyNhanVien.Text = "Quản lý nhân viên";
            // 
            // menu_dsNhanVien
            // 
            this.menu_dsNhanVien.Name = "menu_dsNhanVien";
            this.menu_dsNhanVien.Size = new System.Drawing.Size(317, 26);
            this.menu_dsNhanVien.Text = "👥 Danh sách nhân viên";
            this.menu_dsNhanVien.Click += new System.EventHandler(this.menu_dsNhanVien_Click);
            // 
            // menu_qlTK_PQ
            // 
            this.menu_qlTK_PQ.Name = "menu_qlTK_PQ";
            this.menu_qlTK_PQ.Size = new System.Drawing.Size(317, 26);
            this.menu_qlTK_PQ.Text = "🔐 Quản lý tài khoản & phân quyền";
            this.menu_qlTK_PQ.Click += new System.EventHandler(this.menu_qlTK_PQ_Click);
            // 
            // homePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1392, 636);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "homePage";
            this.Load += new System.EventHandler(this.homePage_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem coll_heThong;
        private System.Windows.Forms.ToolStripMenuItem coll_quanLyBan;
        private System.Windows.Forms.ToolStripMenuItem coll_quanLySanPham;
        private System.Windows.Forms.ToolStripMenuItem coll_quanLyKhachHang;
        private System.Windows.Forms.ToolStripMenuItem coll_nhapHang;
        private System.Windows.Forms.ToolStripMenuItem menu_dangXuat;
        private System.Windows.Forms.ToolStripMenuItem menu_doiMatKhau;
        private System.Windows.Forms.ToolStripMenuItem menu_thoat;
        private System.Windows.Forms.ToolStripMenuItem menu_banHang;
        private System.Windows.Forms.ToolStripMenuItem menu_quanLyHoaDon;
        private System.Windows.Forms.ToolStripMenuItem menu_dsSanPham;
        private System.Windows.Forms.ToolStripMenuItem menu_dsKhachHang;
        private System.Windows.Forms.ToolStripMenuItem menu_dsNCC;
        private System.Windows.Forms.ToolStripMenuItem menu_nhapHangMoi;
        private System.Windows.Forms.ToolStripMenuItem menu_NhapHang;
        private System.Windows.Forms.ToolStripMenuItem coll_thongKeBaoCao;
        private System.Windows.Forms.ToolStripMenuItem menu_thongKeDoanhThu;
        private System.Windows.Forms.ToolStripMenuItem menu_tkSpBanChay;
        private System.Windows.Forms.ToolStripMenuItem menu_tkKhMuaNhieuNhat;
        private System.Windows.Forms.ToolStripMenuItem menu_baoCaoDoanhSo;
        private System.Windows.Forms.ToolStripMenuItem coll_quanLyNhanVien;
        private System.Windows.Forms.ToolStripMenuItem menu_dsNhanVien;
        private System.Windows.Forms.ToolStripMenuItem menu_qlTK_PQ;
        private System.Windows.Forms.ToolStripMenuItem menu_themTK;
        private System.Windows.Forms.ToolStripMenuItem menu_dsLoaiSanPham;
        private System.Windows.Forms.ToolStripMenuItem menu_khoHang;
    }
}