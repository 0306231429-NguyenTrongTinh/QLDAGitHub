using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.form
{
    public partial class NhapHang: Form
    {
        NhapHangBLL nhb = new NhapHangBLL();
        NhanVienBLL nvb = new NhanVienBLL();
        NhaCungCapBLL nccb = new NhaCungCapBLL();
        ChiTietNhapHangBLL ctnhb = new ChiTietNhapHangBLL();
        private string manv = "";
        public NhapHang(string mnv)
        {
            InitializeComponent();
            manv = mnv;
        }

        private void NhapHang_Load(object sender, EventArgs e)
        {
            dgv_qlNhapHang.CellValueChanged += dgv_qlNhapHang_CellValueChanged;
            dgv_qlNhapHang.CurrentCellDirtyStateChanged += dgv_qlNhapHang_CurrentCellDirtyStateChanged;

            coll_TrangThai.Items.Add("Đã nhập");
            coll_TrangThai.Items.Add("Đang chờ");
            

            
            cbb_trangThai.Enabled = false;
            cbb_trangThai.Text = "Đang chờ";
            txt_tongTien.Text = "0";
            txt_tongTien.Enabled = false;

            cbb_trangThai.Items.Add("Đã nhập");
            cbb_trangThai.Items.Add("Đang chờ");
            

            tscbb_loaiThongTin.Items.Add("Mã Phiếu Nhập");
            tscbb_loaiThongTin.Items.Add("Mã Nhân Viên");
            tscbb_loaiThongTin.Items.Add("Mã Nhà Cung Cấp");
            tscbb_loaiThongTin.Items.Add("Trang Thái");
            LoadDSNhapHang();
            txt_maNV.Text = manv;
            txt_maNV.Enabled = false;
            LoadMaNCC();

            dgv_qlNhapHang.AllowUserToAddRows = false;
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
        private void LoadDSNhapHang()
        {
           
            List<NhapHangDTO> l = nhb.loadDsNhapHangBLL();

            dgv_qlNhapHang.Rows.Clear();

            foreach (var nh in l)
            {
                dgv_qlNhapHang.Rows.Add(nh.MaPhieuNhap, nh.NgayNhap.ToString("dd/MM/yyyy"),nh.MaNhanVien,nh.MaNhaCungCap,nh.TongTien,nh.TrangThai);
            }
        }

        

        private void LoadMaNCC()
        {

            List<string> l = nccb.LoadMaNccBLL();

            foreach (var mncc in l)
            {
                cbb_mNCC.Items.Add(mncc);
            }
            cbb_mNCC.Sorted = true;
        }



        private void dgv_qlNhapHang_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_qlNhapHang.Columns[e.ColumnIndex].Name == "coll_TrangThai") // Tên cột ComboBox
            {
                // Lấy dòng hiện tại
                DataGridViewRow row = dgv_qlNhapHang.Rows[e.RowIndex];

                string maPN = row.Cells["coll_MaPhieuNhap"].Value.ToString(); // Mã sản phẩm
                string trangThaiMoi = row.Cells["coll_TrangThai"].Value.ToString();

                // Gọi hàm cập nhật database
                DialogResult dt = MessageBox.Show("Xac nhan trang thai", "Thong bao", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dt == DialogResult.OK)
                {
                    if (nhb.capNhatTrangThaiBLL(trangThaiMoi, maPN) == "stc")
                    {
                        MessageBox.Show("Sua thanh cong", "thong bao");
                        reset();
                    }
                    else
                    {
                        MessageBox.Show("Sua that bai", "thong bao");
                    }
                }
                else
                {
                    reset();
                    return;
                }

            }
        }

        private void dgv_qlNhapHang_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgv_qlNhapHang.IsCurrentCellDirty)
            {
                dgv_qlNhapHang.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void dgv_qlHoaDon_SelectionChanged(object sender, EventArgs e)
        {

            if (dgv_qlNhapHang.SelectedRows.Count > 0)
            {
                tsb_themPN.Enabled = false;
                DataGridViewRow row = dgv_qlNhapHang.SelectedRows[0];


                txt_maPN.Text = row.Cells["coll_MaPhieuNhap"].Value.ToString();
                string ngayNhap = row.Cells["coll_NgayNhap"].Value.ToString();

                DateTime parsedDate = DateTime.ParseExact(ngayNhap, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                dt_ngayNhap.Value = parsedDate;

                txt_maNV.Text = row.Cells["coll_MaNhanVien"].Value.ToString();
                cbb_mNCC.Text = row.Cells["coll_MaNhaCungCap"].Value.ToString();
                txt_tongTien.Text = row.Cells["coll_TongTien"].Value.ToString();
                string ht = row.Cells["coll_TrangThai"].Value.ToString();

                if (ht == "Đã nhập")
                {
                    cbb_trangThai.SelectedIndex = 0;
                }
                else if(ht == "Đang chờ")
                {
                    cbb_trangThai.SelectedIndex = 1;
                }
                else
                {
                    cbb_trangThai.SelectedIndex = 2;
                }
                
            }
        }

        private void clear()
        {
            dt_ngayNhap.Value = DateTime.Now;
            cbb_trangThai.SelectedIndex = -1;
            cbb_mNCC.SelectedIndex = -1;
            txt_tongTien.Clear();
            txt_maNV.Text = manv;
            cbb_trangThai.Text = "Đang chờ";
            txt_tongTien.Text = "0";
        }

        private void reset()
        {
            clear();
            txt_maPN.Clear();
            txt_maNV.Clear();
            dgv_qlNhapHang.Rows.Clear();
            LoadDSNhapHang();
            tsTxt_nhapThongTin.Clear();
            tscbb_loaiThongTin.SelectedIndex = -1;
            tscbb_loaiThongTin.Text = "Loại Thông Tin";
            txt_maNV.Text = manv;
            cbb_trangThai.Text = "Đang chờ";
            txt_tongTien.Text = "0";
            tsb_themPN.Enabled = true;
        }
        private void tsb_themPN_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbb_mNCC.Text) )
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin!", "Thông Báo");
            }
            else
            {
                NhapHangDTO pn = new NhapHangDTO();
                pn.MaPhieuNhap = nhb.GenerateMaNhapHangBLL();
                pn.MaNhanVien = txt_maNV.Text;
                pn.MaNhaCungCap = cbb_mNCC.Text;
                pn.NgayNhap = dt_ngayNhap.Value;
                pn.TrangThai = cbb_trangThai.Text;

                if (nhb.kiemTraiTonTaiPnBLL(pn) == "tt")
                {
                    MessageBox.Show("Phieu nhap da ton tai, vui long nhap lai thong tin", "Thong Bao");
                    return;
                }
                
                
                if (float.TryParse(txt_tongTien.Text, out float tt))
                {
                    pn.TongTien = tt;
                }
                string kq = nhb.themPnDAL(pn);
                if (kq == "ttc")
                {
                    tb("Thêm thành công ");
                    reset();
                    return;
                }
                else
                {
                    tb("Thêm thất bại");
                    reset();
                    return;
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

        private void tsb_xoaPN_Click(object sender, EventArgs e)
        {

            if (dgv_qlNhapHang.SelectedRows.Count > 0)
            {
                DialogResult dt = MessageBox.Show("Bạn có chắc muốn xóa phiếu nhập này?", "Thông báo",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dt == DialogResult.OK)
                {
                    ctnhb.xoaCtnhBLL(txt_maPN.Text);
                    string kq = nhb.xoaPnDAL(txt_maPN.Text);
                    if (kq == "xtc")
                    {
                        
                        tb("Xóa thành công");

                        reset();
                        return;
                    }
                    else
                    {
                        tb("Xóa thất bại");
                        reset();
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
                MessageBox.Show("Hãy chọn một phiếu nhập ", "Thông báo");
            }
        }

        private void tsb_suaPN_Click(object sender, EventArgs e)
        {
            if (dgv_qlNhapHang.SelectedRows.Count > 0)
            {
                DialogResult dt = MessageBox.Show("Bạn có chắc muốn sửa phiếu nhập này?", "Thông báo",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dt == DialogResult.OK)
                {
                    NhapHangDTO pn = new NhapHangDTO();
                    pn.MaPhieuNhap = txt_maPN.Text;
                    pn.MaNhaCungCap = cbb_mNCC.Text;
                    pn.NgayNhap = dt_ngayNhap.Value;
                    pn.TrangThai = cbb_trangThai.Text;



                    if (float.TryParse(txt_tongTien.Text, out float tt))
                    {
                        pn.TongTien = tt;
                    }

                    string kq = nhb.updatePnBLL(pn);
                    if (kq == "stc")
                    {
                        tb("Sửa thành công");
                        reset();

                        return;
                    }
                    else
                    {
                        tb("Sửa thất bại");
                        reset();
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
                MessageBox.Show("Hãy chọn một phieu nhap ", "Thông báo");
            }

        }

        private void tsb_timPN_Click(object sender, EventArgs e)
        {

            if (tscbb_loaiThongTin.SelectedIndex == -1)
            {
                MessageBox.Show("Hãy chọn một loại thông tin", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string value = tsTxt_nhapThongTin.Text;
            List<NhapHangDTO> l = new List<NhapHangDTO>();
            if (tscbb_loaiThongTin.SelectedItem.ToString() == "Mã Phiếu Nhập")
            {
                l = nhb.LoadSearchPnBLL("mapn", value);
            }
            else if (tscbb_loaiThongTin.SelectedItem.ToString() == "Mã Nhân Viên")
            {
                l = nhb.LoadSearchPnBLL("manv", value);
            }
            else if (tscbb_loaiThongTin.SelectedItem.ToString() == "Mã Nhà Cung Cấp")
            {
                l = nhb.LoadSearchPnBLL("mancc", value);
            }
            else
            {
                l = nhb.LoadSearchPnBLL("tt", value);
            }

            dgv_qlNhapHang.Rows.Clear();

            foreach (var nh in l)
            {
                dgv_qlNhapHang.Rows.Add(nh.MaPhieuNhap, nh.NgayNhap.ToString("dd/MM/yyyy"), nh.MaNhanVien, nh.MaNhaCungCap, nh.TongTien, nh.TrangThai);
            }
        }

        private void dgv_qlNhapHang_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                // Lấy dòng được click
                DataGridViewRow row = dgv_qlNhapHang.Rows[e.RowIndex];

                DialogResult dt = MessageBox.Show("Xem chi tiết phiếu nhập?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dt == DialogResult.OK)
                {
                    // Lấy mã hóa đơn từ cột tương ứng, ví dụ cột 0 là mã hóa đơn
                    string maPhieuNhap = row.Cells[0].Value.ToString();

                    ChiTietNH ctnh = new ChiTietNH(maPhieuNhap);
                    ctnh.ShowDialog();
                }
            }
        }

        private void tsTxt_nhapThongTin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetterOrDigit(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void tscbb_loaiThongTin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_maNV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void txt_tongTien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
