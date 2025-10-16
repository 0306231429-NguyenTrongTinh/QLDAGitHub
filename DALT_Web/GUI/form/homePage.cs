using GUI.form;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{

    public partial class homePage: Form
    {
        private string userRole;
        private string tk;
        private string mk;
        private string idnv;
        public homePage( string role,string user,string pass,string idNV)
        {
            InitializeComponent();
            userRole = role;
            tk = user;
            mk = pass;
            idnv = idNV;
        }

        private void homePage_Load(object sender, EventArgs e)
        {
            string wc = " - Người đăng nhập: " + tk + "(" + userRole + ")";
            this.Text = "🏪 Hệ Thống Quản Lý Siêu Thị Mini-[Homepage] "+wc;
            
            if (userRole== "Admin")
            {
                admin();
            }
           else if(userRole== "QuanLy")
            {
                quanly();
            }
           else if(userRole== "NhanVien")
            {
                nhanvien();
            }
        }

        private void admin()
        {
            menu_banHang.Visible = false;
        }
        private void nhanvien()
        {
            menu_quanLyHoaDon.Visible = false;
            coll_nhapHang.Visible = false;
            coll_thongKeBaoCao.Visible = false;
            coll_quanLyNhanVien.Visible = false;
            menu_themTK.Visible = false;
            
        }
        private void quanly()
        {
            menu_banHang.Visible = false;
            menu_qlTK_PQ.Visible = false;
        }


        private void menu_dangNhap_Click(object sender, EventArgs e)
        {
            
        }
        private void chucNang(Form childForm)
        {

            childForm.MdiParent = this;
            childForm.Show();
            childForm.Dock = DockStyle.Fill;
        }


        private void menu_banHang_Click(object sender, EventArgs e)
        {
            chucNang(new ThanhToan(idnv));
            this.Text = "🏪 Hệ Thống Quản Lý Siêu Thị Mini-[Thanh Toán] ";
        }

        private void menu_dsKhachHang_Click(object sender, EventArgs e)
        {
            chucNang(new KhachHang(userRole,""));
            this.Text = "🏪 Hệ Thống Quản Lý Siêu Thị Mini-[Khách Hàng] ";
        }

        private void menu_dsSanPham_Click(object sender, EventArgs e)
        {
            chucNang(new SanPham(userRole));
            this.Text = "🏪 Hệ Thống Quản Lý Siêu Thị Mini-[Sản Phẩm] ";
        }

        

        private void menu_nhapHangMoi_Click(object sender, EventArgs e)
        {
            chucNang(new ChiTietNhapHang(idnv));
            this.Text = "🏪 Hệ Thống Quản Lý Siêu Thị Mini-[Nhập Hàng Mới] ";
        }

        private void menu_dangXuat_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            this.Hide();
            lg.ShowDialog();
        }

       

        private void menu_thoat_Click(object sender, EventArgs e)
        {
            DialogResult dt = MessageBox.Show("Bạn Muốn Thoát Chương Trình?", "Thông Báo",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dt == DialogResult.OK)
            {
                this.Close();
            }
            else
            {
                return;
            }
        }

        private void menu_doiMatKhau_Click(object sender, EventArgs e)
        {
            DoiMK load = new DoiMK(tk, mk);
            this.Hide();
            load.ShowDialog();
        }

        private void menu_quanLyHoaDon_Click(object sender, EventArgs e)
        {
            chucNang(new QuanLyHoaDon());
            this.Text = "🏪 Hệ Thống Quản Lý Siêu Thị Mini-[Quản Lý Hóa Đơn] ";
        }

        private void coll_troGiup_Click(object sender, EventArgs e)
        {

        }


        

        private void menu_dsNCC_Click(object sender, EventArgs e)
        {
            chucNang(new NhaCungCap());
            this.Text = "🏪 Hệ Thống Quản Lý Siêu Thị Mini-[Nhà Cung Cấp] ";
        }

        private void menu_lsNhapHang_Click(object sender, EventArgs e)
        {
            chucNang(new NhapHang(idnv));
            this.Text = "🏪 Hệ Thống Quản Lý Siêu Thị Mini-[Lịch Sử Nhập Hàng] ";
        }

        private void menu_thongKeDoanhThu_Click(object sender, EventArgs e)
        {
            chucNang(new ThongKeDoanhThu());
            this.Text = "🏪 Hệ Thống Quản Lý Siêu Thị Mini-[Thống Kê Doanh Thu] ";
        }

        private void menu_tkSpBanChay_Click(object sender, EventArgs e)
        {
            chucNang(new ThongKeSpBanChay());
            this.Text = "🏪 Hệ Thống Quản Lý Siêu Thị Mini-[Thống Kê Sản Phẩm Bán Chạy] ";
        }

        private void menu_dsNhanVien_Click(object sender, EventArgs e)
        {
            chucNang(new NhanVien(""));
            this.Text = "🏪 Hệ Thống Quản Lý Siêu Thị Mini-[Danh Sách Nhân Viên] ";
        }

        

        private void menu_qlTK_PQ_Click(object sender, EventArgs e)
        {
            chucNang(new QuanLyTaiKhoan());
            this.Text = "🏪 Hệ Thống Quản Lý Siêu Thị Mini-[Quản Lý Tài Khoản] ";
        }

        private void menu_themTK_Click(object sender, EventArgs e)
        {
            chucNang(new ThemTK(""));
            this.Text = "🏪 Hệ Thống Quản Lý Siêu Thị Mini-[Thêm Tài Khoản] ";
        }

        private void menu_dsLoaiSanPham_Click(object sender, EventArgs e)
        {
            chucNang(new LoaiSanPham(userRole));
            this.Text = "🏪 Hệ Thống Quản Lý Siêu Thị Mini-[Loại Sản Phẩm] ";
        }

        private void menu_khoHang_Click(object sender, EventArgs e)
        {
            chucNang(new KhoHang());
            this.Text = "🏪 Hệ Thống Quản Lý Siêu Thị Mini-[Kho Hàng] ";
        }

        private void menu_tkKhMuaNhieuNhat_Click(object sender, EventArgs e)
        {
            chucNang(new TkKhMuaNhieu());
            this.Text = "🏪 Hệ Thống Quản Lý Siêu Thị Mini-[Thống Kê Khách Hàng Mua Nhiều] ";
        }

        private void menu_baoCaoDoanhSo_Click(object sender, EventArgs e)
        {
            chucNang(new DoanhThuNgThNam());
            this.Text = "🏪 Hệ Thống Quản Lý Siêu Thị Mini-[Doanh Thu Theo Ng/Th/Nam] ";
        }
    }
}
