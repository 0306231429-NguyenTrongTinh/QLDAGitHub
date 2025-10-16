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

namespace GUI.form
{
    public partial class ThemTK: Form
    {
        TaiKhoanBLL tkb = new TaiKhoanBLL();
        NhanVienBLL nvb = new NhanVienBLL();
        private string themnv = "";
        public ThemTK( string flag)
        {
            InitializeComponent();
            themnv = flag;
        }

        private void ThemTK_Load(object sender, EventArgs e)
        {
            LoadMaNv();

            if (themnv == "fnv")
            {
                FormBorderStyle = FormBorderStyle.Sizable;
            }
            

            this.MaximizeBox = false;

            txt_mk.Multiline = false;
            txt_mk.UseSystemPasswordChar = true;

            txt_xacNhanMk.Multiline = false;
            txt_xacNhanMk.UseSystemPasswordChar = true;

            btn_Mk.BackgroundImage = GUI.Properties.Resources.eyeAn;
            btn_XnMk.BackgroundImage = GUI.Properties.Resources.eyeAn;


            txt_taiKhoan.SelectionStart = txt_taiKhoan.Text.Length;   // lỗi hai con trỏ
            txt_taiKhoan.SelectionLength = 0;
        }

        private void LoadMaNv()
        {

            List<string> l = nvb.LoadMaNvTkBLL();

            foreach (var mnv in l)
            {
                cbb_maNhanVien.Items.Add(mnv);
            }
            cbb_maNhanVien.Sorted = true;
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

        private void eyeAn(Button btn, TextBox txt)
        {
            btn.BackgroundImage = GUI.Properties.Resources.eyeAn;
            txt.UseSystemPasswordChar = true;
        }

        private void eyeHien(Button btn, TextBox txt)
        {
            btn.BackgroundImage = GUI.Properties.Resources.eyeHien;
            txt.UseSystemPasswordChar = false;
        }

        private void btn_Mk_MouseDown(object sender, MouseEventArgs e)
        {
            eyeHien(btn_Mk,txt_mk);
        }

        private void btn_Mk_MouseUp(object sender, MouseEventArgs e)
        {
            eyeAn(btn_Mk, txt_mk);
        }

        private void btn_XnMk_MouseDown(object sender, MouseEventArgs e)
        {
            eyeHien(btn_XnMk, txt_xacNhanMk);
        }

        private void btn_XnMk_MouseUp(object sender, MouseEventArgs e)
        {
            eyeAn(btn_XnMk, txt_xacNhanMk);
        }

        private void btn_themTK_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txt_taiKhoan.Text) || string.IsNullOrWhiteSpace(txt_mk.Text)
                || string.IsNullOrWhiteSpace(txt_xacNhanMk.Text) || cbb_maNhanVien.SelectedIndex==-1)
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            {
                string kq = tkb.ktTaiKhoanBLL(txt_taiKhoan.Text);
                if (kq == "tt")
                {
                    MessageBox.Show("Tài khoản đã tồn tại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }else
                {
                    if(txt_mk.Text != txt_xacNhanMk.Text)
                    {
                        MessageBox.Show("Mật khẩu và xác nhận mật khẩu không khớp!Vui lòng kiểm tra lại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        TaiKhoanDTO tk = new TaiKhoanDTO();
                        tk.MaTK = tkb.GenerateMaNhanVienBLL();
                        tk.MaNhanVien = cbb_maNhanVien.Text ;
                        tk.TenDangNhap = txt_taiKhoan.Text;
                        tk.MatKhau = txt_xacNhanMk.Text;
                        string Q = nvb.LoadQuyenNvBLL(cbb_maNhanVien.Text);
                        if (Q == "Admin")
                        {
                            tk.Quyen = "Admin";
                        }else if(Q=="Nhân viên")
                        {
                            tk.Quyen = "NhanVien";
                        }
                        else if(Q == "Quản lý")
                        {
                            tk.Quyen = "QuanLy";
                        }
                        
                        tkb.themTkBLL(tk);
                        tb("Thêm Tài Khoản Thành Công");
                        this.Close();
                    }
                    
                }

            }
        }

        private void btn_themNV_Click(object sender, EventArgs e)
        {
            NhanVien tnv = new NhanVien("fnv");
            
            tnv.ShowDialog();
           
            
        }

        private void cbb_maNhanVien_SelectedValueChanged(object sender, EventArgs e)
        {
            txt_quyen.Text = nvb.LoadQuyenNvBLL(cbb_maNhanVien.Text);
        }

        
    }
}
