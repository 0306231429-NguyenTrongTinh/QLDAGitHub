using BLL;
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
namespace GUI.form
{
    public partial class DoiMK: Form
    {
        TaiKhoanBLL tkb = new TaiKhoanBLL();

        TaiKhoanDTO tkDMK = new TaiKhoanDTO();
        private string tk;
        private string mk;
        public DoiMK( string user,string pass)
        {
            InitializeComponent();
            tk = user;
            mk = pass;
        }

        private void DoiMK_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;

            txt_mkMoi.Multiline = false;
            txt_mkMoi.UseSystemPasswordChar = true;

            txt_mkHienTai.Multiline = false;
            txt_mkHienTai.UseSystemPasswordChar = true;

            txt_xacNhanMkMoi.Multiline = false;
            txt_xacNhanMkMoi.UseSystemPasswordChar = true;

            btn_MkHT.BackgroundImage = GUI.Properties.Resources.eyeAn;
            btn_MkMoi.BackgroundImage = GUI.Properties.Resources.eyeAn;
            btn_XnMkMoi.BackgroundImage = GUI.Properties.Resources.eyeAn;
        }

        private void btn_MkHT_MouseDown(object sender, MouseEventArgs e)
        {
            eyeHien(btn_MkHT, txt_mkHienTai);
        }

        private void btn_MkHT_MouseUp(object sender, MouseEventArgs e)
        {
            eyeAn(btn_MkHT, txt_mkHienTai);
        }

        private void btn_MkMoi_MouseDown(object sender, MouseEventArgs e)
        {
            eyeHien(btn_MkMoi, txt_mkMoi);
        }

        private void btn_MkMoi_MouseUp(object sender, MouseEventArgs e)
        {
            eyeAn(btn_MkMoi, txt_mkMoi);
        }

        private void btn_XnMkMoi_MouseDown(object sender, MouseEventArgs e)
        {
            eyeHien(btn_XnMkMoi, txt_xacNhanMkMoi);
        }

        private void btn_XnMkMoi_MouseUp(object sender, MouseEventArgs e)
        {
            eyeAn(btn_XnMkMoi, txt_xacNhanMkMoi);
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

        private void btn_doiMK_Click(object sender, EventArgs e)
        {
            if(mk != txt_mkHienTai.Text)
            {
                MessageBox.Show("Mật khẩu hiện tại không chính xác", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }else
            {
                if (mk == txt_mkMoi.Text)
                {
                    MessageBox.Show("Mật khẩu mới không được trùng mật khẩu hiện tại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (txt_xacNhanMkMoi.Text != txt_mkMoi.Text)
                {
                    MessageBox.Show("Mật khẩu mới và xác nhận mật khẩu không khớp!Vui lòng kiểm tra lại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

            }

            tkDMK.TenDangNhap = tk;
            tkDMK.MatKhau = txt_mkMoi.Text;
            List<string> getUser = tkb.checkLoginBLL(tkDMK);
            if (getUser.Count > 1)
            {
                MessageBox.Show("Tài khoản và mật khẩu đã tồn tại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string kq=tkb.updateMkBLL(tk, mk, txt_mkMoi.Text);
            if (kq == "dtc")
            {
                MessageBox.Show("Đổi mật khẩu thành công!", "Thông Báo", MessageBoxButtons.OK);
                Login lg = new Login();
                this.Hide();
                lg.ShowDialog();
            }
            else
            {
                MessageBox.Show("Đổi mật khẩu thất bại!", "Thông Báo", MessageBoxButtons.OK);
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            this.Hide();
            lg.ShowDialog();
        }

        
    }
}
