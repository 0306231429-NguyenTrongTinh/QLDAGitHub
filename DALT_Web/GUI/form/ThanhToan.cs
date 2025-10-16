using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using GUI.form;
namespace GUI
{
    public partial class ThanhToan: Form
    {
        private float tongT = 0;
        private int sl = 0;
        //private string maHD;
        private string maKH;
        private string manv;
        private bool flag = false;
        HoaDonBLL hdb = new HoaDonBLL();
        SanPhamBLL spb = new SanPhamBLL();
        ChiTietHoaDonBLL cthdB = new ChiTietHoaDonBLL();
        SanPhamDTO sp = new SanPhamDTO();
        KhachHangDTO kh = new KhachHangDTO();
        KhachHangBLL khb = new KhachHangBLL();
        public ThanhToan( string id)
        {
            InitializeComponent();
            manv = id;
        }

        private void btn_tinhTien_Click(object sender, EventArgs e)
        {
            
            if(tscbb_maHoaDon.SelectedIndex==-1 && string.IsNullOrWhiteSpace(txt_ttHoaDon.Text))
            {
                MessageBox.Show("Chưa có hóa đơn để thanh toán", "Thông Báo");
                return;
            }

            

            if (string.IsNullOrWhiteSpace(txt_tienNhan.Text))
            {
                MessageBox.Show("Hay nhap so tien nhan", "Thong bao");
                return;
            }


            


            if (double.TryParse(txt_tienNhan.Text, out double tn)){
                if (tn < tongT)
                {
                    MessageBox.Show("Tien nhan khong nho hon tong hoa don", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    if (tscbb_hinhThuc.SelectedIndex==-1)
                    {
                        MessageBox.Show("Hay chon hinh thuc thanh toan", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        int dtl = khb.loadDTLKhachHangBLL(tscbb_maKhachHang.Text);
                        if (dtl > 10)
                        {
                            DialogResult dt = MessageBox.Show($"Ban co {dtl}" +
                                 $" diem tich luy, xac nhan dung(1đ=100VND) ", "Thong Bao", MessageBoxButtons.OKCancel);
                            if (dt == DialogResult.OK)
                            {
                                tongT = tongT - dtl / 10 * 1000;
                                khb.updateDTLKhBLL(-dtl, tscbb_maKhachHang.Text);
                                txt_ttHoaDon.Text = tongT.ToString();
                            }
                        }


                        HoaDonDTO hd = new HoaDonDTO();
                        hd.MaHoaDon = tscbb_maHoaDon.Text;
                        hd.NgayLap = DateTime.Now;
                        hd.MaNhanVien = manv;
                        hd.MaKhachHang = tscbb_maKhachHang.Text;
                        hd.TongTien = (float)tongT;
                        hd.HinhThuc = tscbb_hinhThuc.Text;
                        hd.TrangThai = "Đã thanh toán";

                        
                        khb.updateDTLKhBLL((int)tongT/10000, tscbb_maKhachHang.Text);
                        

                        string kq = hdb.updateHdBLL(hd);
                        if (kq == "stc")
                        {
                            tb("Thanh toan thanh cong");
                            flag = false;
                            txt_tienTra.Text = (tn - tongT).ToString();
                            reset();
                            return;
                        }
                        else
                        {
                            tb("Thanh toan that bai");
                            return;
                        }
                    }

                    
                }
            }
        }



        private void tb(string tb)
        {
            ThongBao tbao = new ThongBao(tb);

            tbao.Load += (s, e) =>
            {
                // Lấy kích thước màn hình
                int screenWidth = Screen.PrimaryScreen.WorkingArea.Width;
                int screenHeight = Screen.PrimaryScreen.WorkingArea.Height;

                // Đặt vị trí của form ThongBao ở góc dưới bên phải
                tbao.Location = new Point(screenWidth - tbao.Width - 10, 10);  // -10 để tránh bị chạm vào góc màn hình
            };
            tbao.Show();

        }


        private void Lmsp ()
        {
            List<string> LoadMaspList = spb.LoadMaspBLL();
            tscbb_maSanPham.Items.Clear();
            foreach (string masp in LoadMaspList)
            {
                tscbb_maSanPham.Items.Add(masp);
            }
            tscbb_maSanPham.Sorted = true;
        }

        private void Lmkh()
        {
            List<string> LoadMaKHList = khb.LoadMaKHBLL();
            tscbb_maKhachHang.Items.Clear();
            foreach (string makh in LoadMaKHList)
            {
                tscbb_maKhachHang.Items.Add(makh);
            }
            tscbb_maKhachHang.Sorted = true;
        }
        private void SanPham_Load(object sender, EventArgs e)
        {
            
            Lmsp();
            Lmkh();
            

            LoadMhd();

            tscbb_hinhThuc.Items.Add("Tiền mặt");
            tscbb_hinhThuc.Items.Add("Trực tuyến");

            tsTxt_nhapMaSp.SelectionStart = tsTxt_nhapMaSp.Text.Length;   // lỗi hai con trỏ
            tsTxt_nhapMaSp.SelectionLength = 0;

            txt_tienNhan.SelectionStart = txt_tienNhan.Text.Length;   // lỗi hai con trỏ
            txt_tienNhan.SelectionLength = 0;

            txt_tienGuiTra.SelectionStart = txt_tienGuiTra.Text.Length;   // lỗi hai con trỏ
            txt_tienGuiTra.SelectionLength = 0;

        }


        private void nud_soLuong_ValueChanged(object sender, EventArgs e)
        {
            TongTien();
        }
        private void TongTien()
        {
            int sl = (int)nud_soLuong.Value;
            double tt = 0;
            if (double.TryParse(txt_donGia.Text, out double donGia))
            {
                tt = sl * donGia;
            }
            
            txt_tongTien.Text = tt.ToString();
        }

        private void txt_donGia_TextChanged(object sender, EventArgs e)
        {
            TongTien();
        }

        

        private void tsb_timSP_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(tsTxt_nhapMaSp.Text))
            {
                MessageBox.Show("Mã sản phẩm không bỏ trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                sp.MaSanPham = tsTxt_nhapMaSp.Text;
                List<string> MaspList = spb.checkMaspBLL(sp);

                tscbb_maSanPham.Items.Clear();

                foreach (string masp in MaspList)
                {
                    tscbb_maSanPham.Items.Add(masp);
                }

                if (tscbb_maSanPham.Items.Count > 0)
                {
                    tscbb_maSanPham.DroppedDown = true;
                }
            }

        }

        private void tscbb_maSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tscbb_maSanPham.Items.Count > 0)
            {
                if(tscbb_maSanPham.SelectedIndex != -1)
                {
                    sp.MaSanPham = tscbb_maSanPham.SelectedItem.ToString();
                    List<string> dssp = spb.LoadThongTinSpBLL(sp);
                    txt_tenSanPham.Text = dssp[0];
                    txt_donGia.Text = dssp[1];
                    txt_soLuongTon.Text = dssp[2];
                    txt_donVi.Text = dssp[3];
                    txt_maLoai.Text = dssp[4];
                }
                else
                {
                    return;
                }
                
            }
            
        }

        private void tsTxt_nhapMaSp_TextChanged(object sender, EventArgs e)
        {
            Lmsp();
        }

        private void tscbb_maKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (tscbb_maKhachHang.Items.Count > 0)
            {
                tscbb_maHoaDon.Text = "Mã Hóa Đơn";
                tscbb_maHoaDon.Enabled = false;
                if (tscbb_maKhachHang.SelectedIndex !=-1)
                {
                    kh.MaKhachHang = tscbb_maKhachHang.Text;
                    List<string> dskh = khb.LoadThongTinKHBLL(kh);
                    txt_maKH.Text = dskh[0];
                    txt_tenKH.Text = dskh[1];
                    txt_sdt.Text = dskh[2];

                    dgv_thanhToan.Rows.Clear();
                    clear();
                }
                else
                {
                    return;
                }
                

            }
            
        }

        private void tsb_taoHoaDon_Click(object sender, EventArgs e)
        {
            if (tscbb_maHoaDon.Text != "Mã Hóa Đơn")
            {
                MessageBox.Show("Hoa don da ton tai", "Thong bao");
                return;
            }
            if (tscbb_maKhachHang.SelectedIndex == -1)
            {
                MessageBox.Show("Hãy chọn một khách hàng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {

                HoaDonDTO hd = new HoaDonDTO();
                hd.MaHoaDon = hdb.GenerateMaHoaDonBLL();
                hd.NgayLap = DateTime.Now;
                hd.MaNhanVien = manv;
                hd.MaKhachHang = tscbb_maKhachHang.Text;
                hd.TongTien = 0;
                hd.HinhThuc = "Tiền mặt";
                hd.TrangThai = "Chưa thanh toán";

                

                string kq = hdb.themhdBLL(hd);
                flag = true;
                if (kq == "ttc")
                {
                    tb("Thêm thành công ");
                    tscbb_maHoaDon.Items.Clear();
                    LoadMhd();
                    tscbb_maHoaDon.SelectedItem = hd.MaHoaDon;
                    tscbb_maHoaDon.Enabled = false;
                    tscbb_maKhachHang.Enabled = false;
                    return;
                }
                else
                {
                    tb("Thêm thất bại");
                    return;
                }

            }

        }
        private void LoadCthd( string mahd)
        {
            List<ChiTietHoaDonDTO> l = cthdB.loadCthdBLL(mahd);

            dgv_thanhToan.Rows.Clear();

            foreach (var cthd in l)
            {
                dgv_thanhToan.Rows.Add(cthd.MaHoaDon, cthd.MaSanPham, cthd.SoLuong, cthd.DonGia,cthd.ThanhTien);
            }
           
        }


        private void tscbb_maHoaDon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tscbb_maHoaDon.Items.Count > 0)
            {
                dgv_thanhToan.Rows.Clear();
                string mahdCbb = tscbb_maHoaDon.Text;
                tscbb_maKhachHang.SelectedItem = cthdB.maKH_maHdBLL(mahdCbb);  // load thong tin kh khi chon mhd
                tscbb_maHoaDon.Enabled = true;
                LoadCthd(mahdCbb);
                flag = true;

                if(float.TryParse(hdb.tongTienHdBLL(mahdCbb), out float tt))
                {
                    txt_ttHoaDon.Text = tt.ToString("N0");
                    tongT = tt;
                }
                
                
            }
        }
        private void tsb_themCTHD_Click(object sender, EventArgs e)
        {
            if (flag==false)
            {
                MessageBox.Show("Hãy tạo hoac chon mot hóa đơn trước khi thêm hàng", "Thông báo");
                return;
            }
            if (tscbb_maSanPham.SelectedIndex == -1)
            {
                MessageBox.Show("Hay chon mot san pham", "Thong bao");
                return;
            }
            string kq = cthdB.kiemTraSpCthdBLL(tscbb_maHoaDon.Text, tscbb_maSanPham.Text);
            
             
            
            if (kq=="tt")
            {
               DialogResult dt= MessageBox.Show("Sản phẩm đã được thêm vào hóa đơn, xác nhận thay đổi dữ liệu",
                   "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if(dt== DialogResult.OK)
                {
                    sl=cthdB.LoadSlCthdBLL(tscbb_maHoaDon.Text, tscbb_maSanPham.Text);
                    spb.updateSLtonBLL(-sl, tscbb_maSanPham.Text);

                    ChiTietHoaDonDTO cthd = new ChiTietHoaDonDTO();
                    cthd.SoLuong= (int)nud_soLuong.Value;
                    if (float.TryParse(txt_donGia.Text, out float dg))
                    {
                        cthd.DonGia = dg;                         
                        cthd.MaSanPham = tscbb_maSanPham.Text;

                        tongT = tongT - cthdB.kiemTraThanhTienCthdBLL(tscbb_maHoaDon.Text, tscbb_maSanPham.Text);
                        sl=cthdB.LoadSlCthdBLL(tscbb_maHoaDon.Text, tscbb_maSanPham.Text);
                        
                        cthdB.updateCthdBLL(cthd);

                        cthdB.updCthd_HD_BLL(tscbb_maHoaDon.Text);

                        tongT = tongT+ cthdB.kiemTraThanhTienCthdBLL(tscbb_maHoaDon.Text, tscbb_maSanPham.Text);
                        txt_ttHoaDon.Text = tongT.ToString();
                        spb.updateSLtonBLL(cthd.SoLuong, tscbb_maSanPham.Text);
                        tscbb_maSanPham_SelectedIndexChanged(sender, e);
                        LoadCthd(tscbb_maHoaDon.Text);
                        
                        clear();
                    }

                }
                else
                {
                    return;
                }
            }
            else
            {
                
                ChiTietHoaDonDTO ListCthd = new ChiTietHoaDonDTO();
                ListCthd.MaHoaDon = tscbb_maHoaDon.Text;
                ListCthd.MaSanPham = tscbb_maSanPham.Text;
                ListCthd.SoLuong = (int)nud_soLuong.Value;
                if (float.TryParse(txt_donGia.Text, out float dg))
                {
                    ListCthd.DonGia = dg;
                }
                if (cthdB.themCthdBLL(ListCthd) == "ttc")
                {
                    tb("Them thành công");
                }

                cthdB.updCthd_HD_BLL(tscbb_maHoaDon.Text);
                tongT = tongT+ cthdB.kiemTraThanhTienCthdBLL(tscbb_maHoaDon.Text, tscbb_maSanPham.Text);
                txt_ttHoaDon.Text = tongT.ToString();
                spb.updateSLtonBLL(ListCthd.SoLuong, tscbb_maSanPham.Text);
                tscbb_maSanPham_SelectedIndexChanged(sender, e);
                LoadCthd(tscbb_maHoaDon.Text);
                
                clear();
            }

           
        }

        private void LoadMhd()
        {
            List<string> l = hdb.LoadMaHdBLL();

            foreach (var mnv in l)
            {
                tscbb_maHoaDon.Items.Add(mnv);
            }
            tscbb_maHoaDon.Sorted = true;
        }

        


        private void clear()
        {
            tscbb_maSanPham.SelectedIndex = -1;
            tscbb_maSanPham.Text = " Mã Sản Phẩm";

            tsTxt_nhapMaSp.Clear();
            txt_tenSanPham.Clear();
            txt_maLoai.Clear();

            txt_donGia.Clear();
            txt_donVi.Clear();

            txt_soLuongTon.Clear();
            nud_soLuong.Value = 1;
            txt_tongTien.Clear();
        }

        private void reset()
        {
            clear();
            tscbb_maHoaDon.SelectedIndex = -1;
            tscbb_maHoaDon.Text = "Mã Hóa Đơn";
            tscbb_maKhachHang.SelectedIndex = -1;
            tscbb_maKhachHang.Text = "Mã Khách Hàng";
            tscbb_hinhThuc.SelectedIndex = -1;
            tscbb_hinhThuc.Text = "Hình Thức Thanh Toán";
            dgv_thanhToan.Rows.Clear();
            txt_tenKH.Clear();
            txt_maKH.Clear();
            txt_sdt.Clear();
            dgv_thanhToan.Focus();
            tscbb_maHoaDon.Enabled = true;
            tscbb_maKhachHang.Enabled = true;
            tongT = 0;
            txt_ttHoaDon.Clear();
            
        }
        private void ts_lamMoiDS_Click(object sender, EventArgs e)
        {

            reset();
           
            
        }

        private void tsb_xoaPhieuNhap_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void tsb_xoaSanPham_Click(object sender, EventArgs e)
        {
            if (dgv_thanhToan.SelectedRows.Count > 0)
            {
                DialogResult dt = MessageBox.Show("Xóa san pham ?", "Thông báo",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dt == DialogResult.OK)
                {
                    sl = cthdB.LoadSlCthdBLL(tscbb_maHoaDon.Text, tscbb_maSanPham.Text);
                    spb.updateSLtonBLL(-sl, tscbb_maSanPham.Text);
                    tscbb_maSanPham_SelectedIndexChanged(sender, e);

                    tongT = tongT - cthdB.kiemTraThanhTienCthdBLL(tscbb_maHoaDon.Text, tscbb_maSanPham.Text);
                    txt_ttHoaDon.Text = tongT.ToString();

                    string kq = cthdB.xoaRowCthdBLL(tscbb_maHoaDon.Text, tscbb_maSanPham.Text);
                    if (kq == "xtc")
                    {

                        tb("Xóa thành công");

                        
                        if (dgv_thanhToan.SelectedRows.Count == 0)
                        {
                            tongT = 0;
                            txt_ttHoaDon.Text = tongT.ToString();
                        }
                        cthdB.updCthd_HD_BLL(tscbb_maHoaDon.Text);
                        LoadCthd(tscbb_maHoaDon.Text);
                        clear();
                        return;
                    }
                    else
                    {
                        tb("Xóa thất bại");
                        return;
                    }
                }
                else
                {
                    return;
                }

            }
            else
            {
                MessageBox.Show("Hãy chọn một hóa đơn ", "Thông báo");
            }
        }

        private void dgv_thanhToan_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_thanhToan.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgv_thanhToan.SelectedRows[0];
                tscbb_maSanPham.Text = row.Cells["coll_MaSanPham"].Value.ToString();
                tscbb_maSanPham_SelectedIndexChanged(sender, e);
            }
        }

        private void tsb_themKH_Click(object sender, EventArgs e)
        {
            KhachHang kh = new KhachHang("NhanVien","tkh");
            kh.ShowDialog();
            kh.Text = "Thêm khách hàng";
            Lmkh();
            
        }

        private void txt_tienNhan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_tienTra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tscbb_maKhachHang_Click(object sender, EventArgs e)
        {
            tscbb_maKhachHang.Text = "";
        }

        private void tscbb_maSanPham_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsLetter(e.KeyChar) || char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tscbb_maKhachHang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tscbb_maHoaDon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tscbb_hinhThuc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tsTxt_nhapMaSp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetterOrDigit(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
    }
}
