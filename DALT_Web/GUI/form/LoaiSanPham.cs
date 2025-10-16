using DTO;
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
namespace GUI.form
{
    public partial class LoaiSanPham: Form
    {
        LoaiSanPhamBLL lspb = new LoaiSanPhamBLL();
        private string userRole;
        public LoaiSanPham(string rule)
        {
            InitializeComponent();
            userRole = rule;
        }



        private void LoaiSanPham_Load(object sender, EventArgs e)
        {

            if (userRole == "NhanVien")
            {
                dgv_LSP.ReadOnly = true;
                ts_1.Visible = false;
                ts_2.Visible = false;
                ts_3.Visible = false;
                tsb_themLSP.Visible = false;
                tsb_xoaLSP.Visible = false;
                tsb_suaLSP.Visible = false;
            }

            LoadLSP();
            tscbb_loaiThongTin.Items.Add("Mã Loại Sản Phẩm");
            tscbb_loaiThongTin.Items.Add("Tên Loại Sản Phẩm");

            tstxt_tenLoai.Text = "Tên Loại";
            tstxt_tenLoai.ForeColor = Color.Gray;

            dgv_LSP.AllowUserToAddRows = false;
        }
        private void LoadLSP()
        {
            List<LoaiSanPhamDTO> Llsp = lspb.LoadLspBLL();
            dgv_LSP.Rows.Clear();

            foreach (var lsp in Llsp)
            {
                dgv_LSP.Rows.Add(lsp.MaLoai,lsp.TenLoai);
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

        private void tsb_themLSP_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(tstxt_tenLoai.Text)|| tstxt_tenLoai.Text=="Tên Loại")
            {
                MessageBox.Show("Hãy nhập tên loại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                LoaiSanPhamDTO lsp = new LoaiSanPhamDTO();
                lsp.MaLoai = lspb.GenerateMaLspBLL();
                tstxt_maLSP.Text = lsp.MaLoai;
                lsp.TenLoai = tstxt_tenLoai.Text;
                lspb.themLspBLL(lsp);
                reset();
                tb("Them thanh cong");
            }
        }

        private void tsb_xoaLSP_Click(object sender, EventArgs e)
        {

            if (dgv_LSP.SelectedRows.Count > 0)
            {
                DialogResult dt = MessageBox.Show("Bạn có chắc muốn xóa loại sản phẩm này?", "Thông báo",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dt == DialogResult.OK)
                {

                    string kq = lspb.xoaLspBLL(tstxt_maLSP.Text);
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
                MessageBox.Show("Hãy chọn một loại sản phẩm ", "Thông báo");
            }
        }

        private void tsb_suaLSP_Click(object sender, EventArgs e)
        {
            if (dgv_LSP.SelectedRows.Count > 0)
            {
                DialogResult dt = MessageBox.Show("Bạn có chắc muốn sửa loại sản phẩm này?", "Thông báo",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dt == DialogResult.OK)
                {
                    LoaiSanPhamDTO lsp = new LoaiSanPhamDTO();
                    lsp.MaLoai = tstxt_maLSP.Text;
                    lsp.TenLoai = tstxt_tenLoai.Text;



                    string kq = lspb.updateMaLspBLL(lsp);
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

        private void tsb_timLSP_Click(object sender, EventArgs e)
        {
            if (tscbb_loaiThongTin.SelectedIndex == -1)
            {
                MessageBox.Show("Hãy chọn một loại thông tin", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string value = tsTxt_nhapThongTin.Text;
            List<LoaiSanPhamDTO> Llsp = new List<LoaiSanPhamDTO>();
            if (tscbb_loaiThongTin.SelectedItem.ToString() == "Mã Loại Sản Phẩm")
            {
                Llsp = lspb.LoadSearchLspBLL("ma", value);
            }
            else if (tscbb_loaiThongTin.SelectedItem.ToString() == "Tên Loại Sản Phẩm")
            {
                Llsp = lspb.LoadSearchLspBLL("ten", value);
            }

            dgv_LSP.Rows.Clear();
            foreach (var lsp in Llsp)
            {

                dgv_LSP.Rows.Add(lsp.MaLoai, lsp.TenLoai);
            }
        }

        private void dgv_LSP_SelectionChanged(object sender, EventArgs e)
        {
            tstxt_tenLoai.ForeColor = Color.Black;
            if (dgv_LSP.SelectedRows.Count > 0)
            {
                tsb_themLSP.Enabled = false;
                DataGridViewRow row = dgv_LSP.SelectedRows[0];


                tstxt_maLSP.Text = row.Cells["coll_maLoai"].Value.ToString();
                tstxt_tenLoai.Text = row.Cells["coll_tenLoai"].Value.ToString();
            }
        }
        private void clear()
        {
            tstxt_tenLoai.Clear();
        }
        private void reset()
        {
            clear();
            dgv_LSP.Rows.Clear();
            LoadLSP();
            tstxt_tenLoai.Clear();
            tstxt_tenLoai.Text = "Tên Loại";
            tscbb_loaiThongTin.SelectedIndex = -1;
            tscbb_loaiThongTin.Text = "Loại Thông Tin";
            tsTxt_nhapThongTin.Clear();
            tstxt_maLSP.Clear();
            tstxt_maLSP.Text = "Mã Loại Sản Phẩm";
            tstxt_tenLoai.ForeColor = Color.Gray;
            tsb_themLSP.Enabled = true;
        }
        private void tsb_xoaPhieuNhap_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void ts_lamMoiDS_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void tstxt_tenLoai_Enter(object sender, EventArgs e)
        {
           if(tstxt_tenLoai.Text== "Tên Loại")
            {
                tstxt_tenLoai.Clear();
                tstxt_tenLoai.ForeColor = Color.Black;
            }
        }

        private void tstxt_tenLoai_Leave(object sender, EventArgs e)
        {
            if (tstxt_tenLoai.Text == "")
            {
                tstxt_tenLoai.Text = "Tên Loại";
                tstxt_tenLoai.ForeColor = Color.Gray;
            }
        }

        private void tsTxt_nhapThongTin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetterOrDigit(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void tstxt_tenLoai_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
