using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;
namespace GUI.form
{
    public partial class ChiTietNhapHang: Form
    {
        SanPhamBLL spb = new SanPhamBLL();
        NhapHangBLL nhb = new NhapHangBLL();
        NhaCungCapBLL nccb = new NhaCungCapBLL();
        ChiTietNhapHangBLL ctnhb = new ChiTietNhapHangBLL();
        private string mnv;
        private string MaPN;
        private int sl = 0;
        private float tongT = 0;
        public ChiTietNhapHang( string idnv)
        {
            InitializeComponent();
            mnv = idnv;
        }

        private void ChiTietNhapHang_Load(object sender, EventArgs e)
        {
            Lmsp();
            Lmpn();
            LmNcc();
            tstxt_tenSP.Enabled = false;

            //txt_donGiaNhap.SelectionStart = txt_donGiaNhap.Text.Length;   // lỗi hai con trỏ
            //txt_donGiaNhap.SelectionLength = 0;



            nud_soLuongNhap.Enabled = false;
            txt_donGiaNhap.Enabled = false;
        }
        private void clear()
        {
            tscbb_maSP.SelectedIndex = -1;
            tscbb_maSP.Text = "Mã Sản Phẩm";
            
            tstxt_tenSP.Clear();
            txt_soLuongTon.Clear();
            nud_soLuongNhap.Value = 1;
            txt_donGiaNhap.Clear();
            txt_tongTien.Clear();
            txt_donGiaBan.Clear();

            nud_soLuongNhap.Enabled = false;
            txt_donGiaNhap.Enabled = false;
        }

        private void reset()
        {
            clear();
            dgv_nhapHang.Rows.Clear();
            tscbb_maNCC.SelectedIndex = -1;
            tscbb_maNCC.Text = "Mã Nhà Cung Cấp";
            tscbb_maPN.SelectedIndex = -1;
            tscbb_maPN.Text = "Mã Phiếu Nhập";
            txt_tenNCC.Clear();
            txt_diaChi.Clear();
            txt_sdt.Clear();
            MaPN = "";
            tscbb_maNCC.Enabled = true;
            
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
        private void Lmsp()
        {
            List<string> LoadMaspList = ctnhb.LoadMaNcc_MaSpBLL(tscbb_maNCC.Text);
            tscbb_maSP.Items.Clear();
            foreach (string masp in LoadMaspList)
            {
                tscbb_maSP.Items.Add(masp);
            }
            tscbb_maSP.Sorted = true;
        }

        private void Lmpn()
        {
            List<string> LoadMaPnList = nhb.LoadMaPnBLL();
            tscbb_maPN.Items.Clear();
            foreach (string masp in LoadMaPnList)
            {
                tscbb_maPN.Items.Add(masp);
            }
            tscbb_maPN.Sorted = true;
        }

        private void LmNcc()
        {
            List<string> LoadMaNccList = nccb.LoadMaNccBLL();
            tscbb_maNCC.Items.Clear();
            foreach (string mancc in LoadMaNccList)
            {
                tscbb_maNCC.Items.Add(mancc);
            }
            tscbb_maNCC.Sorted = true;
        }

        private void tscbb_maSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (tscbb_maSP.Items.Count > 0)
            {
                if(tscbb_maSP.SelectedIndex != -1)
                {
                    SanPhamDTO sp = new SanPhamDTO();
                    sp.MaSanPham = tscbb_maSP.SelectedItem.ToString();
                    List<string> dssp = spb.LoadThongTinSpBLL(sp);
                    tstxt_tenSP.Text = dssp[0];
                    txt_donGiaBan.Text = dssp[1];
                    txt_soLuongTon.Text = dssp[2];
                    if (ctnhb.kiemTraGiaNhapCtnhBLL(tscbb_maSP.Text) > 0)
                    {
                        txt_donGiaNhap.Text = ctnhb.kiemTraGiaNhapCtnhBLL(tscbb_maSP.Text).ToString();
                    }
                    else
                    {
                        txt_donGiaNhap.Text = "0";
                    }
                    nud_soLuongNhap.Enabled = true;
                    txt_donGiaNhap.Enabled = true;
                    nud_soLuongNhap.Value = 1;
                    txt_tongTien.Text = "0";
                    txt_donGiaNhap.Clear();
                }
                else
                {
                    return;
                }
                
               
            }
        }

        

        private void TongTien()
        {
            int sl = (int)nud_soLuongNhap.Value;
            double tt = 0;
            if (double.TryParse(txt_donGiaNhap.Text, out double donGia))
            {
                tt = sl * donGia;
            }

            txt_tongTien.Text = tt.ToString();
        }

        private void nud_soLuong_ValueChanged(object sender, EventArgs e)
        {
            TongTien();
        }

        private void txt_donGia_TextChanged(object sender, EventArgs e)
        {
            TongTien();
        }

        private void tscbb_maPN_SelectedIndexChanged(object sender, EventArgs e)
        {
            MaPN = tscbb_maPN.Text;
            if (tscbb_maPN.Items.Count > 0)
            {
                if (tscbb_maPN.SelectedIndex != -1)
                {
                    LoadCtnh(MaPN);
                    tscbb_maNCC.Text = ctnhb.LoadMaPn_MaNccBLL(tscbb_maPN.Text);
                    tscbb_maNCC.Enabled = false;
                }
                else
                {
                    return;
                }


            }
            
        }

        private void tscbb_maNCC_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tscbb_maPN.Items.Count > 0)
            {
                if(tscbb_maNCC.SelectedIndex != -1)
                {
                    
                    tscbb_maPN.Text = "Mã Phiếu Nhập";
                    
                    dgv_nhapHang.Rows.Clear();
                    
                    List<string> dsNCC = nccb.LoadThongTinNccDAL(tscbb_maNCC.Text);
                    txt_tenNCC.Text = dsNCC[0];
                    txt_sdt.Text = dsNCC[1];
                    txt_diaChi.Text = dsNCC[2];
                    tscbb_maSP.SelectedIndex = -1;
                    Lmsp();
                }
                

            }
        }

        

        private void tsb_xoaPhieuNhap_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void ts_lamMoiDS_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void LoadCtnh(string manh)
        {
            List<ChiTietNhapHangDTO> l = ctnhb.loadCthdBLL(manh);

            dgv_nhapHang.Rows.Clear();

            foreach (var ctnh in l)
            {
                dgv_nhapHang.Rows.Add(ctnh.MaSanPham , ctnh.MaPhieuNhap, ctnh.SoLuong, ctnh.GiaNhap, ctnh.ThanhTien);
            }

        }

        private void tsb_themSP_Click(object sender, EventArgs e)
        {
            MaPN = tscbb_maPN.Text;
            if (tscbb_maPN.SelectedIndex == -1 || tscbb_maSP.SelectedIndex == -1)
            {
                MessageBox.Show("Hãy chọn một phieu nhap va san pham", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(txt_donGiaNhap.Text))
            {
                MessageBox.Show("Hay nhap don gia nhap", "Thong Bao");
                return;
            }
            string kq = ctnhb.kiemTraSpCthdBLL(tscbb_maPN.Text, tscbb_maSP.Text);
            if (kq == "tt")
            {
                DialogResult dt = MessageBox.Show("Sản phẩm đã được thêm vào phiếu nhập, xác nhận thay đổi dữ liệu",
                    "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dt == DialogResult.OK)
                {
                    

                    ChiTietNhapHangDTO ctnh = new ChiTietNhapHangDTO();
                    ctnh.SoLuong = (int)nud_soLuongNhap.Value;
                    if (float.TryParse(txt_donGiaNhap.Text, out float dgn))
                    {
                        ctnh.GiaNhap = dgn;
                        ctnh.MaSanPham = tscbb_maSP.Text;

                        tongT = tongT - ctnhb.kiemTraThanhTienCtnhBLL(MaPN, tscbb_maSP.Text);  // tra tong tien ve ban dau
                        ctnh.SoLuong =(int) nud_soLuongNhap.Value;  


                        ctnhb.updateCtnhBLL(ctnh);    
                        ctnhb.updCtnh_NH_BLL(MaPN);

                        tongT = tongT + ctnhb.kiemTraThanhTienCtnhBLL(MaPN, tscbb_maSP.Text);
                        txt_ttPhieuNhap.Text = tongT.ToString();
                        LoadCtnh(MaPN);
                        tscbb_maPN.Enabled = true;
                    }

                }
                else
                {
                    return;
                }
            }
            else
            {

                ChiTietNhapHangDTO ctnh = new ChiTietNhapHangDTO();
                ctnh.MaPhieuNhap = MaPN;
                ctnh.MaSanPham = tscbb_maSP.Text;
                if (float.TryParse(txt_donGiaNhap.Text, out float dgn))
                {
                    ctnh.GiaNhap = dgn;
                }
                    
                ctnh.SoLuong =(int) nud_soLuongNhap.Value;


                ctnhb.themCtnhBLL(ctnh);

                ctnhb.updCtnh_NH_BLL(tscbb_maPN.Text); // load tong tien phieu nhap
                tongT = tongT + ctnhb.kiemTraThanhTienCtnhBLL(MaPN, tscbb_maSP.Text);  // Update bien tong tien
                txt_ttPhieuNhap.Text = tongT.ToString();  // show tong tien
                LoadCtnh(MaPN);   // load lai ctnh
                tscbb_maPN.Enabled = true;
            }


        }

        private void tsb_xoaSP_Click(object sender, EventArgs e)
        {

            if (dgv_nhapHang.SelectedRows.Count > 0)
            {
                DialogResult dt = MessageBox.Show("Xóa san pham ?", "Thông báo",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dt == DialogResult.OK)
                {
                    

                    tongT = tongT - ctnhb.kiemTraThanhTienCtnhBLL(MaPN, tscbb_maSP.Text);
                    txt_ttPhieuNhap.Text = tongT.ToString();

                    string kq = ctnhb.xoaRowCtnhBLL(MaPN, tscbb_maSP.Text);
                    if (kq == "xtc")
                    {

                        tb("Xóa thành công");


                        if (dgv_nhapHang.SelectedRows.Count == 0)
                        {
                            tongT = 0;
                            txt_ttPhieuNhap.Text = tongT.ToString();
                        }
                        ctnhb.updCtnh_NH_BLL(MaPN);
                        LoadCtnh(MaPN);

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

        private void dgv_nhapHang_SelectionChanged(object sender, EventArgs e)
        {

            if (dgv_nhapHang.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgv_nhapHang.SelectedRows[0];
                tscbb_maSP.Text = row.Cells["coll_MaSanPham"].Value.ToString();
                tscbb_maSP_SelectedIndexChanged(sender, e);

                List<KhoHangDTO> Lkh = ctnhb.loadKhoHangTheoMaSP_BLL(tscbb_maSP.Text);
                if (Lkh.Count > 0)
                {
                    KhoHangDTO kh = Lkh[0];

                    txt_donGiaBan.Text = kh.GiaBan.ToString();
                    txt_donGiaNhap.Text = kh.GiaNhap.ToString();
                    nud_soLuongNhap.Text = kh.SoLuongNhap.ToString();
                    txt_soLuongTon.Text = kh.SoLuongTon.ToString();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy thông tin kho hàng cho sản phẩm này!", "Thông báo");
                }


            }
        }
        private void btn_tinhTienPN_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tscbb_maPN.Text))
            {
                MessageBox.Show("Hay chon mot phieu nhap", "Thong bao");
                return;
            }
            if (ctnhb.kiemTraTTspCthdBLL(tscbb_maPN.Text) == "ktt")
            {
                MessageBox.Show("Phieu nhap chua co san pham", "Thong Bao");
                return;
            }
            if (string.IsNullOrWhiteSpace(txt_tienNhan.Text))
            {
                MessageBox.Show("Hay nhap so tien nhan", "Thong bao");
                return;
            }

            if (double.TryParse(txt_tienNhan.Text, out double tn))
            {
                if (tn < tongT)
                {   
                    MessageBox.Show("Tien nhan khong nho hon tong phieu nhap ", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    string kq = ctnhb.updCtnh_xntt_BLL(tscbb_maPN.Text);

                    if (kq == "stc")
                    {
                        tb("Thanh toan thanh cong");
                        txt_tienTra.Text = (tn - tongT).ToString();
                        List<ChiTietNhapHangDTO> l = ctnhb.loadCthdBLL(MaPN);

                        dgv_nhapHang.Rows.Clear();

                        foreach (var ctnh in l)
                        {
                            dgv_nhapHang.Rows.Add(ctnh.MaSanPham, ctnh.MaPhieuNhap, ctnh.SoLuong, ctnh.GiaNhap, ctnh.ThanhTien);
                            spb.updateSLtonBLL(-ctnh.SoLuong, ctnh.MaSanPham);

                            if (spb.LoadSltSpBLL(ctnh.MaSanPham) == 0)
                            {
                                spb.capNhatTrangThaiBLL("Hết hàng", ctnh.MaSanPham);
                            }else if (spb.LoadSltSpBLL(ctnh.MaSanPham) >50)
                            {
                                spb.capNhatTrangThaiBLL("Còn hàng", ctnh.MaSanPham);
                            }
                        }
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

        private void tscbb_maSP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tscbb_maNCC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tscbb_maPN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_donGiaNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
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
    }
}
