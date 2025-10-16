using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.form
{
    public partial class KhoHang: Form
    {
        KhoHangBLL khb = new KhoHangBLL();
        public KhoHang()
        {
            InitializeComponent();
        }

        private void KhoHang_Load(object sender, EventArgs e)
        {
            LoadDsKhoHang();
        }
        private void LoadDsKhoHang()
        {
            KhoHangDTO hdBll = new KhoHangDTO();
            List<KhoHangDTO> l = khb.loadDsKhoHangBLL();

            dgv_KhoHang.Rows.Clear();

            foreach (var khoh in l)
            {
                dgv_KhoHang.Rows.Add(khoh.MaSanPham, khoh.SoLuongTon, khoh.SoLuongNhap, khoh.GiaNhap, khoh.GiaBan, khoh.NgayCapNhat.ToString("dd/MM/yyyy"));
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

        private void LoadImageTheoMaSP(string masp)
        {
            // Tạo đường dẫn ảnh dựa trên mã sản phẩm
            string imagePath = Path.Combine(Application.StartupPath, "Images", masp + ".jpg");

            // Kiểm tra file có tồn tại không
            if (File.Exists(imagePath))
            {
                pb_anhSP.BackgroundImage = null;
                pb_anhSP.Image = Image.FromFile(imagePath);
                pb_anhSP.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                pb_anhSP.Image = null; // hoặc bạn có thể hiển thị ảnh mặc định
                MessageBox.Show("Không tìm thấy ảnh cho mã sản phẩm: " + masp);
            }
        }

        private void dgv_KhoHang_SelectionChanged(object sender, EventArgs e)
        {

            if (dgv_KhoHang.SelectedRows.Count > 0)
            {

                DataGridViewRow row = dgv_KhoHang.SelectedRows[0];
                tscbb_maSP.Text = row.Cells["coll_MaSanPham"].Value.ToString();
                txt_soLuongTon.Text = row.Cells["coll_SoLuongTon"].Value.ToString();
                txt_soLuongNhap.Text = row.Cells["coll_SoLuongNhap"].Value.ToString();
                txt_giaNhap.Text = row.Cells["coll_GiaNhap"].Value.ToString();
                txt_giaBan.Text = row.Cells["coll_GiaBan"].Value.ToString();
                

                string ngayCn = row.Cells["coll_NgayCapNhat"].Value.ToString();

                DateTime parsedDate = DateTime.ParseExact(ngayCn, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                dt_ngayNhap.Value = parsedDate;

                if (dgv_KhoHang.CurrentRow != null)
                {
                    string masp = dgv_KhoHang.CurrentRow.Cells["coll_MaSanPham"].Value.ToString();
                    LoadImageTheoMaSP(masp);
                }
            }
        }
        private void clear()
        {
            tscbb_maSP.SelectedIndex = -1;
            tscbb_maSP.Text = "Mã Sản Phẩm";
            tsTxt_maSP.Clear();
            txt_soLuongNhap.Clear();
            txt_soLuongTon.Clear();
            txt_giaBan.Clear();
            txt_giaNhap.Clear();
            dt_ngayNhap.Value = DateTime.Now;
            txt_ghiChu.Clear();
            
        }

        private void reset()
        {
            clear();
            dgv_KhoHang.Rows.Clear();
            LoadDsKhoHang();
        }

        private void tsb_suaSanPham_Click(object sender, EventArgs e)
        {
            if (dgv_KhoHang.SelectedRows.Count > 0)
            {
                DialogResult dt = MessageBox.Show("Bạn có chắc muốn sửa sản phẩm này?", "Thông báo",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dt == DialogResult.OK)
                {
                    KhoHangDTO kh = new KhoHangDTO();
                    kh.MaSanPham = tscbb_maSP.Text;
                    if(int.TryParse(txt_soLuongTon.Text,out int slt) && int.TryParse(txt_soLuongNhap.Text,out int sln))
                    {
                        kh.SoLuongTon = slt;
                        kh.SoLuongNhap = sln;
                    }

                    if(float.TryParse(txt_giaNhap.Text, out float gn) && float.TryParse(txt_giaBan.Text, out float gb))
                    {
                        kh.GiaNhap = gn;
                        kh.GiaBan = gb;
                    }
                    kh.NgayCapNhat = dt_ngayNhap.Value;
                    string kq = khb.updateKhoHangBLL(kh);
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

        private void tsb_xoaSanPham_Click(object sender, EventArgs e)
        {
            if (dgv_KhoHang.SelectedRows.Count > 0)
            {
                DialogResult dt = MessageBox.Show("Bạn có chắc muốn xóa san pham này?", "Thông báo",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dt == DialogResult.OK)
                {
                    string kq = khb.xoaKhBLL(tscbb_maSP.Text);
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
                MessageBox.Show("Hãy chọn một san pham ", "Thông báo");
            }
        }

        private void tsTxt_maSP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetterOrDigit(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void tscbb_maSP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_soLuongTon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_giaNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_soLuongNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_giaBan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
