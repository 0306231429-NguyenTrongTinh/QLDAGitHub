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
using BLL;
using System.Globalization;

namespace GUI.form
{
    public partial class NhanVien: Form
    {
        SanPhamBLL kmB = new SanPhamBLL();
        NhanVienBLL nvb = new NhanVienBLL();
        private string themnv = "";
        public NhanVien(string flag)
        {
            InitializeComponent();
            themnv = flag;
        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
            if (themnv == "fnv")
            {
                FormBorderStyle = FormBorderStyle.Sizable;
            }
            loadDsNv();
            dgv_nhanVien.Columns["coll_Luong"].DefaultCellStyle.Format = "N0";
            
            cbb_chucVu.Items.Add("Admin");
            cbb_chucVu.Items.Add("Nhân Viên");
            cbb_chucVu.Items.Add("Quản Lý");

            tscbb_loaiThongTin.Items.Add("Mã Nhân Viên");
            tscbb_loaiThongTin.Items.Add("Họ Tên");
            tscbb_loaiThongTin.Items.Add("Số Điện Thoại");
            tscbb_loaiThongTin.Items.Add("Trạng Thái");

            cbb_gioiTinh.Items.Add("Nam");
            cbb_gioiTinh.Items.Add("Nữ");
            cbb_gioiTinh.Items.Add("Khác");

            dgv_nhanVien.CellValueChanged += dgv_nhanVien_CellValueChanged;
            dgv_nhanVien.CurrentCellDirtyStateChanged += dgv_nhanVien_CurrentCellDirtyStateChanged;

            dgv_nhanVien.AllowUserToAddRows = false;
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
        public void loadDsNv()
        {


            List<NhanVienDTO> l = nvb.loadDsNhanVienBLL();

            dgv_nhanVien.Rows.Clear();

            foreach (var nv in l)
            {
                Boolean checkTrangThai = nv.TrangThai == "Đang làm";
                dgv_nhanVien.Rows.Add(nv.MaNhanVien,nv.HoTen, nv.NgaySinh.ToString("dd/MM/yyyy"),nv.GioiTinh,nv.SoDienThoai,nv.ChucVu,nv.Luong, checkTrangThai);
            }
            

        }

        private void dgv_nhanVien_SelectionChanged(object sender, EventArgs e)
        {
            string tongt = "";
            if (dgv_nhanVien.SelectedRows.Count > 0)
            {
                tsb_themNhanVien.Enabled = false;
                DataGridViewRow row = dgv_nhanVien.SelectedRows[0];


                tstxt_maNhanVien.Text = row.Cells["coll_MaNhanVien"].Value.ToString();
                txt_hoTen.Text = row.Cells["coll_HoTen"].Value.ToString();
                string ngaySinh = row.Cells["coll_NgaySinh"].Value.ToString();

                DateTime parsedDate = DateTime.ParseExact(ngaySinh, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                dt_ngaySinh.Value = parsedDate;

                cbb_gioiTinh.Text = row.Cells["coll_GioiTinh"].Value.ToString();
                txt_sdt.Text = row.Cells["coll_SDT"].Value.ToString();
                cbb_chucVu.Text = row.Cells["coll_ChucVu"].Value.ToString();
                tongt = row.Cells["coll_Luong"].Value.ToString();

                if (float.TryParse(tongt, out float luong))
                {
                    txt_luong.Text = luong.ToString("N0"); // định dạng lại
                }
            }
        }

        private void tsb_timHD_Click(object sender, EventArgs e)
        {

            if (tscbb_loaiThongTin.SelectedIndex == -1)
            {
                MessageBox.Show("Hãy chọn một loại thông tin", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string value = tsTxt_nhapThongTin.Text;
            List<NhanVienDTO> l = new List<NhanVienDTO>();
            if (tscbb_loaiThongTin.SelectedItem.ToString() == "Mã Nhân Viên")
            {
                l = nvb.LoadSearchNvBLL("manv", value);
            }
            else if (tscbb_loaiThongTin.SelectedItem.ToString() == "Họ Tên")
            {
                l = nvb.LoadSearchNvBLL("ht", value);
            }
            else if (tscbb_loaiThongTin.SelectedItem.ToString() == "Số Điện Thoại")
            {
                l = nvb.LoadSearchNvBLL("sdt", value);
            }
            else
            {
                l = nvb.LoadSearchNvBLL("tt", value);
            }

            dgv_nhanVien.Rows.Clear();
            foreach (var nv in l)
            {
                Boolean checkTrangThai = nv.TrangThai == "Đang làm";
                dgv_nhanVien.Rows.Add(nv.MaNhanVien, nv.HoTen, nv.NgaySinh.ToString("dd/MM/yyyy"), nv.GioiTinh, nv.SoDienThoai, nv.ChucVu, nv.Luong, checkTrangThai);
            }
        }

        private void tsb_themNhanVien_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrWhiteSpace(txt_hoTen.Text) ||
                string.IsNullOrWhiteSpace(txt_luong.Text) ||
                string.IsNullOrWhiteSpace(txt_sdt.Text) ||
                string.IsNullOrWhiteSpace(cbb_chucVu.Text) ||
                string.IsNullOrWhiteSpace(cbb_gioiTinh.Text) )
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin!", "Thông Báo");
            }
            else
            {
                NhanVienDTO nv = new NhanVienDTO();
                nv.MaNhanVien = nvb.GenerateMaNhanVienBLL();
                nv.HoTen = txt_hoTen.Text;
                nv.NgaySinh = dt_ngaySinh.Value;
                nv.GioiTinh = cbb_gioiTinh.Text;
                nv.SoDienThoai = txt_sdt.Text;
                nv.ChucVu = cbb_chucVu.Text;
                if (float.TryParse(txt_luong.Text,out float l))
                {
                    nv.Luong = l;
                }
                nv.TrangThai = "Đang làm";

                if (nvb.ktSDTNvBLL(txt_sdt.Text) == "tt")
                {
                    MessageBox.Show("So dien thoai da ton tai, vui long nhap so khac", "thong bao");
                    txt_sdt.Clear();
                    return;
                }
                if (txt_sdt.Text.Length != 10)
                {
                    MessageBox.Show("Số điện thoại phải đúng 10 chữ số.");
                    return;
                }
                string kq = nvb.themNvBLL(nv);
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

        public void clear()
        {
            txt_hoTen.Clear();
            cbb_gioiTinh.SelectedIndex = -1;
            cbb_chucVu.SelectedIndex = -1;
            dt_ngaySinh.Value = DateTime.Now;
            txt_sdt.Clear();
            txt_luong.Clear();
            
        }

        public void reset()
        {
            clear();
            tsTxt_nhapThongTin.Clear();
            tscbb_loaiThongTin.SelectedIndex=-1;
            tscbb_loaiThongTin.Text = "Loại Thông Tin";
            dgv_nhanVien.Rows.Clear();
            tstxt_maNhanVien.Clear();
            loadDsNv();
            tsb_themNhanVien.Enabled = true;

        }

        private void tsb_xoaNhanVien_Click(object sender, EventArgs e)
        {


            if (dgv_nhanVien.SelectedRows.Count > 0)
            {
                DialogResult dt = MessageBox.Show("Bạn có chắc muốn xóa nhân viên này?", "Thông báo",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dt == DialogResult.OK)
                {
                    
                    string kq = nvb.xoaNvBLL(tstxt_maNhanVien.Text);
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
                MessageBox.Show("Hãy chọn một nhân viên ", "Thông báo");
            }
        }

        private void tsb_suaNhanVien_Click(object sender, EventArgs e)
        {



            if (dgv_nhanVien.SelectedRows.Count > 0)
            {
                DialogResult dt = MessageBox.Show("Bạn có chắc muốn sửa thông tin nhân viên này?", "Thông báo",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dt == DialogResult.OK)
                {
                    NhanVienDTO nv = new NhanVienDTO();
                    nv.MaNhanVien = tstxt_maNhanVien.Text;
                    nv.HoTen = txt_hoTen.Text;
                    nv.NgaySinh = dt_ngaySinh.Value;
                    nv.GioiTinh = cbb_gioiTinh.Text;
                    nv.SoDienThoai = txt_sdt.Text;
                    nv.ChucVu = cbb_chucVu.Text;
                    if (float.TryParse(txt_luong.Text, out float l))
                    {
                        nv.Luong = l;
                    }

                    DataGridViewRow selectedRow = dgv_nhanVien.SelectedRows[0];
                    int rowIndex = selectedRow.Index;

                    bool isChecked = Convert.ToBoolean(dgv_nhanVien.Rows[rowIndex].Cells["coll_TrangThai"].Value);

                    if (isChecked)
                    {
                        nv.TrangThai = "Đang làm";
                    }
                    else
                    {
                        nv.TrangThai = "Nghỉ";
                    }
                    if (txt_sdt.Text.Length != 10)
                    {
                        MessageBox.Show("Số điện thoại phải đúng 10 chữ số.");
                        return;
                    }
                    string kq = nvb.updateNvBLL(nv);
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
        private void dgv_nhanVien_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgv_nhanVien.IsCurrentCellDirty)
            {
                dgv_nhanVien.CommitEdit(DataGridViewDataErrorContexts.Commit);
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

                NhanVienDTO nv = new NhanVienDTO();
                nv.MaNhanVien = tstxt_maNhanVien.Text;
                nv.HoTen = txt_hoTen.Text;
                nv.NgaySinh = dt_ngaySinh.Value;
                nv.GioiTinh = cbb_gioiTinh.Text;
                nv.SoDienThoai = txt_sdt.Text;
                nv.ChucVu = cbb_chucVu.Text;
                if (float.TryParse(txt_luong.Text, out float l))
                {
                    nv.Luong = l;
                }

                DataGridViewRow selectedRow = dgv_nhanVien.SelectedRows[0];
                int rowIndex = selectedRow.Index;

                bool isChecked = Convert.ToBoolean(dgv_nhanVien.Rows[rowIndex].Cells["coll_TrangThai"].Value);

                if (isChecked)
                {
                    nv.TrangThai = "Đang làm";
                }
                else
                {
                    nv.TrangThai = "Nghỉ";
                }

                string kq = nvb.updateNvBLL(nv);
                if (kq == "stc")
                {
                    tb("Sửa thành công");
                    isUpdating = true;
                    reset();
                    isUpdating = false;
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
                loadDsNv();
                return;
            }
        }

        private void dgv_nhanVien_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem cột đang chỉnh có phải là cột checkbox không
            if (dgv_nhanVien.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn)
            {
                DataGridViewRow row = dgv_nhanVien.Rows[e.RowIndex];
                row.Selected = true;
                // Gọi hàm cập nhật hóa đơn
                capNhatCheckBox();
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

        private void txt_hoTen_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!(char.IsLetter(e.KeyChar) || char.IsWhiteSpace(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void txt_luong_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
