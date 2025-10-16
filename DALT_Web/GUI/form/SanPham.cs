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
using System.IO;
using System.Configuration;

namespace GUI.form
{
    public partial class SanPham: Form
    {
        SanPhamBLL spb =new SanPhamBLL();
        NhaCungCapBLL nccB = new NhaCungCapBLL();
        MaLoaiBLL mlB = new MaLoaiBLL();
        HoaDonBLL hdb = new HoaDonBLL();
        ChiTietNhapHangBLL ctnhb = new ChiTietNhapHangBLL();
        private string userRole;
        public SanPham(string rule)
        {
            InitializeComponent();
            userRole = rule;
        }

        private void SanPham_Load(object sender, EventArgs e)
        {
            if (userRole == "NhanVien")
            {
                tsb_xoaSanPham.Visible = false;
                tsb_themSanPham.Visible = false;
                tsb_suaSanPham.Visible = false;
                tsmenu_luuSP.Visible = false;
                ts_1.Visible = false;
                ts_2.Visible = false;
                ts_3.Visible = false;
                ts_4.Visible = false;
                dgv_SanPham.ReadOnly = true;

                
            }


            LoadDsSp();
            LNcc();
            LMaLoai();
            pb_anhSP.BackgroundImage = GUI.Properties.Resources.err;

            tscbb_loaiThongTin.Items.Add("Mã Sản Phẩm");
            tscbb_loaiThongTin.Items.Add("Tên Sản Phẩm");
            tscbb_loaiThongTin.Items.Add("Mã Nhà Cung Cấp");
            tscbb_loaiThongTin.Items.Add("Trạng Thái");
            cbb_donVi.Items.Add("Hộp");
            cbb_donVi.Items.Add("Chai");
            cbb_donVi.Items.Add("Túi");
            cbb_donVi.Items.Add("Bánh");
            cbb_donVi.Items.Add("Hũ");
            cbb_donVi.Items.Add("Gói");
            cbb_donVi.Items.Add("Kg");

            coll_trangThai.Items.Add("Còn hàng");
            coll_trangThai.Items.Add("Hết hàng");


            dgv_SanPham.CellValueChanged += dgv_sanPham_CellValueChanged;
            dgv_SanPham.CurrentCellDirtyStateChanged += dgv_sanPham_CurrentCellDirtyStateChanged;

            dgv_SanPham.AllowUserToAddRows = false;

            txt_soLuongTon.Enabled = false;
        }

        private void dgv_sanPham_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_SanPham.Columns[e.ColumnIndex].Name == "coll_trangThai") // Tên cột ComboBox
            {
                // Lấy dòng hiện tại
                DataGridViewRow row = dgv_SanPham.Rows[e.RowIndex];

                string maSP = row.Cells["coll_MaSanPham"].Value.ToString(); // Mã sản phẩm
                string trangThaiMoi = row.Cells["coll_trangThai"].Value.ToString();
                int slt = (int)row.Cells["coll_SoLuongTon"].Value;

                if(trangThaiMoi== "Còn hàng" && slt < 50)
                {
                    MessageBox.Show("So luong ton khong du de cap nhat trang thai nay", "Thong bao");
                    LoadDsSp();
                    return;
                }
                if (slt == 0 && trangThaiMoi != "Hết hàng")
                {
                    MessageBox.Show("San pham nay da het hang", "Thong bao");
                    LoadDsSp();
                    return;
                }

                // Gọi hàm cập nhật database
                DialogResult dt = MessageBox.Show("Xac nhan trang thai", "Thong bao",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
                if(dt== DialogResult.OK)
                {
                    if (spb.capNhatTrangThaiBLL(trangThaiMoi, maSP) == "stc")
                    {
                        MessageBox.Show("Sua thanh cong", "thong bao");
                        LoadDsSp();
                    }
                    else
                    {
                        MessageBox.Show("Sua that bai", "thong bao");
                    }
                }
                else
                {
                    LoadDsSp();
                    return;
                }
                
            }
        }

        private void dgv_sanPham_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgv_SanPham.IsCurrentCellDirty)
            {
                dgv_SanPham.CommitEdit(DataGridViewDataErrorContexts.Commit);
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

        private void LoadDsSp()
        {
            List<SanPhamDTO> l = spb.loadSanPhamBLL();
            dgv_SanPham.Rows.Clear();
            foreach (var sp in l)
            {
                
                int rowIndex = dgv_SanPham.Rows.Add(sp.MaSanPham,sp.TenSanPham,sp.MaLoai,sp.DonGia,sp.SoLuongTon,sp.DonViTinh,sp.MaNCC, sp.NgayHetHan?.ToString("dd/MM/yyyy") ?? "", sp.TrangThai);

                if(sp.SoLuongTon == 0)
                {
                    dgv_SanPham.Rows[rowIndex].Cells[4].Style.ForeColor = Color.Red;
                    dgv_SanPham.Rows[rowIndex].Cells[4].Style.Font = new Font(dgv_SanPham.Font, FontStyle.Bold);
                }



                if (sp.TrangThai== "Hết hàng")
                {
                    dgv_SanPham.Rows[rowIndex].Cells[0].Style.ForeColor = Color.Red;
                    dgv_SanPham.Rows[rowIndex].Cells[0].Style.Font = new Font(dgv_SanPham.Font, FontStyle.Bold);
                }
                else
                {
                    dgv_SanPham.Rows[rowIndex].Cells[0].Style.ForeColor = Color.Green;
                    dgv_SanPham.Rows[rowIndex].Cells[0].Style.Font = new Font(dgv_SanPham.Font, FontStyle.Bold);
                }
            }

        }

        private void LNcc()
        {
            List<string> LoadMaNccList = nccB.LoadMaNccBLL();
            tscbb_maNCC.Items.Clear();
            foreach (string mancc in LoadMaNccList)
            {
                tscbb_maNCC.Items.Add(mancc);
            }
            tscbb_maNCC.Sorted = true;
        }

        private void LMaLoai()
        {
            List<string> LoadMaLoaiList = mlB.LoadMaLoaiBLL();
            tscbb_maLoai.Items.Clear();
            foreach (string maLoai in LoadMaLoaiList)
            {
                tscbb_maLoai.Items.Add(maLoai);
            }
            tscbb_maLoai.Sorted = true;
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


       

        private void clear()
        {
            
            txt_tenSanPham.Clear();
           

            cbb_donVi.SelectedIndex = -1;
           
            dt_ngayHetHan.Value = DateTime.Now;
            pb_anhSP.BackgroundImage = GUI.Properties.Resources.err;
        }
        private void lamMoi()
        {
            LoadDsSp();
            clear();
            txt_maSP.Clear();
            txt_donGia.Clear();
            txt_soLuongTon.Clear();
            tscbb_maNCC.SelectedIndex = -1;
            tscbb_maNCC.Text = "Mã Nhà Cung Cấp";

            tscbb_maLoai.SelectedIndex = -1;
            tscbb_maLoai.Text = "Mã Loại";

            tscbb_maLoai.Enabled = true;
            tscbb_maNCC.Enabled = true;


            pb_anhSP.Image = null;

            txt_donGia.Enabled = true;
            tsb_themSanPham.Enabled = true;

        }
        private void dgv_SanPham_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_SanPham.SelectedRows.Count > 0)
            {

                DataGridViewRow row = dgv_SanPham.SelectedRows[0];


                txt_maSP.Text = row.Cells["coll_MaSanPham"].Value.ToString();
                txt_tenSanPham.Text = row.Cells["coll_TenSanPham"].Value.ToString();
                tscbb_maLoai.Text = row.Cells["coll_MaLoai"].Value.ToString();
                txt_donGia.Text = row.Cells["coll_DonGia"].Value.ToString();
                txt_soLuongTon.Text = row.Cells["coll_SoLuongTon"].Value.ToString();
                cbb_donVi.Text = row.Cells["coll_DonViTinh"].Value.ToString();
                tscbb_maNCC.Text = row.Cells["coll_MaNCC"].Value.ToString();


                string ngayHetHan = row.Cells["coll_NgayHetHan"].Value?.ToString();

                if (!string.IsNullOrEmpty(ngayHetHan))
                {
                    DateTime parsedDate = DateTime.ParseExact(ngayHetHan, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    dt_ngayHetHan.Value = parsedDate;
                }
                else
                {
                    // Gán giá trị mặc định nếu ngày bị null (ví dụ là ngày hiện tại)
                    dt_ngayHetHan.Value = DateTime.Now;
                }

                if (dgv_SanPham.CurrentRow != null)
                {
                    string masp = dgv_SanPham.CurrentRow.Cells["coll_MaSanPham"].Value.ToString();
                    LoadImageTheoMaSP(masp);
                }

                tscbb_maLoai.Enabled = false;
                tscbb_maNCC.Enabled = false;
                txt_donGia.Enabled = false;
                tsb_themSanPham.Enabled = false;
            }
            
        }

        private void tsb_timSP_Click(object sender, EventArgs e)
        {
            if (tscbb_loaiThongTin.SelectedIndex == -1)
            {
                MessageBox.Show("Hãy chọn một loại thông tin", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(tsTxt_nhapThongTin.Text))
            {
                MessageBox.Show("Thông tin không bỏ trống", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string value = tsTxt_nhapThongTin.Text;
            List<SanPhamDTO> l = new List<SanPhamDTO>();
            if (tscbb_loaiThongTin.SelectedItem.ToString() == "Mã Sản Phẩm")
            {
                l = spb.LoadSearchSpBLL("masp", value);
                
            }
            else if (tscbb_loaiThongTin.SelectedItem.ToString() == "Tên Sản Phẩm")
            {
                l = spb.LoadSearchSpBLL("tensp", value);
            }
            else if (tscbb_loaiThongTin.SelectedItem.ToString() == "Mã Nhà Cung Cấp")
            {
                l = spb.LoadSearchSpBLL("mancc", value);
            }
            else
            {
                l = spb.LoadSearchSpBLL("tt", value);
            }

            dgv_SanPham.Rows.Clear();
            foreach (var sp in l)
            {
                Boolean checkTrangThai = sp.TrangThai == "Còn hàng";
                dgv_SanPham.Rows.Add(sp.MaSanPham, sp.TenSanPham, sp.MaLoai, sp.DonGia, sp.SoLuongTon, sp.DonViTinh, sp.MaNCC, sp.NgayHetHan?.ToString("dd/MM/yyyy") ?? "", checkTrangThai);
            }
        }

        private void tsb_xoaPhieuNhap_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void ts_lamMoiDS_Click(object sender, EventArgs e)
        {
            lamMoi();
        }

        private void tsb_themSanPham_Click(object sender, EventArgs e)
        {
            if(tscbb_maLoai.SelectedIndex==-1 || tscbb_maNCC.SelectedIndex == -1)
            {
                MessageBox.Show("Hãy chon ma loi va ma nha cung cap!", "Thông Báo");
                return;
            }
            else
            {
                txt_maSP.Text= spb.GenerateMaSpDonDAL();
                tscbb_maNCC.Enabled = false;
                tscbb_maLoai.Enabled = false;

                if (string.IsNullOrWhiteSpace(txt_tenSanPham.Text) ||
                string.IsNullOrWhiteSpace(txt_donGia.Text) ||
                cbb_donVi.SelectedIndex == -1)
                {
                    MessageBox.Show("Hãy nhập đầy đủ thông tin!", "Thông Báo");
                    return;
                }
                else
                {
                    SanPhamDTO sp = new SanPhamDTO();
                    sp.MaSanPham = txt_maSP.Text;
                    sp.TenSanPham = txt_tenSanPham.Text;
                    sp.MaLoai = tscbb_maLoai.Text;
                    if (float.TryParse(txt_donGia.Text, out float dg))
                    {
                        sp.DonGia = dg;
                    }
                    
                    sp.SoLuongTon = 0;

                    
                    sp.DonViTinh = cbb_donVi.Text;
                    sp.MaNCC = tscbb_maNCC.Text;
                    sp.NgayHetHan = dt_ngayHetHan.Value;

                    sp.TrangThai = "Hết hàng";

                    if (string.IsNullOrEmpty(selectedImagePath))
                    {
                        MessageBox.Show("Vui lòng chọn ảnh trước khi lưu.");
                        return;
                    }
                    if (spb.kiemTraiTonTaiPnBLL(sp) == "tt")
                    {
                        MessageBox.Show("San pham da ton tai", "Thong Bao");
                        return;
                    }

                    luuAnh();
                    string kq = spb.themSpBLL(sp);
                    

                    if (kq == "ttc")
                    {
                        tb("Thêm san pham thành công ");
                        LoadDsSp();
                        clear();
                        tscbb_maNCC.Enabled = true;
                        tscbb_maLoai.Enabled = true;
                        lamMoi();
                        return;
                    }
                    else
                    {
                        tb("Thêm thất bại");
                        return;
                    }
                }
            }

            
        }

        private string selectedImagePath = ""; // Biến lưu trữ đường dẫn tạm thời

        private void btn_taiAnh_Click(object sender, EventArgs e)
        {
            

            loadAnh.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            loadAnh.Title = "Chọn ảnh để hiển thị";

            if (loadAnh.ShowDialog() == DialogResult.OK)
            {
                selectedImagePath = loadAnh.FileName;

                // Load ảnh vào bộ nhớ để tránh khóa file
                using (FileStream fs = new FileStream(selectedImagePath, FileMode.Open, FileAccess.Read))
                {
                    pb_anhSP.Image = Image.FromStream(fs); // không giữ file lock
                    pb_anhSP.BackgroundImage = null;
                }

                pb_anhSP.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void tsmenu_luuSP_Click(object sender, EventArgs e)
        {
            luuAnh();
        }

        private void luuAnh()
        {
            if (string.IsNullOrEmpty(selectedImagePath))
            {
                MessageBox.Show("Vui lòng chọn ảnh trước khi lưu.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txt_maSP.Text))
            {
                MessageBox.Show("Hay tao san pham de luu anh");
                return;
            }

            string fileName = txt_maSP.Text + ".jpg";
            string destFolder = Path.Combine(Application.StartupPath, "Images");
            Directory.CreateDirectory(destFolder); // Tạo thư mục nếu chưa có

            string destPath = Path.Combine(destFolder, fileName);

            // Nếu PictureBox đã có ảnh và file ảnh đích đã tồn tại → xóa để thay ảnh
            if (pb_anhSP.Image != null && File.Exists(destPath))
            {
                Image oldImage = pb_anhSP.Image;
                pb_anhSP.Image = null;
                oldImage.Dispose();

                try
                {
                    GC.Collect();       // Thu dọn rác (ép giải phóng tài nguyên)
                    GC.WaitForPendingFinalizers(); // Chờ giải phóng xong
                    File.Delete(destPath); // Xóa ảnh cũ
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa ảnh cũ: " + ex.Message);
                    return;
                }
            }

            // Lưu ảnh mới
            try
            {
                File.Copy(selectedImagePath, destPath, true); // Ghi đè nếu trùng tên

                using (FileStream fs = new FileStream(destPath, FileMode.Open, FileAccess.Read))
                {
                    Image tempImage = Image.FromStream(fs);
                    pb_anhSP.Image = new Bitmap(tempImage); // Clone để tránh giữ file
                    tempImage.Dispose();
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu ảnh: " + ex.Message);
            }
        }
        private void xoaAnh()
        {
            string fileName = txt_maSP.Text + ".jpg";
            string imagePath = Path.Combine(Application.StartupPath, "Images", fileName);

            try
            {
                if (File.Exists(imagePath))
                {
                    // Giải phóng ảnh đang hiển thị trong PictureBox
                    if (pb_anhSP.Image != null)
                    {
                        pb_anhSP.Image.Dispose();
                        pb_anhSP.Image = null;

                        GC.Collect();
                        GC.WaitForPendingFinalizers();
                    }

                    File.Delete(imagePath);
                    
                }
                else
                {
                    MessageBox.Show("Không tìm thấy ảnh để xóa.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa ảnh: " + ex.Message);
            }
        }



        private void tsb_xoaSanPham_Click(object sender, EventArgs e)
        {


            if (dgv_SanPham.SelectedRows.Count > 0)
            {
                DialogResult dt = MessageBox.Show("Bạn có chắc muốn xóa san pham này?", "Thông báo",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dt == DialogResult.OK)
                {
                    xoaAnh();

                    string kq1 = ctnhb.xoaCtnh_maspBLL(txt_maSP.Text);
                    string kq = spb.xoaSpBLL(txt_maSP.Text);

                    if (kq == "xtc")
                    {
                        pb_anhSP.BackgroundImage = GUI.Properties.Resources.err;
                        tb("Xóa san pham thành công");
                        lamMoi();
                        return;
                    }
                    else
                    {
                        tb("Xóa san pham thất bại");
                        lamMoi();
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

        private void tsb_suaSanPham_Click(object sender, EventArgs e)
        {
            if (dgv_SanPham.SelectedRows.Count > 0)
            {
                
                DialogResult dt = MessageBox.Show("Bạn có chắc muốn sửa hóa đơn này?", "Thông báo",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dt == DialogResult.OK)
                {
                    SanPhamDTO sp = new SanPhamDTO();
                    sp.MaSanPham = txt_maSP.Text;
                    sp.TenSanPham = txt_tenSanPham.Text;
                    sp.MaLoai = tscbb_maLoai.Text;
                    if (float.TryParse(txt_donGia.Text, out float dg))
                    {
                        sp.DonGia = dg;
                    }
                    if (int.TryParse(txt_soLuongTon.Text, out int slt))
                    {
                        sp.SoLuongTon = slt;

                    }
                    sp.DonViTinh = cbb_donVi.Text;
                    sp.MaNCC = tscbb_maNCC.Text;
                    sp.NgayHetHan = dt_ngayHetHan.Value;

                    



                    string kq = spb.updateSpBLL(sp);
                    if (kq == "stc")
                    {
                        tb("Sửa thành công");
                        ts_lamMoiDS_Click(sender, e);
                        LoadDsSp();

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
                MessageBox.Show("Hãy chọn một san pham ", "Thông báo");
            }
        }

        private void tscbb_loaiThongTin_KeyPress(object sender, KeyPressEventArgs e)
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

        private void tscbb_maLoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_tenSanPham_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetterOrDigit(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true; 
            }
        }

        private void txt_donGia_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_soLuongTon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tscbb_maNCC_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tscbb_maNCC.SelectedIndex == -1)
            {
                lb_ncc.Text = "";
                return;
            }
            else
            {
                List<string> Lncc = nccB.LoadThongTinNccDAL(tscbb_maNCC.Text);
                lb_ncc.Text = Lncc[0];
            }
            
        }

        private void tscbb_maLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tscbb_maLoai.SelectedIndex == -1)
            {
                lb_maLoai.Text = "";
                return;
            }
            else
            {
                lb_maLoai.Text = mlB.LoadTenMaLoaiBLL(tscbb_maLoai.Text);
            }
           
        }
    }
}
