using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using System.Globalization;
using static System.Net.Mime.MediaTypeNames;
namespace GUI.form
{
    
    public partial class KhachHang: Form
    {
        KhachHangBLL khb = new KhachHangBLL();
        
        private string userRole;
        private string themkh;
       
        public KhachHang(string role, string tkh)
        {
            InitializeComponent();
            userRole = role;
            themkh=tkh;
        }

        private void KhachHang_Load(object sender, EventArgs e)
        {
            
            if (userRole == "NhanVien")
            {
                
                LoadDsKhachHang();

                ts_1.Visible = false;
                ts_2.Visible = false;
                ts_3.Visible = false;
                coll_ThanhVien.ReadOnly = true;
                tsb_themKhachHang.Visible = false;
                tsb_suaKH.Visible = false;
                tsb_xoaKH.Visible = false;
                tsb_themKHfroNV.Visible = false;
                dgv_khachHang.ReadOnly = true;



                if (themkh == "tkh")
                {
                    FormBorderStyle = FormBorderStyle.Sizable;
                    dgv_khachHang.ReadOnly = true;
                    tsb_themKHfroNV.Visible = true;
                }
            }
            else if(userRole == "Admin" || userRole == "QuanLy")
            {
                LoadDsKhachHang();
                tsb_themKHfroNV.Visible = false;
            }


            cbb_loaiKH.Items.Add("Thành Viên");
            cbb_loaiKH.Items.Add("Mới");
            


            cbb_gioiTinh.Items.Add("Nam");
            cbb_gioiTinh.Items.Add("Nữ");
            cbb_gioiTinh.Items.Add("Khác");

            tscbb_loaiThongTin.Items.Add("Mã Khách Hàng");
            tscbb_loaiThongTin.Items.Add("Họ Tên");
            tscbb_loaiThongTin.Items.Add("Số Điện Thoại");
            tscbb_loaiThongTin.Items.Add("Địa Chỉ");
            tscbb_loaiThongTin.Items.Add("Trạng Thái");

            dgv_khachHang.CellValueChanged += dgv_khachHang_CellValueChanged;
            dgv_khachHang.CurrentCellDirtyStateChanged += dgv_khachHang_CurrentCellDirtyStateChanged;

            dgv_khachHang.AllowUserToAddRows = false;

            
        }

        private void dgv_khachHang_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgv_khachHang.IsCurrentCellDirty)
            {
                dgv_khachHang.CommitEdit(DataGridViewDataErrorContexts.Commit);
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

                KhachHangDTO kh = new KhachHangDTO();
                kh.MaKhachHang = txt_maKhachHang.Text;
                kh.HoTen = txt_hoTenKH.Text;
                kh.SDT = txt_sdt.Text;
                kh.NgaySinh = dt_ngaySinh.Value;
                kh.GioiTinh = cbb_gioiTinh.Text;
                kh.DiaChi = txt_diaChi.Text;
                kh.LoaiKhachHang = cbb_loaiKH.Text;
                kh.DiemTichLuy = (int)nud_diemTL.Value;

                DataGridViewRow selectedRow = dgv_khachHang.SelectedRows[0];
                int rowIndex = selectedRow.Index;

                bool isChecked = Convert.ToBoolean(dgv_khachHang.Rows[rowIndex].Cells["coll_ThanhVien"].Value);

                if (isChecked)
                {
                    kh.LoaiKhachHang = "Thành Viên";
                }
                else
                {
                    kh.LoaiKhachHang = "Mới";
                }


                string kq = khb.updateKhBLL(kh);
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
                    isUpdating = true;
                    reset();
                    isUpdating = false;
                    return;
                }

            }
            else
            {
                reset();
                return;
            }
        }

        private void dgv_khachHang_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem cột đang chỉnh có phải là cột checkbox không
            if (dgv_khachHang.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn)
            {
                DataGridViewRow row = dgv_khachHang.Rows[e.RowIndex];
                row.Selected = true;
                // Gọi hàm cập nhật hóa đơn
                capNhatCheckBox();
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
        private void LoadDsKhachHang()
        {
            List<KhachHangDTO> l = new List<KhachHangDTO>();
            KhachHangBLL khBll = new KhachHangBLL();
            l = khBll.loadKhachHangBLL();
            foreach (var kh in l)
            {
                bool loaiKhCheck = kh.LoaiKhachHang == "Thành Viên";
                dgv_khachHang.Rows.Add(kh.MaKhachHang, kh.HoTen, kh.NgaySinh.ToString("dd/MM/yyyy"), kh.GioiTinh, kh.DiaChi, kh.SDT,kh.DiemTichLuy, loaiKhCheck);
            }
        }

        private void dgv_khachHang_SelectionChanged(object sender, EventArgs e)
        {

            if (dgv_khachHang.SelectedRows.Count > 0)
            {
                nud_diemTL.Enabled = true;
                tsb_themKhachHang.Enabled = false;
                DataGridViewRow row = dgv_khachHang.SelectedRows[0];


                txt_maKhachHang.Text = row.Cells["coll_MaKhachHang"].Value.ToString();
                string ngaysinh = row.Cells["coll_NgaySinh"].Value.ToString();

                DateTime parsedDate = DateTime.ParseExact(ngaysinh, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                dt_ngaySinh.Value = parsedDate;

                txt_hoTenKH.Text = row.Cells["coll_HoTen"].Value.ToString();
                txt_sdt.Text = row.Cells["coll_SDT"].Value.ToString();
                cbb_gioiTinh.Text = row.Cells["coll_GioiTinh"].Value.ToString();
                txt_diaChi.Text = row.Cells["coll_DiaChi"].Value.ToString();
                nud_diemTL.Text = row.Cells["coll_DiemTichLuy"].Value.ToString();
                bool tv = Convert.ToBoolean(row.Cells["coll_ThanhVien"].Value);

                if (tv)
                {
                    cbb_loaiKH.SelectedIndex = 0;
                }
                else
                {
                    cbb_loaiKH.SelectedIndex = 1;
                }
            }
        }

        private void tsb_themKhachHang_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrWhiteSpace(txt_hoTenKH.Text) ||
                string.IsNullOrWhiteSpace(txt_diaChi.Text) ||
                string.IsNullOrWhiteSpace(txt_sdt.Text) ||
                string.IsNullOrWhiteSpace(cbb_gioiTinh.Text) ||
                string.IsNullOrWhiteSpace(cbb_loaiKH.Text) )
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin!", "Thông Báo");
            }
            else
            {
                KhachHangDTO kh = new KhachHangDTO();
                kh.MaKhachHang = khb.GenerateMaKhBLL();
                kh.HoTen = txt_hoTenKH.Text;
                kh.SDT = txt_sdt.Text;
                kh.NgaySinh = dt_ngaySinh.Value;
                kh.GioiTinh = cbb_gioiTinh.Text;
                kh.DiaChi = txt_diaChi.Text;
                kh.LoaiKhachHang = cbb_loaiKH.Text;
                kh.DiemTichLuy = (int)nud_diemTL.Value;
                kh.LoaiKhachHang = cbb_loaiKH.Text;

                if (khb.ktSDTKhBLL(txt_sdt.Text) == "tt")
                {
                    MessageBox.Show("So dien thoai da ton tai", "thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (txt_sdt.Text.Length != 10)
                {
                    MessageBox.Show("Số điện thoại phải đúng 10 chữ số.");
                    return;
                }
                string kq = khb.themKhBLL(kh);
                if (kq == "ttc")
                {
                    tb("Thêm khach hang thành công ");
                    reset();
                    //clear();
                    return;
                }
                else
                {
                    tb("Thêm thất bại");
                    return;
                }


            }
        }

        private void tsb_xoaKH_Click(object sender, EventArgs e)
        {


            if (dgv_khachHang.SelectedRows.Count > 0)
            {
                DialogResult dt = MessageBox.Show("Bạn có chắc muốn xóa khach hang này?", "Thông báo",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dt == DialogResult.OK)
                {

                    string kq = khb.xoaKhBLL(txt_maKhachHang.Text);
                    if (kq == "xtc")
                    {

                        tb("Xóa khac hang thành công");
                        reset();
                        
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
                MessageBox.Show("Hãy chọn một khach hang ", "Thông báo");
            }
        }

        private void tsb_suaKH_Click(object sender, EventArgs e)
        {
            if (dgv_khachHang.SelectedRows.Count > 0)
            {
                DialogResult dt = MessageBox.Show("Bạn có chắc muốn sửa hóa đơn này?", "Thông báo",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dt == DialogResult.OK)
                {
                    KhachHangDTO kh = new KhachHangDTO();
                    kh.MaKhachHang = txt_maKhachHang.Text;
                    kh.HoTen = txt_hoTenKH.Text;
                    kh.SDT = txt_sdt.Text;
                    kh.NgaySinh = dt_ngaySinh.Value;
                    kh.GioiTinh = cbb_gioiTinh.Text;
                    kh.DiaChi = txt_diaChi.Text;
                    kh.LoaiKhachHang = cbb_loaiKH.Text;
                    kh.DiemTichLuy = (int)nud_diemTL.Value;
                    if (txt_sdt.Text.Length != 10)
                    {
                        MessageBox.Show("Số điện thoại phải đúng 10 chữ số.");
                        return;
                    }
                    string kq = khb.updateKhBLL(kh);
                    if (kq == "stc")
                    {
                        tb("Sửa thành công");
                        reset();
                        
                        return;
                    }
                    else
                    {
                        tb("Sửa thất bại");
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
                MessageBox.Show("Hãy chọn một khach hang ", "Thông báo");
            }
        }

        private void tsb_timKH_Click(object sender, EventArgs e)
        {

            if (tscbb_loaiThongTin.SelectedIndex == -1)
            {
                MessageBox.Show("Hãy chọn một loại thông tin", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string value = tsTxt_nhapThongTin.Text;
            List<KhachHangDTO> l = new List<KhachHangDTO>();
            if (tscbb_loaiThongTin.SelectedItem.ToString() == "Mã Khách Hàng")
            {
                l = khb.LoadSearchKhBLL("makh", value);
            }
            else if (tscbb_loaiThongTin.SelectedItem.ToString() == "Họ Tên")
            {
                l = khb.LoadSearchKhBLL("ht", value);
            }
            else if (tscbb_loaiThongTin.SelectedItem.ToString() == "Số Điện Thoại")
            {
                l = khb.LoadSearchKhBLL("sdt", value);
            }
            else if (tscbb_loaiThongTin.SelectedItem.ToString() == "Địa Chỉ")
            {
                l = khb.LoadSearchKhBLL("dc", value);
            }
            else
            {
                l = khb.LoadSearchKhBLL("tv", value);
            }

            dgv_khachHang.Rows.Clear();
            foreach (var kh in l)
            {
                bool loaiKhCheck = kh.LoaiKhachHang == "Thành Viên";
                dgv_khachHang.Rows.Add(kh.MaKhachHang, kh.HoTen, kh.NgaySinh.ToString("dd/MM/yyyy"), kh.GioiTinh, kh.DiaChi, kh.SDT, kh.DiemTichLuy, loaiKhCheck);
            }
        }

        private void clear()
        {
            txt_hoTenKH.Clear();
            cbb_gioiTinh.SelectedIndex = -1;
            cbb_loaiKH.SelectedIndex = -1;
            dt_ngaySinh.Value = DateTime.Now;
            txt_sdt.Clear();
            txt_diaChi.Clear();
            nud_diemTL.Value = 0;
            nud_diemTL.Enabled = false;
            
           
        }

        private void reset()
        {
            clear();
            dgv_khachHang.Rows.Clear();
            LoadDsKhachHang();
            tsTxt_nhapThongTin.Clear();
            tscbb_loaiThongTin.SelectedIndex = -1;
            tscbb_loaiThongTin.Text = "Loại Thông Tin";
            tsb_themKhachHang.Enabled = true;
        }

        private void tsb_xoaPhieuNhap_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void ts_lamMoiDS_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void tsb_themKHfroNV_Click(object sender, EventArgs e)
        {



            if (string.IsNullOrWhiteSpace(txt_hoTenKH.Text) ||
                string.IsNullOrWhiteSpace(txt_diaChi.Text) ||
                string.IsNullOrWhiteSpace(txt_sdt.Text) ||
                string.IsNullOrWhiteSpace(cbb_gioiTinh.Text) ||
                string.IsNullOrWhiteSpace(cbb_loaiKH.Text))
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin!", "Thông Báo");
            }
            else
            {
                KhachHangDTO kh = new KhachHangDTO();
                kh.MaKhachHang = khb.GenerateMaKhBLL();
                kh.HoTen = txt_hoTenKH.Text;
                kh.SDT = txt_sdt.Text;
                kh.NgaySinh = dt_ngaySinh.Value;
                kh.GioiTinh = cbb_gioiTinh.Text;
                kh.DiaChi = txt_diaChi.Text;
                kh.LoaiKhachHang = cbb_loaiKH.Text;
                kh.DiemTichLuy = (int)nud_diemTL.Value;
                kh.LoaiKhachHang = cbb_loaiKH.Text;

                if (khb.ktSDTKhBLL(txt_sdt.Text) == "tt")
                {
                    MessageBox.Show("So dien thoai da ton tai", "thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string kq = khb.themKhBLL(kh);
                if (kq == "ttc")
                {
                    tb("Thêm khach hang thành công ");
                    reset();
                    this.Close();
                    return;
                }
                else
                {
                    tb("Thêm thất bại");
                    this.Close();
                    return;
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

        private void txt_hoTenKH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || char.IsWhiteSpace(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true; 
            }
        }

        private void txt_sdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox txt = sender as TextBox;
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

            if (char.IsDigit(e.KeyChar) && txt.Text.Length >= 10 && txt.SelectedText.Length == 0)
            {
                e.Handled = true;
            }
        }

       
    }
}
