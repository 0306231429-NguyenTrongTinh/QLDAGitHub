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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
namespace GUI.form
{
    public partial class NhaCungCap: Form
    {
        NhaCungCapBLL nccb = new NhaCungCapBLL();
        public NhaCungCap()
        {
            InitializeComponent();
        }

        private void NhaCungCap_Load(object sender, EventArgs e)
        {
            LoadNcc();
            dgv_NCC.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;  // can le giua ten cot

            tscbb_loaiThongTin.Items.Add("Mã Nhà Cung Cấp");
            tscbb_loaiThongTin.Items.Add("Tên Nhà Cung Cấp");
            tscbb_loaiThongTin.Items.Add("Số Điện Thoại");
            tscbb_loaiThongTin.Items.Add("Địa Chỉ");
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
        private void LoadNcc()
        {
            List<NhaCungCapDTO> Lncc = nccb.loadNccBLL();
            dgv_NCC.Rows.Clear();

            foreach (var ncc  in Lncc)
            {
                dgv_NCC.Rows.Add(ncc.MaNhaCungCap,ncc.TenNhaCungCap,ncc.SoDienThoai,ncc.DiaChi);
            }
        }

        private void dgv_NCC_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_NCC.SelectedRows.Count > 0)
            {
                tsb_themNCC.Enabled = false;
                DataGridViewRow row = dgv_NCC.SelectedRows[0];


                tstxt_maNCC.Text = row.Cells["coll_maNCC"].Value.ToString();
                txt_tenNCC.Text = row.Cells["coll_tenNCC"].Value.ToString();
                txt_sdt.Text = row.Cells["coll_sdt"].Value.ToString();
                txt_diaChi.Text = row.Cells["coll_diaChi"].Value.ToString();
            }
        }

        private void tsb_timNCC_Click(object sender, EventArgs e)
        {
            if (tscbb_loaiThongTin.SelectedIndex == -1)
            {
                MessageBox.Show("Hãy chọn một loại thông tin", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string value = tsTxt_nhapThongTin.Text;
            List<NhaCungCapDTO> lncc = new List<NhaCungCapDTO>();
            if (tscbb_loaiThongTin.SelectedItem.ToString() == "Mã Nhà Cung Cấp")
            {
                lncc = nccb.LoadSearchNccBLL("ma", value);
            }
            else if (tscbb_loaiThongTin.SelectedItem.ToString() == "Tên Nhà Cung Cấp")
            {
                lncc = nccb.LoadSearchNccBLL("ten", value);
            }
            else if (tscbb_loaiThongTin.SelectedItem.ToString() == "Số Điện Thoại")
            {
                lncc = nccb.LoadSearchNccBLL("dt", value);
            }
            else
            {
                lncc = nccb.LoadSearchNccBLL("dc", value);
            }

            dgv_NCC.Rows.Clear();
            foreach (var ncc in lncc)
            {
                
                dgv_NCC.Rows.Add(ncc.MaNhaCungCap,ncc.TenNhaCungCap,ncc.SoDienThoai,ncc.DiaChi);
            }
        }
        private void clear()
        {
            txt_tenNCC.Clear();
            txt_sdt.Clear();
            txt_diaChi.Clear();
        }

        private void reset()
        {
            clear();
            dgv_NCC.Rows.Clear();
            LoadNcc();
            tscbb_loaiThongTin.SelectedIndex = -1;
            tscbb_loaiThongTin.Text = "Loại Thông Tin";
            tsTxt_nhapThongTin.Clear();
            tstxt_maNCC.Text = "Mã Nhà Cung Cấp";
            tsb_themNCC.Enabled = true;
        }
        private void tsb_xoaPhieuNhap_Click(object sender, EventArgs e)
        {
            clear();
            
        }

        private void ts_lamMoiDS_Click(object sender, EventArgs e)
        {
            reset();
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

        private void txt_tenNCC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsWhiteSpace(e.KeyChar)))
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

        private void txt_diaChi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void tsb_themNCC_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txt_tenNCC.Text) || string.IsNullOrWhiteSpace(txt_sdt.Text)
                || string.IsNullOrWhiteSpace(txt_diaChi.Text))
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                NhaCungCapDTO ncc = new NhaCungCapDTO();
                ncc.MaNhaCungCap = nccb.GenerateMaNccBLL();
                tstxt_maNCC.Text = ncc.MaNhaCungCap;
                ncc.TenNhaCungCap = txt_tenNCC.Text;
                ncc.SoDienThoai = txt_sdt.Text;
                ncc.DiaChi = txt_diaChi.Text;
                if (txt_sdt.Text.Length != 10)
                {
                    MessageBox.Show("Số điện thoại phải đúng 10 chữ số.");
                    return;
                }
                nccb.themNccBLL(ncc);
                tb("Them nha cung cap thanh cong");
                LoadNcc();
            }
        }

        private void tsb_xoaNCC_Click(object sender, EventArgs e)
        {

            if (dgv_NCC.SelectedRows.Count > 0)
            {
                DialogResult dt = MessageBox.Show("Bạn có chắc muốn xóa nhà cung cấp này?", "Thông báo",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dt == DialogResult.OK)
                {

                    string kq = nccb.xoaNccBLL(tstxt_maNCC.Text);
                    if (kq == "xtc")
                    {

                        tb("Xóa thành công");
                        LoadNcc();
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
                MessageBox.Show("Hãy chọn một hóa đơn ", "Thông báo");
            }
        }

        private void tsb_suaCCC_Click(object sender, EventArgs e)
        {
            if (dgv_NCC.SelectedRows.Count > 0)
            {
                DialogResult dt = MessageBox.Show("Bạn có chắc muốn sửa nhà cung cấp này?", "Thông báo",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dt == DialogResult.OK)
                {
                    NhaCungCapDTO ncc = new NhaCungCapDTO();
                    ncc.MaNhaCungCap = tstxt_maNCC.Text;
                    ncc.TenNhaCungCap = txt_tenNCC.Text;
                    ncc.SoDienThoai = txt_sdt.Text;
                    ncc.DiaChi = txt_diaChi.Text;


                    if (txt_sdt.Text.Length != 10)
                    {
                        MessageBox.Show("Số điện thoại phải đúng 10 chữ số.");
                        return;
                    }
                    string kq = nccb.updateMaNccBLL(ncc);
                    if (kq == "stc")
                    {
                        tb("Sửa thành công");
                        LoadNcc();
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
                MessageBox.Show("Hãy chọn một hóa đơn ", "Thông báo");
            }
        }
    }
}
