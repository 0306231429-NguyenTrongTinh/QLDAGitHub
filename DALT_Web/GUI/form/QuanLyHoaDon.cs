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
    public partial class QuanLyHoaDon: Form
    {
        ChiTietHoaDonBLL cthdB = new ChiTietHoaDonBLL();
        HoaDonBLL hdb = new HoaDonBLL();
        KhachHangBLL khB = new KhachHangBLL();
        NhanVienBLL nvB = new NhanVienBLL();
        public QuanLyHoaDon( )
        {
            InitializeComponent();
           
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
        private void QuanLyHoaDon_Load(object sender, EventArgs e)
        {

            dgv_qlHoaDon.CellValueChanged += dgv_qlHoaDon_CellValueChanged;
            dgv_qlHoaDon.CurrentCellDirtyStateChanged += dgv_qlHoaDon_CurrentCellDirtyStateChanged;



            cbb_hinhThuc.Items.Add("Tiền mặt");
            cbb_hinhThuc.Items.Add("Trực tuyến");

            tscbb_loaiThongTin.Items.Add("Mã Hóa Đơn");
            tscbb_loaiThongTin.Items.Add("Mã Nhân Viên");
            tscbb_loaiThongTin.Items.Add("Mã Khách Hàng");
            tscbb_loaiThongTin.Items.Add("Trạng Thái");
            LoadDsHoaDon();
          
            
            LoadMaNv();
            LoadMaKh();

            tsTxt_nhapThongTin.SelectionStart = tsTxt_nhapThongTin.Text.Length;   // lỗi hai con trỏ
            tsTxt_nhapThongTin.SelectionLength = 0;

            dgv_qlHoaDon.AllowUserToAddRows = false; // an dong cuoi

        }

        private void LoadMaNv()
        {

            List<string> l = nvB.LoadMaNvBLL();
            
            foreach (var mnv in l)
            {
                cbb_mnv.Items.Add(mnv);
            }
            cbb_mnv.Sorted = true;
        }

        private void LoadMaKh()
        {

            List<string> l = khB.LoadMaKHBLL();

            foreach (var mkh in l)
            {
                cbb_mkh.Items.Add(mkh);
            }
            cbb_mkh.Sorted = true;
        }
       
        private void LoadDsHoaDon()
        {
            HoaDonBLL hdBll = new HoaDonBLL();
            List<HoaDonDTO> l = hdBll.loadDsHoaDonBLL();

            dgv_qlHoaDon.Rows.Clear();

            foreach (var hd in l)
            {
                Boolean checkTrangThai = hd.TrangThai == "Đã thanh toán";
                dgv_qlHoaDon.Rows.Add(hd.MaHoaDon, hd.NgayLap.ToString("dd/MM/yyyy"), hd.MaNhanVien,hd.MaKhachHang,hd.TongTien,hd.HinhThuc, checkTrangThai);
            }
        }

        private void dgv_qlHoaDon_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgv_qlHoaDon.IsCurrentCellDirty)
            {
                dgv_qlHoaDon.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }
        bool isUpdating = false;
        private void capNhatCheckBox()
        {
            if (isUpdating) return;  // Nếu đang cập nhật do Load → bỏ qua
            DialogResult dt = MessageBox.Show("Xác nhận trạng thái ?", "Thông báo",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dt == DialogResult.OK)
            {
                isUpdating = true; // Bắt đầu cập nhật

                HoaDonDTO hd = new HoaDonDTO();
                hd.MaHoaDon = txt_maHoaDon.Text;
                hd.NgayLap = dt_ngayLap.Value;
                hd.MaNhanVien = cbb_mnv.Text;
                hd.MaKhachHang = cbb_mkh.Text;
                if (float.TryParse(txt_tongTien.Text, out float tt))
                {
                    hd.TongTien = tt;
                }
                hd.HinhThuc = cbb_hinhThuc.Text;


                DataGridViewRow selectedRow = dgv_qlHoaDon.SelectedRows[0];
                int rowIndex = selectedRow.Index;

                bool isChecked = Convert.ToBoolean(dgv_qlHoaDon.Rows[rowIndex].Cells["coll_TrangThai"].Value);

                if (isChecked)
                {
                    hd.TrangThai = "Đã thanh toán";
                }
                else
                {
                    hd.TrangThai = "Chưa thanh toán";
                }


                string kq = hdb.updateHdBLL(hd);
                if (kq == "stc")
                {
                    tb("Sửa thành công");
                    isUpdating = true;
                    reset();
                    isUpdating = false; // Hoàn tất cập nhật
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
                LoadDsHoaDon();
                return;
            }
        }

        private void dgv_qlHoaDon_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem cột đang chỉnh có phải là cột checkbox không
            if (dgv_qlHoaDon.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn)
            {
                DataGridViewRow row = dgv_qlHoaDon.Rows[e.RowIndex];
                row.Selected = true;
                // Gọi hàm cập nhật hóa đơn
                capNhatCheckBox();
            }
        }



        private void dgv_qlHoaDon_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_qlHoaDon.SelectedRows.Count > 0)
            {
                tsb_themHoaDon.Enabled = false;
                DataGridViewRow row = dgv_qlHoaDon.SelectedRows[0];


                txt_maHoaDon.Text = row.Cells["coll_MaHoaDon"].Value.ToString();
                string ngayLap = row.Cells["coll_NgayLap"].Value.ToString();

                DateTime parsedDate = DateTime.ParseExact(ngayLap, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                dt_ngayLap.Value = parsedDate;

                cbb_mnv.Text= row.Cells["coll_MaNhanVien"].Value.ToString();
                cbb_mkh.Text = row.Cells["coll_MaKhachHang"].Value.ToString();
                txt_tongTien.Text = row.Cells["coll_TongTien"].Value.ToString();
                string ht  = row.Cells["coll_HinhThucTT"].Value.ToString();

                if(ht== "Tiền mặt")
                {
                    cbb_hinhThuc.SelectedIndex = 0;
                }
                else
                {
                    cbb_hinhThuc.SelectedIndex = 1;
                }

                cbb_mnv.Enabled = false;
            }
        }

        
        private void clear()
        {
            cbb_hinhThuc.SelectedIndex = -1;
            cbb_mkh.SelectedIndex = -1;
            txt_tongTien.Clear();
            dt_ngayLap.Value = DateTime.Now;
            
            
        }

        private void reset()
        {
            clear();
            dgv_qlHoaDon.Rows.Clear();
            LoadDsHoaDon();
            txt_maHoaDon.Clear();
            cbb_mnv.SelectedIndex = -1;
            tscbb_loaiThongTin.SelectedIndex = -1;
            tscbb_loaiThongTin.Text = "Loại Thông Tin";
            tsTxt_nhapThongTin.Clear();
            cbb_mnv.Enabled = true;
            tsb_themHoaDon.Enabled = true;
        }
        

        private void tsb_themHoaDon_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(cbb_mkh.Text) ||
                string.IsNullOrWhiteSpace(cbb_mnv.Text) ||
                string.IsNullOrWhiteSpace(txt_tongTien.Text) ||
                string.IsNullOrWhiteSpace(cbb_hinhThuc.Text))
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin!", "Thông Báo");
            }
            else
            {
                HoaDonDTO hd = new HoaDonDTO();
                hd.MaHoaDon = hdb.GenerateMaHoaDonBLL();
                hd.NgayLap = dt_ngayLap.Value;
                hd.MaNhanVien = cbb_mnv.Text;
                hd.MaKhachHang = cbb_mkh.Text;
                if (float.TryParse(txt_tongTien.Text, out float tt))
                {
                    hd.TongTien = tt;
                }

                hd.HinhThuc = cbb_hinhThuc.Text;





                hd.TrangThai = "Chưa thanh toán";
                


                string kq = hdb.themhdBLL(hd);
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

        private void tsb_xoaHoaDon_Click(object sender, EventArgs e)
        {

            if (dgv_qlHoaDon.SelectedRows.Count > 0)
            {
                DialogResult dt = MessageBox.Show("Bạn có chắc muốn xóa hóa đơn này?", "Thông báo",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dt == DialogResult.OK)
                {
                    cthdB.xoaCthdBLL(txt_maHoaDon.Text);
                    string kq = hdb.xoaHdBLL(txt_maHoaDon.Text);
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
                MessageBox.Show("Hãy chọn một hóa đơn ", "Thông báo");
            }
        }

        private void tsb_suaHoaDon_Click(object sender, EventArgs e)
        {


            if (dgv_qlHoaDon.SelectedRows.Count > 0)
            {
                DialogResult dt = MessageBox.Show("Bạn có chắc muốn sửa hóa đơn này?", "Thông báo",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dt == DialogResult.OK)
                {
                    HoaDonDTO hd = new HoaDonDTO();
                    hd.MaHoaDon = txt_maHoaDon.Text;
                    hd.NgayLap = dt_ngayLap.Value;
                    hd.MaNhanVien = cbb_mnv.Text;
                    hd.MaKhachHang = cbb_mkh.Text;
                    if (float.TryParse(txt_tongTien.Text, out float tt))
                    {
                        hd.TongTien = tt;
                    }
                    hd.HinhThuc = cbb_hinhThuc.Text;

                    DataGridViewRow selectedRow = dgv_qlHoaDon.SelectedRows[0];
                    int rowIndex = selectedRow.Index;

                    bool isChecked = Convert.ToBoolean(dgv_qlHoaDon.Rows[rowIndex].Cells["coll_TrangThai"].Value);

                    if (isChecked)
                    {
                        hd.TrangThai = "Đã thanh toán";
                    }
                    else
                    {
                        hd.TrangThai = "Chưa thanh toán";
                    }



                    string kq = hdb.updateHdBLL(hd);
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
                MessageBox.Show("Hãy chọn một hóa đơn ", "Thông báo");
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

        private void tsb_timHD_Click(object sender, EventArgs e)
        {
            if (tscbb_loaiThongTin.SelectedIndex == -1)
            {
                MessageBox.Show("Hãy chọn một loại thông tin", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string value = tsTxt_nhapThongTin.Text;
            List<HoaDonDTO> l = new List<HoaDonDTO>();
            if (tscbb_loaiThongTin.SelectedItem.ToString() == "Mã Hóa Đơn")
            {
                l = hdb.LoadSearchHdBLL("mahd", value);
            }
            else if (tscbb_loaiThongTin.SelectedItem.ToString() == "Mã Nhân Viên")
            {
                l = hdb.LoadSearchHdBLL("manv", value);
            }
            else if (tscbb_loaiThongTin.SelectedItem.ToString() == "Mã Khách Hàng")
            {
                l = hdb.LoadSearchHdBLL("makh", value);
            }
            else
            {
                l = hdb.LoadSearchHdBLL("tt", value);
            }

            dgv_qlHoaDon.Rows.Clear();
            foreach (var hd in l)
            {
                Boolean checkTrangThai = hd.TrangThai == "Đã thanh toán";
                dgv_qlHoaDon.Rows.Add(hd.MaHoaDon, hd.NgayLap.ToString("dd/MM/yyyy"), hd.MaNhanVien, hd.MaKhachHang, hd.TongTien, hd.HinhThuc, checkTrangThai);
            }
        }

        private void dgv_qlHoaDon_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Lấy dòng được click
                DataGridViewRow row = dgv_qlHoaDon.Rows[e.RowIndex];

                DialogResult dt = MessageBox.Show("Xem chi tiết hóa đơn?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dt == DialogResult.OK)
                {
                    // Lấy mã hóa đơn từ cột tương ứng, ví dụ cột 0 là mã hóa đơn
                    string maHoaDon = row.Cells[0].Value.ToString();

                    ChiTietHoaDon cthd = new ChiTietHoaDon(maHoaDon);
                    cthd.ShowDialog();
                }
            }
        }

        private void tscbb_loaiThongTin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_tongTien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) )
            {
                e.Handled = true;
            }
        }

        private void tsTxt_nhapThongTin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetterOrDigit(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
    }
}
