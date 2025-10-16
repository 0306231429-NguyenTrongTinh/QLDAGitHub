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
    public partial class QuanLyTaiKhoan: Form
    {
        NhanVienBLL nvB = new NhanVienBLL();
        TaiKhoanBLL tkb = new TaiKhoanBLL();
        private string Quyen = "";
        public QuanLyTaiKhoan()
        {
            InitializeComponent();
        }

        private void QuanLyTaiKhoan_Load(object sender, EventArgs e)
        {
            loadDsTk();
            coll_Quyen.Items.Add("Admin");
            coll_Quyen.Items.Add("NhanVien");
            coll_Quyen.Items.Add("QuanLy");
            coll_MaNhanVien.ReadOnly = true;

            dgv_taiKhoan.CellValueChanged += dgv_taiKhoan_CellValueChanged;
            dgv_taiKhoan.CurrentCellDirtyStateChanged += dgv_taiKhoan_CurrentCellDirtyStateChanged;
        }

        private void dgv_taiKhoan_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_taiKhoan.Columns[e.ColumnIndex].Name == "coll_Quyen") // Tên cột ComboBox
            {
                // Lấy dòng hiện tại
                DataGridViewRow row = dgv_taiKhoan.Rows[e.RowIndex];

                string maTK = row.Cells["coll_MaTK"].Value.ToString(); 
                string trangThaiMoi = row.Cells["coll_Quyen"].Value.ToString();
                // Gọi hàm cập nhật database
                DialogResult dt = MessageBox.Show("Xac nhan trang thai", "Thong bao", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dt == DialogResult.OK)
                {

                    if (tkb.capNhatTrangThaiDAL(trangThaiMoi, maTK) == "stc")
                    {
                        MessageBox.Show("Sua thanh cong", "thong bao");
                        reset();
                    }
                    else
                    {
                        MessageBox.Show("Sua that bai", "thong bao");
                        reset();
                    }
                }
                else
                {
                    reset();
                    return;
                }

            }
        }

        private void dgv_taiKhoan_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgv_taiKhoan.IsCurrentCellDirty)
            {
                dgv_taiKhoan.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }


        public void loadDsTk()
        {


            List<TaiKhoanDTO> l = tkb.loadDsTaiKhoanBLL();

            dgv_taiKhoan.Rows.Clear();

            foreach (var tk in l)
            {
                dgv_taiKhoan.Rows.Add(tk.MaTK,tk.MaNhanVien,tk.TenDangNhap,tk.MatKhau,tk.Quyen);
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
        public void reset()
        {
           
            dgv_taiKhoan.Rows.Clear();
            loadDsTk();
        }

        private void tsb_xoaTaiKhoan_Click(object sender, EventArgs e)
        {


            if (dgv_taiKhoan.SelectedRows.Count > 0)
            {
                
                DialogResult dt = MessageBox.Show("Bạn có chắc muốn xóa tai khoan này?", "Thông báo",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dt == DialogResult.OK)
                {
                    DataGridViewRow row = dgv_taiKhoan.SelectedRows[0];
                    if (row.Cells["coll_Quyen"].Value.ToString() == "Admin")
                    {
                        MessageBox.Show("Khong the xoa tai khoan Admin", "Thong Bao");
                        return;
                    }
                    string kq = tkb.xoaTkBLL(row.Cells["coll_MaNhanVien"].Value.ToString());
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

        private void tsb_suaTaiKhoan_Click(object sender, EventArgs e)
        {



            if (dgv_taiKhoan.SelectedRows.Count > 0)
            {
                DialogResult dt = MessageBox.Show("Bạn có chắc muốn sửa tài khoản này?", "Thông báo",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dt == DialogResult.OK)
                {
                    DataGridViewRow row = dgv_taiKhoan.SelectedRows[0];
                    TaiKhoanDTO tk = new TaiKhoanDTO();
                    tk.MaTK= row.Cells["coll_MaTK"].Value.ToString();
                    tk.MaNhanVien = row.Cells["coll_MaNhanVien"].Value.ToString();
                    tk.TenDangNhap = row.Cells["coll_TenDangNhap"].Value.ToString();
                    tk.MatKhau = row.Cells["coll_MatKhau"].Value.ToString();
                    tk.Quyen = row.Cells["coll_Quyen"].Value.ToString();






                    string kq = tkb.updateTkBLL(tk);
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

        private void tsb_themTaiKhoan_Click(object sender, EventArgs e)
        {
            ThemTK load = new ThemTK("fnv");
            load.ShowDialog();
        }
        private void ts_lamMoiDS_Click(object sender, EventArgs e)
        {
            reset();
        }
    }
}
